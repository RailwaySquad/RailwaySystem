using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Diagnostics;

namespace Railway_Group01.Controllers
{
    public class HomeController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;

        public HomeController(RailwayDbContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var stations = _ctx.Stations!.ToList();
            var stationSelectList = new List<SelectListItem> { new SelectListItem() { Text = "", Value = "" } };

            foreach (var s in stations)
            {
                stationSelectList.Add(new SelectListItem() { Text = s.Name, Value = s.Id.ToString() });
            }
            var model = new HomeViewModel();
            model.StationsSelectList = stationSelectList;

            return View(model);
        }


        public async Task<IActionResult> Search(int from, int to, DateTime date)
        {
            var trains = await SearchTrainByRoute(from, to);
            var schedules = await _ctx.Schedules!
                .Where(
                    s => trains.Contains(s) &&
                    s.Departure.Date == date.Date
                ).ToListAsync();
            return View(schedules);
        }

        private async Task<List<Schedule>> SearchTrainByRoute(int from, int to)
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
	                  RouteId,
                    FROM
                      RankedDistances
                    WHERE
                      rn = 1;";
            }

            var result = await _ctx.Schedules!.FromSqlRaw(query, from, to).ToListAsync();

            return result;
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
