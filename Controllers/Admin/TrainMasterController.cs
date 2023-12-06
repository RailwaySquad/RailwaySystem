using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class TrainMasterController : Controller
	{
		RailwayDbContext ctx;
		public TrainMasterController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> TrainMaster()
		{
			var train = await ctx.Trains!.ToListAsync();
			return View(train);
		}
		public async Task<IActionResult> CreateTrain()
		{
			var listType = await ctx.TrainTypes!.ToListAsync();
			ViewData["listType"] = listType;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateTrain(TrainDTO trainDTO)
		{
			if (ModelState.IsValid)
			{
				var train = new Train()
				{
					Code = trainDTO.Code,
					TypeCode = trainDTO.TypeCode,
					IsRunning = trainDTO.IsRunning
				};
				ctx.Trains!.Add(train);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Train Added successfully.";
				return RedirectToAction("TrainMaster");
			}
			var listType = await ctx.TrainTypes!.ToListAsync();
			ViewData["listType"] = listType;
			return View(trainDTO);
		}
		public async Task<IActionResult> EditTrain(string id)
		{
			var train = await ctx.Trains!.SingleOrDefaultAsync(t => t.Code == id);
			var listType = await ctx.TrainTypes!.ToListAsync();
			ViewData["listType"] = listType;
			return View(train);
		}
		[HttpPost]
		public async Task<IActionResult> EditTrain(Train train, string id)
		{
			ctx.Entry(train).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Train Edit successfully.";
			return RedirectToAction("TrainMaster");
		}
		[HttpPost]
		public async Task<IActionResult> DeleteTrain(string id)
		{
			var train = await ctx.Trains!.SingleOrDefaultAsync(s => s.Code == id);
			if (train == null)
			{
				return NotFound();
			}
			ctx.Trains!.Remove(train);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Train Deleted successfully.";
			return RedirectToAction("TrainMaster");
		}
	}
}
