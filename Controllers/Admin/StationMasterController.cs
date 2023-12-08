using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

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
			var totalItemCount = await ctx.Stations.CountAsync(); // Đếm tổng số mục
			var stations = await ctx.Stations!.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

			ViewBag.Stations = stations;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;

			return View(stations);
		}
		public IActionResult CreateStation()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateStation(Station station)
		{
			if(ModelState.IsValid)
			{
				ctx.Stations!.Add(station);
				await ctx.SaveChangesAsync();
                TempData["SuccessMessage"] = "Station added successfully.";
                return RedirectToAction("StationMaster");
			}
			return View();
		}

		public async Task<IActionResult> EditStation(int id)
		{
			var station = await ctx.Stations!.SingleOrDefaultAsync(s => s.Id == id);
			return View(station);
		}
		[HttpPost]
		public async Task<IActionResult> EditStation(Station station, int id)
		{
			ctx.Entry(station).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
            TempData["SuccessMessage"] = "Station Edit successfully.";
            return RedirectToAction("StationMaster");
		}
		[HttpPost]
		public async Task<IActionResult> DeleteStation(int id)
		{
			var station = await ctx.Stations!.SingleOrDefaultAsync(s=> s.Id == id);
			if(station == null)
			{
				return NotFound();
			}
			ctx.Stations!.Remove(station);
			await ctx.SaveChangesAsync();
            TempData["SuccessMessage"] = "Station Delete successfully.";
            return RedirectToAction("StationMaster");
		}

		public async Task<IActionResult> StationDetail(int id)
		{
			
			return View();
		}
	}
}
