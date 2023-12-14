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
            TempData["CurrentMonthFirstDay"] = selectedDate.ToString("yyyy-MM-dd");
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
            // Kiểm tra Departure không được nhỏ hơn thời gian hiện tại
            if (scheduleDTO.Departure < DateTime.Now)
            {
                ModelState.AddModelError("Departure", "Departure time cannot be in the past.");
            }

            // Kiểm tra Arrival không được nhỏ hơn Departure
            if (scheduleDTO.Arrival <= scheduleDTO.Departure)
            {
                ModelState.AddModelError("Arrival", "Arrival time must be after Departure time.");
            }

            // Kiểm tra sự trùng lặp của Departure và TrainCode
            DateTime startOfDay = TimeZoneInfo.ConvertTimeToUtc(scheduleDTO.Departure.Date, TimeZoneInfo.Utc);
            DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);

            var existingSchedule = await ctx.Schedules
                .FirstOrDefaultAsync(s =>
                    s.Departure >= startOfDay && s.Departure <= endOfDay && s.TrainCode == scheduleDTO.TrainCode);
             
            if (existingSchedule != null)
            {
                ModelState.AddModelError("", "Schedule with the same Departure and TrainCode already exists.");
            }

            // Kiểm tra Departure phải lớn hơn Arrival trong schedule gần nhất của tàu đó
            var latestArrival = await ctx.Schedules
                .Where(s => s.TrainCode == scheduleDTO.TrainCode && s.Departure < scheduleDTO.Departure)
                .OrderByDescending(s => s.Departure)
                .Select(s => s.Arrival)
                .FirstOrDefaultAsync();

            if ( scheduleDTO.Departure <= latestArrival)
            {
                ModelState.AddModelError("Departure", $"Departure must be after the latest Arrival time ({latestArrival}).");
            }

            // Kiểm tra ModelState có lỗi không
            if (!ModelState.IsValid)
            {
                // Nếu có lỗi, trả về view với model và ModelState chứa thông tin lỗi
                var listTrain = await ctx.Trains!.ToListAsync();
                ViewData["listTrain"] = listTrain;

                var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
                ViewData["listroute"] = listRoute;

                return View(scheduleDTO);
            }

            // Nếu không có lỗi, tiếp tục tạo schedule
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
            return RedirectToAction("DetailDate", schedule);
        }
        public async Task<IActionResult> EditTrainSchedule(int id)
		{
			var listTrain = await ctx.Trains!.ToListAsync();
			ViewData["listTrain"] = listTrain;
			var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
			ViewData["listroute"] = listRoute;
			var schedule = await ctx.Schedules!.SingleOrDefaultAsync(s=> s.Id == id);
			return View(schedule);
		}
		[HttpPost]
		public async Task<IActionResult> EditTrainSchedule(Schedule schedule, int id)
        {
            ModelState.Clear();

            // Kiểm tra Departure không được nhỏ hơn thời gian hiện tại
            if (schedule.Departure < DateTime.Now)
            {
                ModelState.AddModelError("Departure", "Departure time cannot be in the past.");
            }

            // Kiểm tra Arrival không được nhỏ hơn Departure
            if (schedule.Arrival <= schedule.Departure)
            {
                ModelState.AddModelError("Arrival", "Arrival time must be after Departure time.");
            }

            // Kiểm tra sự trùng lặp của Departure và TrainCode
            DateTime startOfDay = TimeZoneInfo.ConvertTimeToUtc(schedule.Departure.Date, TimeZoneInfo.Utc);
            DateTime endOfDay = startOfDay.AddDays(1).AddTicks(-1);

            var existingSchedule = await ctx.Schedules
                .FirstOrDefaultAsync(s =>
                    s.Departure >= startOfDay && s.Departure <= endOfDay && s.TrainCode == schedule.TrainCode && s.Id != id);

            if (existingSchedule != null)
            {
                ModelState.AddModelError("", "Schedule with the same Departure and TrainCode already exists.");
            }

            // Kiểm tra Departure phải lớn hơn Arrival trong schedule gần nhất của tàu đó
            var latestArrival = await ctx.Schedules
                .Where(s => s.Id != id && s.TrainCode == schedule.TrainCode && s.Departure < schedule.Departure )
                .OrderByDescending(s => s.Departure)
                .Select(s => s.Arrival)
                .FirstOrDefaultAsync();

            if ( schedule.Departure <= latestArrival)
            {
                ModelState.AddModelError("Departure", $"Departure must be after the latest Arrival time ({latestArrival}).");
            }

            // Kiểm tra ModelState có lỗi không
            if (!ModelState.IsValid)
            {
                // Nếu có lỗi, trả về view với model và ModelState chứa thông tin lỗi
                var listTrain = await ctx.Trains!.ToListAsync();
                ViewData["listTrain"] = listTrain;

                var listRoute = await ctx.Routes!.Include(r => r.StartStation).Include(r => r.EndStation).ToListAsync();
                ViewData["listroute"] = listRoute;

                return View(schedule);
            }

            // Nếu không có lỗi, tiếp tục chỉnh sửa schedule
            if (ModelState.IsValid)
            {
                schedule.Route = await ctx.Routes!.FindAsync(schedule.RouteId);
                schedule.Train = await ctx.Trains!.FindAsync(schedule.TrainCode);
                ctx.Entry(schedule).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
                TempData["SuccessMessage"] = "Schedule Edit successfully.";
                return RedirectToAction("DetailDate", schedule);
            }

            return View(schedule);
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
		/*public async Task<IActionResult> DeleteTrainSchedule(int id)
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
		}*/
		[HttpGet]
        public async Task<IActionResult> DetailDate(DateTime Departure)
        {
            var schedules = await ctx.Schedules!
                .OrderByDescending(r => r.Id)
                .Where(s => s.Departure.Date == Departure.Date)
                .Include(s => s.Train)
                .Include(s => s.Route.StartStation)
                .Include(s => s.Route.EndStation)
				.ToListAsync();
            return View(schedules);
        }
		public IActionResult test()
		{
			return View();
		}
    }
}
