﻿using Microsoft.AspNetCore.Authorization;
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
		public async Task<IActionResult> RouteList()
		{
            var routes = await ctx.Routes
        .Include(r => r.StartStation)
        .Include(r => r.EndStation)
        .Include(r => r.RouteDetails)
            .ThenInclude(rd => rd.DepartureStation) // Bao gồm DepartureStation trong RouteDetails
        .Include(r => r.RouteDetails)
            .ThenInclude(rd => rd.ArrivalStation)   // Bao gồm ArrivalStation trong RouteDetails
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
		public async Task<IActionResult> CreateRoute(RouteDTO routeDTO)
		{
			if (ModelState.IsValid)
			{
				var route = new Data.Route()
				{
					StartStationId = routeDTO.StartStationId,
					EndStationId = routeDTO.EndStationId,
					Distance = routeDTO.Distance
				};
				ctx.Routes!.Add(route);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Route Added successfully.";
				return RedirectToAction("RouteList");
			}
			var list = await ctx.Stations!.ToListAsync();
			ViewData["list"] = list;
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
	/*	public async Task<IActionResult> Detail(int id)
		{
			var route = await ctx.RouteDetails!.Where(r => r.Id == id).ToListAsync();
			return View(route);
		}*/
	}
}