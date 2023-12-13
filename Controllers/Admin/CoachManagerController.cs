using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Diagnostics;

namespace Railway_Group01.Controllers.Admin
{
    public class CoachManagerController : Controller
    {
        RailwayDbContext ctx;
        public CoachManagerController(RailwayDbContext ctx)
        {
            this.ctx = ctx;
        }
		public async Task<IActionResult> CoachList(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Coaches.CountAsync(); // Đếm tổng số mục
			var coach = await ctx.Coaches!
				.OrderByDescending(c => c.Id)
				.Include(c=>c.Class)
				.Skip((page - 1) * pageSize).Take(pageSize)
				.ToListAsync();

			ViewBag.Coaches = coach;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;
			ViewBag.counter = (page - 1) * pageSize + 1;

			return View(coach);
		}
		public async Task<IActionResult> CreateCoach()
		{
			var train = await ctx.Trains!.ToListAsync();
			ViewData["listTrain"] = train;
			var coachclass = await ctx.CoachClasses!.ToListAsync();
			ViewData["listClass"] = coachclass;
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCoach(CoachAdminDTO coachDto, Seat seat)
		{
			// Check if the combination of CoachNo and TrainCode already exists
			var existingCoach = await ctx.Coaches
				.FirstOrDefaultAsync(c =>
					c.CoachNo == coachDto.CoachNo &&
					c.TrainCode == coachDto.TrainCode);

			if (existingCoach != null)
			{
				ModelState.AddModelError("", "Coach with the same CoachNo and TrainCode already exists.");
			}
			else if (ModelState.IsValid)
			{
				var coach = new Coach()
				{
					CoachNo = coachDto.CoachNo,
					NoOfCompartments = coachDto.NoOfCompartments,
					NoOfSeats = coachDto.NoOfSeats,
					TrainCode = coachDto.TrainCode,
					ClassCode = coachDto.ClassCode
				};
				ctx.Coaches!.Add(coach);
				await ctx.SaveChangesAsync();
				var l = 1;
				var seatPerCompartment = coach.NoOfSeats / coach.NoOfCompartments;
				if (coach.NoOfCompartments != 0)
				{
					for (int i = 1; i < coach.NoOfCompartments; i++)
					{
						for (int j = 0; j < seatPerCompartment; j++)
						{
							var seats = new Seat()
							{
								CoachId = coach.Id,
								SeatNo = l++,
								Available = false,
								CompartmentNo = i,
							};
							ctx.Add(seats);
							await ctx.SaveChangesAsync();
						}
					}
				}
				else
				{
					for (int i = 1; i <= coach.NoOfSeats; i++)
					{
						var seats = new Seat()
						{
							CoachId = coach.Id,
							SeatNo = l++,
							Available = false,
							CompartmentNo = i + 1,
						};
						ctx.Add(seats);
						await ctx.SaveChangesAsync();
					}
				}

				TempData["SuccessMessage"] = "Coach Added successfully.";
				return RedirectToAction("CoachList");
			}

			var train = await ctx.Trains!.ToListAsync();
			ViewData["listTrain"] = train;
			var coachclass = await ctx.CoachClasses!.ToListAsync();
			ViewData["listClass"] = coachclass;
			return View();
		}
		public async Task<IActionResult> DeleteCoach(int id)
		{
			var coach = await ctx.Coaches!
				.Include(s=>s.Seats)
				.SingleOrDefaultAsync(c=>c.Id== id);
			ctx.Coaches.Remove(coach);
			await ctx.SaveChangesAsync();

			TempData["SuccessMessage"] = "Coach Deleted successfully.";
			return RedirectToAction("CoachList");
		}
		public async Task<IActionResult> EditCoach(int id)
		{
			var coach = await ctx.Coaches!.SingleOrDefaultAsync(c=> c.Id== id);
			var train = await ctx.Trains!.ToListAsync();
			ViewData["listTrain"] = train;
			var coachclass = await ctx.CoachClasses!.ToListAsync();
			ViewData["listClass"] = coachclass;
			return View(coach);
		}
	
		[HttpPost]
		public async Task<IActionResult> EditCoach(Coach coach)
		{
			// Check if the combination of CoachNo and TrainCode already exists for a different coach
			var existingCoach = await ctx.Coaches
				.FirstOrDefaultAsync(c =>
					c.CoachNo == coach.CoachNo &&
					c.TrainCode == coach.TrainCode &&
					c.Id != coach.Id);

			if (existingCoach != null)
			{
				ModelState.AddModelError("", "Coach with the same CoachNo and TrainCode already exists for a different coach.");
				// Reload data for dropdowns or any other necessary data
				var train = await ctx.Trains!.ToListAsync();
				ViewData["listTrain"] = train;
				var coachclass = await ctx.CoachClasses!.ToListAsync();
				ViewData["listClass"] = coachclass;
				return View(coach);
			}

			ctx.Entry(coach).State = EntityState.Modified;
			await ctx.SaveChangesAsync();

			var l = 1;
			var seatPerCompartment = coach.NoOfSeats / coach.NoOfCompartments;

			// Clear existing seats for this coach
			var existingSeats = await ctx.Seats.Where(s => s.CoachId == coach.Id).ToListAsync();
			ctx.Seats.RemoveRange(existingSeats);
			await ctx.SaveChangesAsync();

			if (coach.NoOfCompartments != 0)
			{
				for (int i = 1; i <= coach.NoOfCompartments; i++)
				{
					for (int j = 0; j < seatPerCompartment; j++)
					{
						var seat = new Seat()
						{
							CoachId = coach.Id,
							SeatNo = l++,
							Available = false,
							CompartmentNo = i,
						};
						ctx.Add(seat);
					}
				}
			}
			else
			{
				for (int i = 1; i <= coach.NoOfSeats; i++)
				{
					var seat = new Seat()
					{
						CoachId = coach.Id,
						SeatNo = l++,
						Available = false,
						CompartmentNo = i,
					};
					ctx.Add(seat);
				}
			}

			await ctx.SaveChangesAsync();

			TempData["SuccessMessage"] = "Coach Edit successfully.";
			return RedirectToAction("CoachList");
		}
		public async Task<IActionResult> SearchTrainCoach(string name)
		{
			var trainCoach = await ctx.Coaches!.Where(s => s.Train.Code.Contains(name)).ToListAsync();
			return View("CoachList", trainCoach);
		}
	}
}
