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
		public async Task<IActionResult> RouteDetailList(int page = 1, int pageSize = 10)
		{
            var totalItemCount = await ctx.RouteDetails.CountAsync();
            var route = await ctx.RouteDetails!
				.OrderByDescending(r => r.Id)
				.Include(r=>r.ArrivalStation)
				.Include(r=>r.DepartureStation)
				.Include(r=>r.Route.StartStation)
				.Include(r => r.Route.EndStation)
				.Skip((page - 1) * pageSize).Take(pageSize)
				.ToListAsync();
            ViewBag.RouteDetails = route;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalItemCount = totalItemCount;
			ViewBag.counter = (page - 1) * pageSize + 1;
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
			// Check if the combination of DepartureStationId, ArrivalStationId, and RouteId already exists
			var existingRouteDetail = await ctx.RouteDetails
				.FirstOrDefaultAsync(r =>
					r.DepartureStationId == routeDetailDTO.DepartureStationId &&
					r.ArrivalStationId == routeDetailDTO.ArrivalStationId &&
					r.RouteId == routeDetailDTO.RouteId);

			if (existingRouteDetail != null)
			{
				ModelState.AddModelError("", "RouteDetail with the same combination already exists.");
			}
			else if (ModelState.IsValid)
			{
				// Create new RouteDetail if the model is valid and the combination doesn't exist
				var routeDetail = new RouteDetail
				{
					DepartureStationId = routeDetailDTO.DepartureStationId,
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
		public async Task<IActionResult> EditRouteDetail(RouteDetail routeDetails, int id)
		{
			ModelState.Clear();

			if (!ModelState.IsValid)
			{
				var stationsForView = await ctx.Stations!.ToListAsync();
				ViewData["liststation"] = stationsForView;

				var routesForView = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
				ViewData["listroute"] = routesForView;

				return View(routeDetails);
			}

			var existingRoute = await ctx.RouteDetails.FindAsync(id);

			if (existingRoute != null)
			{
				routeDetails.Route = await ctx.Routes!.FindAsync(routeDetails.RouteId);
				routeDetails.DepartureStation = await ctx.Stations!.FindAsync(routeDetails.DepartureStationId);
				routeDetails.ArrivalStation = await ctx.Stations!.FindAsync(routeDetails.ArrivalStationId);

				if (routeDetails.DepartureStation != null && routeDetails.ArrivalStation != null)
				{
					bool routeExists = await ctx.RouteDetails.AnyAsync(r => r.Id != id &&
																	   r.DepartureStationId == routeDetails.DepartureStationId &&
																	   r.ArrivalStationId == routeDetails.ArrivalStationId);

					if (routeExists)
					{
						ModelState.AddModelError(string.Empty, "RouteDetail with these start and end stations already exists.");
						var stationsForView = await ctx.Stations.ToListAsync();
						ViewData["liststation"] = stationsForView;
						var routesForView = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
						ViewData["listroute"] = routesForView;
						return View(routeDetails);
					}

					existingRoute.DepartureStationId = routeDetails.DepartureStationId;
					existingRoute.ArrivalStationId = routeDetails.ArrivalStationId;
					existingRoute.RouteId = routeDetails.RouteId;
					existingRoute.Distance = routeDetails.Distance;
					existingRoute.TravelTime = routeDetails.TravelTime;
					existingRoute.DelayTime = routeDetails.DelayTime;
					await ctx.SaveChangesAsync();
					TempData["SuccessMessage"] = "RouteDetail Edit successfully.";
					return RedirectToAction("RouteDetailList");
				}
				else
				{
					ModelState.AddModelError("DepartureStationId", "Invalid DepartureStation selected.");
					ModelState.AddModelError("ArrivalStationId", "Invalid ArrivalStation selected.");
				}
			}

			// Xử lý khi existingRoute là null
			ModelState.AddModelError(string.Empty, "Invalid RouteDetail ID.");

			var stationsForView2 = await ctx.Stations!.ToListAsync();
			ViewData["liststation"] = stationsForView2;

			var routesForView2 = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = routesForView2;

			return View(routeDetails);
		}
		/*[HttpPost]
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
		}*/
		public async Task<IActionResult> SearchRouteDetail(string start, string end)
		{
			IQueryable<RouteDetail> query = ctx.RouteDetails.Include(r => r.ArrivalStation)
															 .Include(r => r.DepartureStation)
															 .Include(r => r.Route.StartStation)
															 .Include(r => r.Route.EndStation);

			if (!string.IsNullOrEmpty(start))
			{
				query = query.Where(r => r.DepartureStation.Name.Contains(start));
			}

			if (!string.IsNullOrEmpty(end))
			{
				query = query.Where(r => r.ArrivalStation.Name.Contains(end));
			}

			var route = await query.ToListAsync();
			return View("RouteDetailList", route);
		}
	}
}
