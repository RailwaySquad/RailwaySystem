using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace Railway_Group01.Controllers.Admin
{
	public class RouteDetailController : Controller
	{
		RailwayDbContext ctx;
		public RouteDetailController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> RouteDetailList()
		{
			var route = await ctx.RouteDetailss!
				.Include(r=>r.ArrivalStation)
				.Include(r=>r.DepartureStation)
				.Include(r=>r.Route)
				.ToListAsync();
			return View(route);
		}
		public async Task<IActionResult> CreateRouteDetail()
		{
			var listStation= await ctx.Stations!.ToListAsync();
			ViewData["liststation"] = listStation;
			var listRoute = await ctx.Routes!.Include(r=>r.StartStation).Include(r=>r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateRouteDetail(RouteDetails routeDetails)
		{
			routeDetails.Route = await ctx.Routes!.FindAsync(routeDetails.Route.Id);
			routeDetails.DepartureStation = await ctx.Stations!.FindAsync(routeDetails.DepartureStation.Id);
			routeDetails.ArrivalStation = await ctx.Stations!.FindAsync(routeDetails.ArrivalStation.Id);
			ctx.RouteDetailss!.Add(routeDetails);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "RouteDetail Added successfully.";
			return RedirectToAction("RouteDetailList");
		}
		public async Task<IActionResult> EditRouteDetail(int id)
		{
			var listStation = await ctx.Stations!.ToListAsync();
			ViewData["liststation"] = listStation;
			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			var route = await ctx.RouteDetailss!.SingleOrDefaultAsync(r=>r.Id == id);
			return View(route);
		}
		[HttpPost]
		public async Task<IActionResult> EditRouteDetail(RouteDetails routeDetails,int id)
		{
			routeDetails.Route = await ctx.Routes!.FindAsync(routeDetails.Route.Id);
			routeDetails.DepartureStation = await ctx.Stations!.FindAsync(routeDetails.DepartureStation.Id);
			routeDetails.ArrivalStation = await ctx.Stations!.FindAsync(routeDetails.ArrivalStation.Id);
			ctx.Entry(routeDetails).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "RouteDetail Edit successfully.";
			return RedirectToAction("RouteDetailList");
		}
		[HttpPost]
		public async Task<IActionResult> DeleteRouteDetail(int id)
		{
			var route = await ctx.RouteDetailss!.SingleOrDefaultAsync(r => r.Id == id);

			if (route == null)
			{
				return NotFound();
			}

			ctx.RouteDetailss!.Remove(route);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "RouteDetail Deleted successfully.";
			return RedirectToAction("RouteDetailList");
		}
	}
}
