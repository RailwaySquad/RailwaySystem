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
        public async Task<IActionResult> SearchRoute(
            [FromQuery(Name = "departure")] string departure, 
            [FromQuery(Name = "arrival")] string arrival, 
            [FromQuery(Name = "time")] string? time, 
            [FromQuery(Name = "price")] string? price, 
            [FromQuery(Name = "coach")] string? coach)
        {
            int departureId = !String.IsNullOrEmpty(departure) || int.TryParse(departure, out _) ? Int32.Parse(departure): 1;
            int arrivalId = !String.IsNullOrEmpty(arrival) || int.TryParse(arrival,out _) ? Int32.Parse(arrival):4;

            List<int> routedetails = await ctx.Routes!
                .Where(x => x.StartStationId == departureId && x.EndStationId== arrivalId).Select(x=>x.Id)
                .ToListAsync();
            IEnumerable<Schedule> schedules = await ctx.Schedules!.Where(x=> routedetails.Contains(x.RouteId)).ToListAsync();
            foreach (var item in schedules)
            {
                item.Train = await ctx.Trains!.FindAsync(item.TrainCode);
                item.Route = await ctx.Routes!.FindAsync(item.RouteId);
                item.Route.StartStation = await ctx.Stations.FindAsync(item.Route.StartStationId);
                item.Route.EndStation = await ctx.Stations.FindAsync(item.Route.EndStationId);
                List<Coach> coaches =await ctx.Coachs.Where(x=>x.TrainCode == item.TrainCode).ToListAsync();
                item.Train.Coaches = new List<CoachModel>();
                foreach (var item1 in coaches)
                {
                    item.Train.Coaches.Add(new CoachModel { Id = item1.Id, Name = item1.Name, NoOfSeat = item1.NoOfSeat, Description = item1.Description, NoOfCompartment = item1.NoOfCompartment, TrainCode = item1.TrainCode, SeatAvailable = item1.SeatAvailable, TypeCode = item1.TypeCode });
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
    }
}
