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
        public async Task<IActionResult> TrainSchedule(string date = null)
        {
            string selectedMonth;

            // Nếu date được cung cấp, sử dụng giá trị mới
            if (!string.IsNullOrEmpty(date))
            {
                selectedMonth = date;
                // Lưu giá trị mới vào ViewBag để sử dụng cho lần gọi sau
                ViewBag.SelectedMonth = selectedMonth;
            }
            else if (!string.IsNullOrEmpty(ViewBag.SelectedMonth))
            {
                selectedMonth = ViewBag.SelectedMonth;
            }
            else
            {
                // Sử dụng giá trị mặc định là tháng và năm hiện tại
                selectedMonth = DateTime.Now.ToString("yyyy-MM");
            }

            var schedule = await ctx.Schedules!
                .Where(s => s.Departure.Month == DateTime.Now.Month
                    && s.Departure.Year == DateTime.Now.Year)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
                .OrderBy(s => s.Departure)
                .ToListAsync();

            // Truyền giá trị selectedMonth đến view
            ViewBag.SelectedMonth = selectedMonth;

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

            // Lưu giá trị date vào ViewBag để sử dụng trong lần gọi sau của hàm TrainSchedule
            ViewBag.SelectedMonth = date;

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
            // Kiểm tra xem TrainCode đã có lịch trình trong ngày hôm đó chưa
            var existingSchedule = await ctx.Schedules
                .FirstOrDefaultAsync(s => s.TrainCode == scheduleDTO.TrainCode
                    && s.Departure.Date == scheduleDTO.Departure.Date);

            if (existingSchedule != null)
            {
                // Nếu đã có lịch trình, gán giá trị thông báo lỗi cho biến errorMessage
                ViewBag.ErrorMessage = $"Train {scheduleDTO.TrainCode} has a schedule for the day {scheduleDTO.Departure.Date}";
            }

            // Kiểm tra Departure không được nhỏ hơn thời gian hiện tại
            if (scheduleDTO.Departure <= DateTime.Now)
            {
                ModelState.AddModelError("Departure", "Departure time must not be earlier than the current time.");
            }

            // Kiểm tra Arrival không được nhỏ hơn Departure
            if (scheduleDTO.Arrival < scheduleDTO.Departure)
            {
                ModelState.AddModelError("Arrival", "Arrival time must not be earlier than Departure time.");
            }

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

                ctx.Schedules.Add(schedule);
                await ctx.SaveChangesAsync();
                TempData["SuccessMessage"] = "Schedule Added successfully.";
                return RedirectToAction("TrainSchedule");
            }

            // Nếu có lỗi, load lại danh sách Train và Route
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

				.SingleOrDefaultAsync(s=>s.Id==id);
			schedule.IsFinished = isfinished;

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
