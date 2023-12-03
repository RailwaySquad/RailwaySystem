using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;

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
            return View();
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
        public async Task<IActionResult> SearchRoute(
            [FromQuery(Name = "departure")] string departure, 
            [FromQuery(Name = "arrival")] string arrival, 
            [FromQuery(Name = "time")] string? time, 
            [FromQuery(Name = "price")] string? price, 
            [FromQuery(Name = "coach")] string? coach)
        {
            int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure): 1;
            int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival,out _) ? Int32.Parse(arrival):4;

            List<int> routes = await ctx.Routes!
                .Where(x => x.StartStationId == departureId && x.EndStationId== arrivalId).Select(x=>x.Id)
                .ToListAsync();
            IEnumerable<Schedule> schedules = await ctx.Schedules!.Where(x=> routes.Contains(x.RouteId)).ToListAsync();
            foreach (var item in schedules)
            {
                item.Train = await ctx.Trains!.FindAsync(item.TrainCode);
                item.Route = await ctx.Routes!.FindAsync(item.RouteId);
                item.Route.StartStation = await ctx.Stations.FindAsync(item.Route.StartStationId);
                item.Route.EndStation = await ctx.Stations.FindAsync(item.Route.EndStationId);
                List<Coach> coaches =await ctx.Coachs.Where(x=>x.TrainCode == item.TrainCode).ToListAsync();
                item.Train.Coaches = new List<CoachDto>();
                foreach (var item1 in coaches)
                {
                    item.Train.Coaches.Add(new CoachDto { Id = item1.Id, Name = item1.Name, NoOfSeat = item1.NoOfSeat, Description = item1.Description, NoOfCompartment = item1.NoOfCompartment, TrainCode = item1.TrainCode, SeatAvailable = item1.SeatAvailable, TypeCode = item1.TypeCode });
                }
                foreach (var item2 in item.Train.Coaches)
                {
                    Fare? fee = await ctx.Fares!.FirstOrDefaultAsync(x => x.TypeOfTrain == item.Train.TypeCode && x.TypeOfClass == item2.TypeCode);
                    Console.WriteLine(fee.Price);
                    item2.CoachFare =  (fee.Price+1 )* (fee.DistanceRange * item.Route.Distance)/100;
                }
            }
            IEnumerable<Coach> coaches2 = await ctx.Coachs.ToListAsync();
            var coach3 = coaches2.DistinctBy(x => x.Name);
            var tupleModel = new Tuple<IEnumerable<Schedule>,IEnumerable<Coach>>(schedules,coach3);
            return View(tupleModel);

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
            Schedule? sche = await ctx.Schedules!.Where(x => x.StartAt >= timeS && x.StartAt<= timeS.AddDays(1) && x.RouteId==routeId && x.TrainCode=="SE801").Include(x=>x.Route).FirstAsync();
            if (sche != null)
            {
                sche.Route.StartStation = await ctx.Stations!.FindAsync(sche.Route.StartStationId);
                sche.Route.EndStation = await ctx.Stations!.FindAsync(sche.Route.EndStationId);
                sche.Route.RouteDetails = await ctx.RouteDetailss!.Where(x => x.RouteId == sche.Route.Id).Include(x=>x.ArrivalStation).Include(x=>x.DepartureStation).ToListAsync();
            }
            else
            {
                return RedirectToAction("Error404",new { type = "schedule" });
            }
            int stop = await ctx.RouteDetailss!.Where(x => x.RouteId == routeId).CountAsync() - 2;
            Train? train = await ctx.Trains!.Include(x=>x.Schedules).Include(x=>x.CoachesData).FirstOrDefaultAsync(x=>x.TrainCode=="SE801");
            if(train == null)
            {
                return RedirectToAction("Error404", new { type = "train" });
            }
            var tuple = new Tuple<Schedule, Train,int>(sche, train,stop);
            return View(tuple);
        }
    }
}
