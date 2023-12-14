using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models.ViewModels;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class StationMasterController : Controller
	{
		RailwayDbContext ctx;
		public StationMasterController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> StationMaster(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Stations.CountAsync(); 
			var stations = await ctx.Stations!
				.OrderByDescending(s => s.Id)
				.Skip((page - 1) * pageSize)
				.Take(pageSize).ToListAsync();

			ViewBag.Stations = stations;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;
            ViewBag.counter = (page - 1) * pageSize + 1; 

            return View(stations);
		}
		public IActionResult CreateStation()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateStation(Station station)
		{
			if (ModelState.IsValid)
			{
				// Check if a station with the same code already exists
				bool stationExists = await ctx.Stations.AnyAsync(s => s.Code == station.Code);

				if (stationExists)
				{
					ModelState.AddModelError("Code", "Station with this code already exists.");
					return View(station);
				}

				// If the station doesn't exist, proceed with adding it to the database
				ctx.Stations!.Add(station);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Station added successfully.";
				return RedirectToAction("StationMaster");
			}

			return View(station);
		}

		public async Task<IActionResult> EditStation(int id)
		{
			var station = await ctx.Stations!.SingleOrDefaultAsync(s => s.Id == id);
			return View(station);
		}
		[HttpPost]
		public async Task<IActionResult> EditStation(Station station, int id)
		{
			if (ModelState.IsValid)
			{
				bool stationWithSameCodeExists = await ctx.Stations.AnyAsync(s => s.Code == station.Code && s.Id != id);

				if (stationWithSameCodeExists)
				{
					ModelState.AddModelError("Code", "Station with this code already exists.");
					return View(station);
				}
				ctx.Entry(station).State = EntityState.Modified;
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Station edited successfully.";
				return RedirectToAction("StationMaster");
			}

			return View(station);
		}
		/*[HttpPost]
		public async Task<IActionResult> DeleteStation(int id)
		{
			var station = await ctx.Stations!
				.Include(s => s.StartRoutes)
				.Include(s => s.EndRoutes)
				.Include(s => s.DepartureRouteDetails)
				.Include(s => s.ArrivalRouteDetails)
				.SingleOrDefaultAsync(s => s.Id == id);

			if (station == null)
			{
				return NotFound();
			}

			ctx.RouteDetails.RemoveRange(station.DepartureRouteDetails);
			ctx.RouteDetails.RemoveRange(station.ArrivalRouteDetails);
			ctx.Routes.RemoveRange(station.StartRoutes);
			ctx.Routes.RemoveRange(station.EndRoutes);

			ctx.Stations!.Remove(station);

			await ctx.SaveChangesAsync();

			TempData["SuccessMessage"] = "Station deleted successfully.";
			return RedirectToAction("StationMaster");
		}*/
		public async Task<IActionResult> SearchStation(string name)
		{
			var station = await ctx.Stations!.Where(s => s.Name.Contains(name)).ToListAsync();
			return View("StationMaster", station);
		}
	}
}
