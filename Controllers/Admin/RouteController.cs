using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Collections.Generic;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class RouteController : Controller
	{
		RailwayDbContext ctx;
		public RouteController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> RouteList(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Routes.CountAsync();
			var routes = await ctx.Routes!
			.OrderByDescending(r => r.Id)
			.Include(r => r.StartStation)
			.Include(r => r.EndStation)
			.Include(r => r.RouteDetails)
            .ThenInclude(rd => rd.DepartureStation) 
			.Include(r => r.RouteDetails)
            .ThenInclude(rd => rd.ArrivalStation)   
			.Skip((page - 1) * pageSize).Take(pageSize)
			.ToListAsync();
			ViewBag.Routes = routes;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;
			ViewBag.counter = (page - 1) * pageSize + 1;
			return View(routes);
        }
		public async Task<IActionResult> CreateRoute()
		{
			var list = await ctx.Stations!.ToListAsync();
			ViewData["list"] = list;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateRoute(RouteDTO routeDTO)
		{
			if (ModelState.IsValid)
			{
				// Check if a route with the same start and end stations already exists
				bool routeExists = await ctx.Routes.AnyAsync(r =>
					r.StartStationId == routeDTO.StartStationId &&
					r.EndStationId == routeDTO.EndStationId);

				if (routeExists)
				{
					ModelState.AddModelError(string.Empty, "Route with these start and end stations already exists.");
					var list = await ctx.Stations.ToListAsync();
					ViewData["list"] = list;
					return View(routeDTO);
				}

				// If the route doesn't exist, proceed with adding it to the database
				var route = new Data.Route()
				{
					StartStationId = routeDTO.StartStationId,
					EndStationId = routeDTO.EndStationId,
					Distance = routeDTO.Distance
				};
				ctx.Routes.Add(route);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Route Added successfully.";
				return RedirectToAction("RouteList");
			}

			var listForView = await ctx.Stations.ToListAsync();
			ViewData["list"] = listForView;
			return View(routeDTO);
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
			// Xóa rõ ràng các lỗi ModelState hiện tại
			ModelState.Clear();

			if (ModelState.IsValid)
			{
				// Tìm route cần sửa
				var existingRoute = await ctx.Routes
					.Where(r => r.Id == id)
					.FirstOrDefaultAsync();

				if (existingRoute != null)
				{
					// Load StartStation và EndStation từ database
					var startStation = await ctx.Stations.FindAsync(route.StartStationId);
					var endStation = await ctx.Stations.FindAsync(route.EndStationId);

					// Kiểm tra xem StartStation và EndStation có tồn tại không
					if (startStation != null && endStation != null)
					{
						// Kiểm tra xem route mới có trùng với route khác không
						bool routeExists = await ctx.Routes.AnyAsync(r => r.Id != id &&
																		   r.StartStationId == route.StartStationId &&
																		   r.EndStationId == route.EndStationId);

						if (routeExists)
						{
							ModelState.AddModelError(string.Empty, "Route with these start and end stations already exists.");
							var list = await ctx.Stations.ToListAsync();
							ViewData["list"] = list;
							return View(route);
						}

						// Cập nhật thông tin của route
						existingRoute.StartStationId = route.StartStationId;
						existingRoute.EndStationId = route.EndStationId;
						existingRoute.Distance = route.Distance;

						await ctx.SaveChangesAsync();
						TempData["SuccessMessage"] = "Route Edit successfully.";
						return RedirectToAction("RouteList");
					}
					else
					{
						// Xử lý lỗi khi StartStation hoặc EndStation không tồn tại
						ModelState.AddModelError(string.Empty, "Invalid StartStation or EndStation selected.");
					}
				}

			}

			// Lấy danh sách Stations
			var listForView = await ctx.Stations.ToListAsync();
			ViewData["list"] = listForView;
			return View(route);
		}
		/*[HttpPost]
		public async Task<IActionResult> DeleteRoute(int id)
		{
			var route = await ctx.Routes!
				.Include(r=>r.RouteDetails)
				.SingleOrDefaultAsync(r=> r.Id == id);
			if(route == null)
			{
				return NotFound();
			}
			ctx.Routes!.Remove(route);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Route Deleted successfully.";
			return RedirectToAction("RouteList");
		}*/
		public async Task<IActionResult> SearchRoute(string start, string end)
		{
			IQueryable<Data.Route> query = ctx.Routes.Include(r => r.StartStation)
			.Include(r => r.EndStation)
			.Include(r => r.RouteDetails)
			.ThenInclude(rd => rd.DepartureStation)
			.Include(r => r.RouteDetails)
			.ThenInclude(rd => rd.ArrivalStation);

			if (!string.IsNullOrEmpty(start))
			{
				query = query.Where(r => r.StartStation.Name.Contains(start));
			}

			if (!string.IsNullOrEmpty(end))
			{
				query = query.Where(r => r.EndStation.Name.Contains(end));
			}

			var route = await query.ToListAsync();
			return View("RouteList", route);
		}
	/*	public async Task<IActionResult> Detail(int id)
		{
			var route = await ctx.RouteDetails!.Where(r => r.Id == id).ToListAsync();
			return View(route);
		}*/
		
	}
}
