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
		public async Task<IActionResult> CoachList(int page = 1, int pageSize = 30)
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
		public async Task<IActionResult> CreateCoach(CoachDto coachDto,Seat seat)
		{
			if (ModelState.IsValid)
			{
				var coach = new Coach()
				{
					CoachNo = coachDto.CoachNo,
					NoOfCompartments = coachDto.NoOfCompartment,
					NoOfSeats = coachDto.NoOfSeat,
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
			ctx.Entry(coach).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Coach Edit successfully.";
			return RedirectToAction("CoachList");
		}
		public async Task<IActionResult> SearchTrainCoach(string name)
		{
			var trainCoach = await ctx.Coaches!.Where(s => s.Train.Code.Contains(name)).ToListAsync();
			return View("TrainMaster", trainCoach);
		}
	}
}
