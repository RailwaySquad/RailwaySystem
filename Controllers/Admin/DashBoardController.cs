using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class DashBoardController : Controller
	{
		RailwayDbContext ctx;
		public DashBoardController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public IActionResult DashBoard()
		{
			decimal totalAmount = ctx.Transactions.Sum(t => t.Amount);

			// Đếm tổng số Id trong transactions
			int totalTransactionCount = ctx.Transactions.Count();

			// Đếm tổng số Id trong users
			int totalUserCount = ctx.Users.Count();

			// Truyền biến vào ViewBag để sử dụng trong view
			ViewBag.TotalAmount = totalAmount;
			ViewBag.TotalTransactionCount = totalTransactionCount;
			ViewBag.TotalUserCount = totalUserCount;

			return View();
		}
		[HttpPost]
		public IActionResult ShowData(string? year)
		{
			// Chuyển đổi năm từ chuỗi sang kiểu int nếu cần
			int selectedYear = int.Parse(year);

			// Lấy dữ liệu từ database dựa trêSn năm
			List<object> data = GetDataForYear(selectedYear);

			return Json(data);
		}
		private List<object> GetDataForYear(int year)
		{
			// Thực hiện truy vấn vào database để lấy dữ liệu cho năm cụ thể
			// Đảm bảo chỉ lấy dữ liệu của năm được chọn
			var groupData = ctx.Transactions!.Where(t => t.CreatedAt.Year == year)
				.GroupBy(p => new { Month = p.CreatedAt.Month })
				.Select(group => new
				{
					Month = group.Key.Month,
					Total = group.Sum(p => p.Amount)
				}).OrderBy(p => p.Month).ToList();
			List<DateTime> BookingDate = groupData.Select(p => new DateTime(year, p.Month, 1)).ToList();
			List<decimal> total = groupData.Select(p => p.Total).ToList();

			List<object> data = new List<object>();
			data.Add(BookingDate);
			data.Add(total);


			return data;
		}
	}
}
