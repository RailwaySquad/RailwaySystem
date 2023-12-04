using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            return View(GetStationSelectList());
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
        //public async Task<IActionResult> SearchRoute(
        //    [FromQuery(Name = "departure")] string departure,
        //    [FromQuery(Name = "arrival")] string arrival,
        //    [FromQuery(Name = "time")] string? time,
        //    [FromQuery(Name = "price")] string? price,
        //    [FromQuery(Name = "coach")] string? coach)
        //{
        //    int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure) : 1;
        //    int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival, out _) ? Int32.Parse(arrival) : 4;

        //    List<int> routes = await ctx.Routes!
        //        .Where(x => x.StartStationId == departureId && x.EndStationId == arrivalId).Select(x => x.Id)
        //        .ToListAsync();
        //    IEnumerable<Schedule> schedules = await ctx.Schedules!.Where(x => routes.Contains(x.RouteId)).ToListAsync();
        //    foreach (var item in schedules)
        //    {
        //        item.Train = await ctx.Trains!.FindAsync(item.TrainCode);
        //        item.Route = await ctx.Routes!.FindAsync(item.RouteId);
        //        item.Route.StartStation = await ctx.Stations.FindAsync(item.Route.StartStationId);
        //        item.Route.EndStation = await ctx.Stations.FindAsync(item.Route.EndStationId);
        //        List<Coach> coaches = await ctx.Coaches.Where(x => x.TrainCode == item.TrainCode).ToListAsync();
        //        item.Train.Coaches = new List<Coach>();
        //        foreach (var item1 in coaches)
        //        {
        //            item.Train.Coaches.Add(new Coach { Id = item1.Id, CoachNo = item1.CoachNo, NoOfSeats = item1.NoOfSeats, NoOfCompartments = item1.NoOfCompartments, TrainCode = item1.TrainCode, Class = item1.Class, Seats = item1.Seats });
        //        }
        //    }
        //    IEnumerable<Coach> coaches2 = await ctx.Coaches.ToListAsync();
        //    var coach3 = coaches2.DistinctBy(x => x.CoachNo);
        //    var tupleModel = new Tuple<IEnumerable<Schedule>, IEnumerable<Coach>>(schedules, coach3);
        //    return View(tupleModel);
        //}

        public async Task<IActionResult> Search(int from, int to, DateTime date)
        {
            var schedulesMatchRoute = await SearchScheduleByRoute(from, to);
            var result = await ctx.Schedules!
                .Where(
                    s => schedulesMatchRoute.Contains(s) &&
                    s.Departure.Date == date.Date
                ).ToListAsync();
            foreach (var schedule in result)
            {
                if (schedule.Train == null)
                {
                    schedule.Train = ctx.Trains!.SingleOrDefault(t => t.Code == schedule.TrainCode);

                    if (schedule.Train.Coaches == null)
                    {
                        schedule.Train.Coaches = ctx.Coaches!.Where(c => c.TrainCode == schedule.TrainCode).ToList();
                        
                        foreach (var coach in schedule.Train.Coaches)
                        {
                            if (coach.Seats == null)
                            {
                                coach.Seats = ctx.Seats!.Where(s => s.CoachId == coach.Id).ToList();
                            }
                        }
                    }
                }
            }
            ViewData["StationSelectList"] = GetStationSelectList();
            ViewData["ClassList"] = ctx.CoachClasses!.ToList();
            return View(result);
        }

        private List<SelectListItem> GetStationSelectList()
        {
            var stations = ctx.Stations!.ToList();
            var stationSelectList = new List<SelectListItem> { new SelectListItem() { Text = "", Value = "" } };
            foreach (var s in stations)
            {
                stationSelectList.Add(new SelectListItem() { Text = s.Name, Value = s.Id.ToString() });
            }
            return stationSelectList;
        }

        private async Task<List<Schedule>> SearchScheduleByRoute(int from, int to)
        {
            var query = string.Empty;
            if (from < to)
            {
                query = @"
                    WITH QueryRoute AS (
                      SELECT * 
                      FROM RouteDetails 
                      WHERE DepartureStationId = {0} AND DepartureStationId < ArrivalStationId
                      UNION
                      SELECT * 
                      FROM RouteDetails 
                      WHERE ArrivalStationId = {1} AND DepartureStationId < ArrivalStationId
                    )
                    , RankedDistances AS (
                      SELECT 
                        s.Id,
                        s.TrainCode,
	                    s.Arrival,
	                    s.Departure,
	                    s.IsFinished,
	                    s.Name,
	                    s.RouteId,
                        qr.Distance,
                        ROW_NUMBER() OVER (PARTITION BY s.TrainCode ORDER BY qr.Distance DESC) AS rn
                      FROM 
                        QueryRoute qr 
                        JOIN Schedules s ON qr.RouteId = s.RouteId
                    )
                    SELECT
                      Id,
                      TrainCode,
	                  Arrival,
	                  Departure,
	                  IsFinished,
	                  Name,
	                  RouteId
                    FROM
                      RankedDistances
                    WHERE
                      rn = 1;";
            }
            else
            {
                query = @"
                    WITH QueryRoute AS (
                      SELECT * 
                      FROM RouteDetails 
                      WHERE DepartureStationId = {0} AND DepartureStationId > ArrivalStationId
                      UNION
                      SELECT * 
                      FROM RouteDetails 
                      WHERE ArrivalStationId = {1} AND DepartureStationId > ArrivalStationId
                    )
                    , RankedDistances AS (
                      SELECT 
                        s.Id,
                        s.TrainCode,
	                    s.Arrival,
	                    s.Departure,
	                    s.IsFinished,
	                    s.Name,
	                    s.RouteId,
                        qr.Distance,
                        ROW_NUMBER() OVER (PARTITION BY s.TrainCode ORDER BY qr.Distance DESC) AS rn
                      FROM 
                        QueryRoute qr 
                        JOIN Schedules s ON qr.RouteId = s.RouteId
                    )
                    SELECT
                      Id,
                      TrainCode,
	                  Arrival,
	                  Departure,
	                  IsFinished,
	                  Name,
	                  RouteId
                    FROM
                      RankedDistances
                    WHERE
                      rn = 1;";
            }
          
            return await ctx.Schedules!.FromSqlRaw(query, from, to).ToListAsync();
        }

        public async Task<IActionResult> TrainDetail(
            [FromQuery(Name = "departure")] string departure,
            [FromQuery(Name = "arrival")] string arrival, 
            [FromQuery(Name = "time")] string? time)
        {
            int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure) : 1;
            int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival, out _) ? Int32.Parse(arrival) : 4;
            int routeId = await ctx.Routes!.Where(x => x.StartStationId == departureId && x.EndStationId == arrivalId).Select(x=>x.Id).FirstOrDefaultAsync();
            DateTime timeS = !String.IsNullOrEmpty(time) || DateTime.TryParse(time, out _) ? DateTime.Parse(time) : DateTime.Parse("2023-12-2");
            Schedule? sche = await ctx.Schedules!.Where(x => x.Departure >= timeS && x.Arrival<= timeS.AddDays(1) && x.RouteId==routeId && x.TrainCode=="SE801").Include(x=>x.Route).FirstAsync();
            if (sche != null)
            {
                sche.Route.StartStation = await ctx.Stations!.FindAsync(sche.Route.StartStationId);
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
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
