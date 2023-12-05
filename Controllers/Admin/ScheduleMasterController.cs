using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
	public class ScheduleMasterController : Controller
	{
		RailwayDbContext ctx;
		public ScheduleMasterController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> Index()
		{
			return View();
		}
		public async Task<IActionResult> TrainSchedule()
		{
			var schedule = await ctx.Schedules!
				.Include(s=>s.Train)
				.Include(s=>s.Route.StartStation)
                .Include(s=>s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();
			return View(schedule);
		}
		[HttpPost]
        public async Task<IActionResult> SearchByMonth(int month)
        {
            var schedules = await ctx.Schedules
                .Where(s => s.Departure.Value.Month == month)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();

            return View("TrainSchedule", schedules);
        }
		[HttpPost]
        public async Task<IActionResult> SearchByYear(int year)
        {
            var schedules = await ctx.Schedules
                .Where(s => s.Departure.Value.Year == year)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();

            return View("TrainSchedule", schedules);
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
		public async Task<IActionResult> CreateTrainSchedule(Schedule schedule)
		{

				schedule.Route = await ctx.Routes!.FindAsync(schedule.Route.Id);
				schedule.Train = await ctx.Trains!.FindAsync(schedule.Train);
				ctx.Schedules!.Add(schedule);
				await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "Schedule Added successfully.";
			return RedirectToAction("TrainSchedule");

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
                .Where(s => s.Departure.HasValue && s.Departure.Value.Date == Departure.Date)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
                .ToListAsync();

            return View(schedules);
        }
    }
}
