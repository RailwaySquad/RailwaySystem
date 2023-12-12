using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class TransactionManagerController : Controller
	{
		RailwayDbContext ctx;
		public TransactionManagerController(RailwayDbContext ctx)
		{
			this.ctx = ctx;
		}
		public async Task<IActionResult> TransactionManager(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Transactions.CountAsync();
			var transaction = await ctx.Transactions!
				.OrderByDescending(t => t.Id)
				.Include(t=>t.Booking)
				.Include(t=>t.Cancelling)
				.Skip((page - 1) * pageSize).Take(pageSize)
				.ToListAsync();
			ViewBag.transactions = transaction;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;
			ViewBag.counter = (page - 1) * pageSize + 1;
			return View(transaction);
		}

	}
}
