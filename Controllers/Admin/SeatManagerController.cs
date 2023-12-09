using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
    public class SeatManagerController : Controller
    {
        RailwayDbContext ctx;
        public SeatManagerController(RailwayDbContext ctx)
        {
            this.ctx = ctx;
        }
		public async Task<IActionResult> SeatList(int page = 1, int pageSize = 30)
		{
			var totalItemCount = await ctx.Seats.CountAsync(); // Đếm tổng số mục
			var seat = await ctx.Seats!.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

			ViewBag.Seats = seat;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;

			return View(seat);
		}
	}
}
