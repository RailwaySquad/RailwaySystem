using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using System.Collections.Generic;

namespace Railway_Group01.Controllers.Admin
{
	public class RouteController : Controller
	{
		RailwayDbContext ctx;
		public RouteController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> RouteList()
		{
            var routes = await ctx.Routes
                .Include(r => r.StartStation)
                .Include(r => r.EndStation)
                .Include(r => r.RouteDetails) // Include RouteDetails
                .ToListAsync();

            return View(routes);
        }
		public async Task<IActionResult> CreateRoute()
		{
			var list = await ctx.Stations!.ToListAsync();
			ViewData["list"] = list;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateRoute(Data.Route route)
		{

				route.StartStation = await ctx.Stations!.FindAsync(route.StartStation.Id);
				route.EndStation = await ctx.Stations!.FindAsync(route.EndStation.Id);
				ctx.Routes!.Add(route);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Route Added successfully.";
				return RedirectToAction("RouteList");
		}
		public async Task<IActionResult> EditRoute(int id)
		{
			var route = await ctx.Routes!.SingleOrDefaultAsync(r => r.Id == id);
			var list = await ctx.Stations!.ToListAsync();
			ViewData["list"] = list;
			return View(route);
		}
		[HttpPost]
		public async Task<IActionResult> EditRoute(Data.Route route, int id)
		{
			route.StartStation = await ctx.Stations!.FindAsync(route.StartStation.Id);
			route.EndStation = await ctx.Stations!.FindAsync(route.EndStation.Id);
			ctx.Entry(route).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Route Edit successfully.";
			return RedirectToAction("RouteList");
		}
		[HttpPost]
		public async Task<IActionResult> DeleteRoute(int id)
		{
			var route = await ctx.Routes!.SingleOrDefaultAsync(r=> r.Id == id);
			if(route == null)
			{
				return NotFound();
			}
			ctx.Routes!.Remove(route);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Route Deleted successfully.";
			return RedirectToAction("RouteList");
		}
		public async Task<IActionResult> Detail(int id)
		{
			var route = await ctx.RouteDetailss!.Where(r => r.Id == id).ToListAsync();
			return View(route);
		}
	}
}
