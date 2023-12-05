using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;

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

        public async Task<IActionResult> Search([FromQuery] RailwaySearchModel railwayModel)
        {
            
            var schedulesMatchRoute = await ctx.SearchScheduleByRoute(railwayModel.From, railwayModel.To);
            /*var result = await ctx.Schedules!
                .Where(
                    s => schedulesMatchRoute.Contains(s) &&
                    s.Departure.Date == railwayModel.StartDate.Date
                ).ToListAsync();*/
            railwayModel.Schedules = await GetScheduleRelationships(schedulesMatchRoute, railwayModel.From,railwayModel.To, railwayModel.StartDate);
            
            ViewData["FromStationSelectList"] = GetStationSelectList(railwayModel.From);
            ViewData["ToStationSelectList"] = GetStationSelectList(railwayModel.To);
            ViewData["ClassList"] = ctx.CoachClasses!.ToList();
            return View(railwayModel);
        }

        private async Task<List<Schedule>> GetScheduleRelationships(List<Schedule> schedules,int from, int to, DateTime startTime)
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
                        travel1 = await ctx.RouteDetails!.Where(x => x.DepartureStationId <= schedule.Route.StartStationId && x.ArrivalStationId >= from && x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                        travel2= await ctx.RouteDetails!.Where(x => x.DepartureStationId <= schedule.Route.StartStationId && x.ArrivalStationId >= to && x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                    }
                    else
                    {
                        schedule.Route!.RouteDetails = await ctx.RouteDetails!.Where(x=>x.DepartureStationId >= from && x.ArrivalStationId<=to && x.RouteId ==schedule.RouteId).Include(x=>x.DepartureStation).Include(x=>x.ArrivalStation).ToListAsync();
                        travel1 = await ctx.RouteDetails!.Where(x => x.DepartureStationId >= schedule.Route.StartStationId && x.ArrivalStationId <=from && x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                        travel2= await ctx.RouteDetails!.Where(x => x.DepartureStationId >= schedule.Route.StartStationId && x.ArrivalStationId <= to && x.RouteId == schedule.RouteId).Select(x => x.TravelTime).SumAsync();
                    }
                    DateTime start = schedule.Departure.Add(TimeSpan.FromMinutes(travel1));
                    DateTime end = schedule.Departure.Add(TimeSpan.FromMinutes(travel2));
                    schedule.Departure = start;
                    schedule.Arrival = end;
                    if (schedule.Route!.RouteDetails.Last().ArrivalStationId != to || schedule.Route!.RouteDetails.First().DepartureStationId!=from || schedule.Departure.Date != startTime.Date)
                    {
                        filter.Add(schedule);
                    }
                }

                if (schedule.Train == null)
                {
                    schedule.Train = await ctx.Trains!.SingleOrDefaultAsync(t => t.Code == schedule.TrainCode);

                    if (schedule.Train!.Coaches == null)
                    {
                        schedule.Train.Coaches = await ctx.Coaches!.Where(c => c.TrainCode == schedule.TrainCode).ToListAsync();

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
            [FromQuery(Name = "departure")] string departure,
            [FromQuery(Name = "arrival")] string arrival, 
            [FromQuery(Name = "time")] string? time)
        {
            int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure) : 1;
            int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival, out _) ? Int32.Parse(arrival) : 38;
            int routeId = await ctx.Routes!.Where(x => x.StartStationId == departureId && x.EndStationId == arrivalId).Select(x=>x.Id).FirstOrDefaultAsync();
            DateTime timeS = !String.IsNullOrEmpty(time) || DateTime.TryParse(time, out _) ? DateTime.Parse(time) : DateTime.Parse("2023-12-5");
            Schedule? sche = await ctx.Schedules!.Where(x => x.Departure >= timeS && x.Arrival<= timeS.AddDays(1) && x.RouteId==routeId && x.TrainCode=="SE801").Include(x=>x.Route).FirstAsync();
            if (sche != null)
            {
                sche.Route!.StartStation = await ctx.Stations!.FindAsync(sche.Route.StartStationId);
                sche.Route.EndStation = await ctx.Stations!.FindAsync(sche.Route.EndStationId);
                sche.Route.RouteDetails = await ctx.RouteDetails!.Where(x => x.RouteId == sche.Route.Id).Include(x=>x.ArrivalStation).Include(x=>x.DepartureStation).ToListAsync();
            }
            else
            {
                return RedirectToAction("Error404",new { type = "schedule" });
            }
            int stop = await ctx.RouteDetails!.Where(x => x.RouteId == routeId).CountAsync() - 2;
            Train? train = await ctx.Trains!.Include(x=>x.Schedules).Include(x=>x.Coaches).FirstOrDefaultAsync(x=>x.Code=="SE801");
            if(train == null)
            {
                return RedirectToAction("Error404", new { type = "train" });
            }
            var tuple = new Tuple<Schedule, Train,int>(sche, train,stop);
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
    }
}
