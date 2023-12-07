using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Runtime.CompilerServices;

namespace Railway_Group01.Controllers
{
    public class RailwayController : Controller
    {
        public RailwayDbContext ctx;
        public RailwayController(RailwayDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            RailwayIndexModel railwayIndexModel = new()
            {
                SelectListItems = GetStationSelectList()
            };
            return View(railwayIndexModel);
        }

        public IActionResult Error404([FromQuery(Name ="type")] string? type)
        {
            switch (type)
            {
                case "schedule":
                    ViewData["message_title"] = "Not Found Schedule";
                    ViewData["message_detail"] = "Sorry we can not found any schedule you want. Back to Home Page and try again";
                    break;
                case "train":
                    ViewData["message_title"] = "Not Found Train";
                    ViewData["message_detail"] = "Sorry we can not found any train you searching. Back to Home Page and try again";
                    break;
                default:
                    ViewData["message_title"] = "Error 404 Not Found ";
                    ViewData["message_detail"] = "Sorry we can not this page.";
                    break;
            }
            return View();
        }

        public async Task<IActionResult> Search([FromQuery] RailwaySearchModel railwayModel,
                                                [FromQuery(Name = "coachTypes[]")] string[]? coachTypes,
                                                [FromQuery(Name = "time")] int? time )
        {
            
            var schedulesMatchRoute = await ctx.SearchScheduleByRoute(railwayModel.From, railwayModel.To);
            /*var result = await ctx.Schedules!
                .Where(
                    s => schedulesMatchRoute.Contains(s) &&
                    s.Departure.Date == railwayModel.StartDate.Date
                ).ToListAsync();*/
            railwayModel.Schedules = await GetScheduleRelationships(schedulesMatchRoute, railwayModel.From,railwayModel.To, railwayModel.StartDate,time,coachTypes);
            
            string? jsonSession = HttpContext.Session.GetString("listCart");
            if(jsonSession != null)
            {
                ViewData["CartList"] = JsonConvert.DeserializeObject<List<CartDto>>(jsonSession);
            }
            ViewData["CoachTypeSelect"] = coachTypes.ToList();
            ViewData["TimeSelect"] = time;
            ViewData["FromStationSelectList"] = GetStationSelectList(railwayModel.From);
            ViewData["ToStationSelectList"] = GetStationSelectList(railwayModel.To);
            ViewData["ClassList"] = ctx.CoachClasses!.ToList();

            return View(railwayModel);
        }
        private async Task<List<Schedule>> GetScheduleRelationships(List<Schedule> schedules,int from, int to, DateTime startTime, int? time = 0, string[]? coachTypes = null)
        {
            List<Schedule> filter = new List<Schedule>();
            int travel1 = 0;
            int travel2 = 0;
            foreach (var schedule in schedules)
            {
                if (schedule.Route == null)
                {
                    schedule.Route = await ctx.Routes!.FindAsync(schedule.RouteId);
                    if(from > to)
                    {
                        schedule.Route!.RouteDetails = await ctx.RouteDetails!.Where(x => x.DepartureStationId <= from && x.ArrivalStationId >= to && x.RouteId == schedule.RouteId).Include(x => x.DepartureStation).Include(x => x.ArrivalStation).ToListAsync();
                        
                        travel1 = await ctx.RouteDetails!.Where(x => 
                                        x.DepartureStationId <= schedule.Route.StartStationId && 
                                        x.ArrivalStationId >= schedule.Route.EndStationId &&
                                        x.DepartureStationId > from && 
                                        x.RouteId == schedule.RouteId ).Select(x => x.TravelTime).SumAsync();
                        travel2 = await ctx.RouteDetails!.Where(x =>
                                        x.DepartureStationId <= schedule.Route.StartStationId &&
                                        x.ArrivalStationId >= schedule.Route.EndStationId && 
                                        x.ArrivalStationId >= to && 
                                        x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();

                    }
                    else
                    {
                        schedule.Route!.RouteDetails = await ctx.RouteDetails!.Where(x=>x.DepartureStationId >= from && x.ArrivalStationId<=to && x.RouteId ==schedule.RouteId).Include(x=>x.DepartureStation).Include(x=>x.ArrivalStation).ToListAsync();
                        travel1 = await ctx.RouteDetails!.Where(x => 
                                        x.DepartureStationId >= schedule.Route.StartStationId  && 
                                        x.ArrivalStationId <= schedule.Route.EndStationId &&
                                        x.DepartureStationId < from && 
                                        x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                        travel2 = await ctx.RouteDetails!.Where(x => 
                                        x.DepartureStationId >= schedule.Route.StartStationId && 
                                        x.ArrivalStationId <=schedule.Route.EndStationId &&
                                        x.ArrivalStationId <= to && 
                                        x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                    }
                    DateTime start = schedule.Departure.Add(TimeSpan.FromMinutes(travel1));
                    DateTime end = schedule.Departure.Add(TimeSpan.FromMinutes(travel2));
                    schedule.Departure = start;
                    schedule.Arrival = end;
                    if ( schedule.Route!.RouteDetails.Count >1 && 
                        (schedule.Route!.RouteDetails.Last().ArrivalStationId != to || 
                        schedule.Route!.RouteDetails.First().DepartureStationId!=from) || 
                        schedule.Route!.RouteDetails.Count ==1 && (schedule.Route!.RouteDetails.FirstOrDefault().ArrivalStationId!=to || schedule.Route!.RouteDetails.FirstOrDefault().DepartureStationId!=from) ||
                        schedule.Departure.Date != startTime.Date || 
                        schedule.Route.RouteDetails.Count ==0 )
                    {
                        filter.Add(schedule);
                    }
                    if (time != 0)
                    {
                        switch (time)
                        {
                            case 1:
                                if( schedule.Departure.Hour > startTime.AddHours(6).Hour){
                                    filter.Add(schedule);
                                }
                                break;
                            case 2:
                                if(schedule.Departure.Hour <= startTime.AddHours(6).Hour || schedule.Departure.Hour > startTime.AddHours(12).Hour)
                                {
                                    filter.Add(schedule);
                                }
                                break;
                            case 3:
                                if(schedule.Departure.Hour <= startTime.AddHours(12).Hour || schedule.Departure.Hour >startTime.AddHours(18).Hour)
                                {
                                    filter.Add(schedule);
                                }
                                break;
                            case 4:
                                if(schedule.Departure.Hour <= startTime.AddHours(18).Hour || schedule.Departure.Hour >startTime.AddHours(24).Hour)
                                {
                                    filter.Add(schedule);
                                };
                                break;
                            default:
                                break;
                        }
                    }
                }

                if (schedule.Train == null)
                {
                    schedule.Train = await ctx.Trains!.SingleOrDefaultAsync(t => t.Code == schedule.TrainCode);

                    if (schedule.Train!.Coaches == null)
                    {
                        if (coachTypes != null && coachTypes.Length>0)
                        {
                            schedule.Train.Coaches = await ctx.Coaches!.Where(x=>x.TrainCode == schedule.TrainCode && coachTypes.Contains(x.ClassCode)).Include(x => x.Class).ToListAsync();
                        }
                        else
                        {
                            schedule.Train.Coaches = await ctx.Coaches!.Where(c => c.TrainCode == schedule.TrainCode).Include(x=>x.Class).ToListAsync();
                        }

                        foreach (var coach in schedule.Train.Coaches)
                        {
                            coach.Seats ??= await ctx.Seats!.Where(s => s.CoachId == coach.Id).Select(s => s).ToListAsync();
                        }
                    }
                }
            }
            if (filter.Count > 0)
            {
                foreach (var rm in filter)
                {
                    schedules.Remove(rm);
                }
            }
            return schedules;
        }

        private List<SelectListItem> GetStationSelectList(int selectedStationId = -1)
        {
            var stations = ctx.Stations!.ToList();
            var stationSelectList = new List<SelectListItem> { new SelectListItem() { Text = " Station", Value = "", Disabled = true, Selected = true } };
            foreach (var s in stations)
            {
                stationSelectList.Add(new SelectListItem() { Text = s.Name, Value = s.Id.ToString(), Selected = selectedStationId == s.Id });
            }
            return stationSelectList;
        }
        
        public async Task<IActionResult> TrainDetail(
            [FromQuery(Name = "traincode")] string? trainCode,
            [FromQuery(Name = "departure")] string? departure,
            [FromQuery(Name = "arrival")] string? arrival, 
            [FromQuery(Name = "time")] DateTime? time
            )
        {
            if(String.IsNullOrEmpty(trainCode)) //|| String.IsNullOrEmpty(departure) || String.IsNullOrEmpty(arrival) || String.IsNullOrEmpty(time)
            {
                return RedirectToAction("Error404", new { type = "train" });
            }
            Train? train = await ctx.Trains!.Include(x=>x.Coaches).Include(x=>x.Type).FirstOrDefaultAsync(x=>x.Code == trainCode.ToUpper());
            if (train == null)
            {
                return RedirectToAction("Error404", new { type = "train" });
            }
            foreach (var item in train.Coaches)
            {
                item.Class = await ctx.CoachClasses!.FirstOrDefaultAsync(x=>x.Code == item.ClassCode);
            }
            int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure) : 1;
            int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival, out _) ? Int32.Parse(arrival) : 38;
            int count = ((arrivalId - departureId) ==1|| (departureId - arrivalId)==1)? 0 : 1;
            List<int> routeIds = await ctx.RouteDetails!.Where(x=>
                                    x.DepartureStationId == departureId || 
                                    x.ArrivalStationId == arrivalId && 
                                    (departureId < arrivalId ? x.DepartureStationId < x.ArrivalStationId: x.DepartureStationId> x.ArrivalStationId))
                                    .GroupBy(x => x.RouteId)
                                    .Where(grp => grp.Count() > count)
                                    .Select(grp => grp.Key).ToListAsync();
            if (routeIds.Count == 0)
            {
                return RedirectToAction("Error404", new { type = "schedule" });
            }
            time.GetValueOrDefault();
            Schedule? sche = await ctx.Schedules!.Where(x => 
                                    routeIds.Contains(x.RouteId) &&
                                    x.Departure.Date <= time.Value.Date &&
                                    x.TrainCode == trainCode 
                                    ).Include(x=>x.Route).FirstOrDefaultAsync();
            int travel1 = 0;
            int travel2 = 0;
            Station startStation;
            Station endStation;
            int duration = 0;
            if (sche != null)
            {
                sche.Route.RouteDetails = await ctx.RouteDetails!.Where(x => x.RouteId == sche.RouteId).ToListAsync();
                startStation = await ctx.Stations!.FirstOrDefaultAsync(x=>x.Id == departureId);
                endStation = await ctx.Stations!.FirstOrDefaultAsync(x=>x.Id == arrivalId);
                sche.Route.RouteDetails = await ctx.RouteDetails!.Where(x => x.RouteId == sche.Route.Id).Include(x=>x.ArrivalStation).Include(x=>x.DepartureStation).ToListAsync();
                if (departureId > arrivalId)
                {
                    travel1 = await ctx.RouteDetails!.Where(x => x.DepartureStationId > departureId && x.RouteId == sche.RouteId).Select(x => x.TravelTime).SumAsync();
                    travel2 = await ctx.RouteDetails!.Where(x => x.ArrivalStationId >= arrivalId && x.RouteId == sche.RouteId).Select(x => x.TravelTime).SumAsync();
                }
                else
                {
                    travel1 = await ctx.RouteDetails!.Where(x => x.DepartureStationId < departureId && x.RouteId == sche.RouteId).Select(x => x.TravelTime).SumAsync();
                    travel2 = await ctx.RouteDetails!.Where(x => x.ArrivalStationId <= arrivalId && x.RouteId == sche.RouteId).Select(x => x.TravelTime).SumAsync();
                }
                DateTime start = sche.Departure.Add(TimeSpan.FromMinutes(travel1));
                DateTime end = sche.Departure.Add(TimeSpan.FromMinutes(travel2));
                duration = travel2 - travel1;
                sche.Departure = start;
                sche.Arrival = end;
            }
            else
            {
                return RedirectToAction("Error404",new { type = "schedule" });
            }
            int stop = await ctx.RouteDetails!.Where(x => x.RouteId == sche.RouteId && (departureId > arrivalId ? (x.DepartureStationId <=departureId && x.ArrivalStationId >= arrivalId): (x.DepartureStationId >= departureId && x.ArrivalStationId <= arrivalId))).CountAsync();            
            var tuple = new Tuple<Schedule, Train,Station,Station,int,int>(sche, train,startStation,endStation,stop,duration);
            return View(tuple);
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult  Booking()
        {
            string? listCart = HttpContext.Session.GetString("listCart");
            if (listCart != null)
            {
                List<CartDto>? carts = JsonConvert.DeserializeObject<List<CartDto>>(listCart);
                return View(carts);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> SearchTrain([FromQuery(Name = "traincode")] string? trainCode) {
            IEnumerable<Schedule> schedule = await ctx.Schedules!.Include(x => x.Train).Include(train=>train.Train.Coaches).Include(x=>x.Route).Include(x=>x.Route.RouteDetails).Where(x=>x.Name.Contains(trainCode)).ToListAsync();
            foreach (var item in schedule)
            {
                Console.WriteLine(item);
            }
            ViewData["Name"] = trainCode;
            return View(schedule);
        }
    }
}
