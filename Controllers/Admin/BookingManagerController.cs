using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class BookingManagerController : Controller
	{
		RailwayDbContext ctx;
		public BookingManagerController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> BookingManager(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Bookings.CountAsync();
			var Booking = await ctx.Bookings!
				.Include(t=>t.User)
				.Skip((page - 1) * pageSize).Take(pageSize)
				.ToListAsync();
			ViewBag.Bookings = Booking;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;
			return View(Booking);
		}
		public async Task<IActionResult> BookingDetail(int id)
		{
			var Booking = await ctx.BookingDetails!
				.Where(b=>b.Booking.Id == id)
				.Include(b=>b.Seat)
				.Include(b=>b.Schedule)
				.ToListAsync();
			return View(Booking);
		}
	}
}
