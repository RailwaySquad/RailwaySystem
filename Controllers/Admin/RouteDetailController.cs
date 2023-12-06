using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class RouteDetailController : Controller
	{
		RailwayDbContext ctx;
		public RouteDetailController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> RouteDetailList()
		{
			var route = await ctx.RouteDetails!
				.Include(r=>r.ArrivalStation)
				.Include(r=>r.DepartureStation)
				.Include(r=>r.Route.StartStation)
				.Include(r => r.Route.EndStation)
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
		public async Task<IActionResult> CreateRouteDetail(RouteDetailDTO routeDetailDTO)
		{
			if (ModelState.IsValid)
			{

				var routeDetail = new RouteDetail()
				{
					DepartureStationId= routeDetailDTO.DepartureStationId,
					ArrivalStationId = routeDetailDTO.ArrivalStationId,
					RouteId = routeDetailDTO.RouteId,
					Distance = routeDetailDTO.Distance,
					TravelTime = routeDetailDTO.TravelTime,
					DelayTime = routeDetailDTO.DelayTime
				};

				ctx.RouteDetails.Add(routeDetail);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "RouteDetail Added successfully.";
				return RedirectToAction("RouteDetailList");
			}
			// Đặt ViewData ở đây để giữ nguyên dữ liệu khi có lỗi
			var listStation = await ctx.Stations!.ToListAsync();
			ViewData["liststation"] = listStation;

			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			return View(routeDetailDTO);
		}
		public async Task<IActionResult> EditRouteDetail(int id)
		{
			var listStation = await ctx.Stations!.ToListAsync();
			ViewData["liststation"] = listStation;
			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			var route = await ctx.RouteDetails!.SingleOrDefaultAsync(r=>r.Id == id);
			return View(route);
		}
		[HttpPost]
		public async Task<IActionResult> EditRouteDetail(RouteDetail routeDetails,int id)
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
			var route = await ctx.RouteDetails!.SingleOrDefaultAsync(r => r.Id == id);

			if (route == null)
			{
				return NotFound();
			}

			ctx.RouteDetails!.Remove(route);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "RouteDetail Deleted successfully.";
			return RedirectToAction("RouteDetailList");
		}
	}
}
