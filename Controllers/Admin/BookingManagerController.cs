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
		public async Task<IActionResult> BookingManager()
		{
			var Booking = await ctx.Bookings!.Include(t=>t.User).ToListAsync();
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
