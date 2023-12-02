using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
	public class TicketManagerController : Controller
	{
		RailwayDbContext ctx;
		public TicketManagerController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> TicketManager()
		{
			var ticket = await ctx.Tickets!.Include(t=>t.Schedule).Include(t=>t.Coach).Include(t=>t.Passenger).ToListAsync();
			return View(ticket);
		}
	}
}
