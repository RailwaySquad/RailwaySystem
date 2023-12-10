using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Globalization;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class ScheduleMasterController : Controller
	{
		RailwayDbContext ctx;
		public ScheduleMasterController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> TrainSchedule()
		{

			var schedule = await ctx.Schedules!
				.Where(s=>s.Departure.Month == DateTime.Now.Month
				&& s.Departure.Year == DateTime.Now.Year)
				.Include(s=>s.Train)
				.Include(s=>s.Route.StartStation)
                .Include(s=>s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();
            
            return View(schedule);
		}
        [HttpPost]
        public async Task<IActionResult> SearchByDatetime(string date)
        {
            // Chuyển đổi string thành DateTime bằng cách thêm ngày 1
            DateTime selectedDate = DateTime.ParseExact(date + "-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            var schedule = await ctx.Schedules
                .Where(s => s.Departure.Year == selectedDate.Year && s.Departure.Month == selectedDate.Month)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();

            return View("TrainSchedule", schedule);
        }

        public async Task<IActionResult> CreateTrainSchedule()
{
            var listTrain = await ctx.Trains!.ToListAsync();
            ViewData["listTrain"] = listTrain;

            var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;

			return View();
}
		[HttpPost]
		public async Task<IActionResult> CreateTrainSchedule(ScheduleDTO scheduleDTO)
		{
			if (ModelState.IsValid)
			{
				var schedule = new Schedule()
				{
					Name = scheduleDTO.Name,
					Departure = scheduleDTO.Departure,
					Arrival = scheduleDTO.Arrival,
					IsFinished = scheduleDTO.IsFinished,
					TrainCode = scheduleDTO.TrainCode,
					RouteId = scheduleDTO.RouteId
				};
				ctx.Schedules!.Add(schedule);
				await ctx.SaveChangesAsync();
				TempData["SuccessMessage"] = "Schedule Added successfully.";
				return RedirectToAction("TrainSchedule");
			}
			var listTrain = await ctx.Trains!.ToListAsync();
			ViewData["listTrain"] = listTrain;

			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			return View(scheduleDTO);
		}
		public async Task<IActionResult> EditTrainSchedule(int id)
		{
			var listTrain = await ctx.Trains!.ToListAsync();
			List<SelectListItem> trainItems = listTrain
				.Select(t => new SelectListItem { Text = t.Code, Value = t.Code})
				.ToList();
			ViewBag.listTrain = trainItems;
			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			var schedule = await ctx.Schedules!.SingleOrDefaultAsync(s=> s.Id == id);
			return View(schedule);
		}
		[HttpPost]
		public async Task<IActionResult> EditTrainSchedule(Schedule schedule, int id)
		{
			schedule.Route = await ctx.Routes!.FindAsync(schedule.Route.Id);
			schedule.Train = await ctx.Trains!.FindAsync(schedule.Train.Code);
			ctx.Entry(schedule).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Schedule Edit successfully.";
			return RedirectToAction("TrainSchedule");
		}
		[HttpPost]
		public async Task<IActionResult> EditStatusSchedule(int id, bool isfinished)
		{
			var schedule = await ctx.Schedules!
				.Include(s=>s.Train)
				.ThenInclude(c=>c.Coaches)
				.ThenInclude(s=>s.Seats)
				.SingleOrDefaultAsync(s=>s.Id==id);
			schedule.IsFinished = isfinished;
            if (isfinished)
            {
                foreach (var coach in schedule.Train.Coaches)
                {
                    foreach (var seat in coach.Seats)
                    {
                        seat.Available = false;
                    }
                }
            }
            ctx.Entry(schedule).State= EntityState.Modified;
			await ctx.SaveChangesAsync();
			return RedirectToAction("DetailDate",schedule);
		}
		public async Task<IActionResult> DeleteTrainSchedule(int id)
		{
			var schedule = await ctx.Schedules!.SingleOrDefaultAsync(s=>s.Id==id);
			if(schedule == null)
			{
				return NotFound();
			}
			ctx.Schedules.Remove(schedule);
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Schedule Deleted successfully.";
			return RedirectToAction("TrainSchedule");
		}
		[HttpGet]
        public async Task<IActionResult> DetailDate(DateTime Departure)
        {
            var schedules = await ctx.Schedules!
                .Where(s => s.Departure.Date == Departure.Date)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
				.ToListAsync();
            return View(schedules);
        }
    }
}
