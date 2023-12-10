// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Railway_Group01.Data;

namespace Railway_Group01.Areas.Identity.Pages.Account.Manage
{
    public class BookingHistoryModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly RailwayDbContext _ctx;


        [BindProperty]
        public List<Booking>? UserBookingHistory { get; set; }

        public BookingHistoryModel(
            UserManager<User> userManager,
            RailwayDbContext ctx)
        {
            _userManager = userManager;
            _ctx = ctx;
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            UserBookingHistory = await _ctx.Bookings!
                .Include(b => b.User)
                .Include(b => b.Transactions)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Schedule)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger).ThenInclude(p => p!.PassengerType)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach).ThenInclude(c => c!.Class)
                .Where(b => b.User == user).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _ctx.Bookings!
                .Include(b=>b.Transactions)
                .FirstOrDefaultAsync(b=>b.Id == id);

            if (booking == null)
            {
                return NotFound();
            }

            if (booking.Transactions!.Count > 0)
            {
                ModelState.AddModelError(string.Empty, "Attempting to delete already payed order failed!");
                return Page();
            }

            _ctx.Bookings!.Remove(booking);
            await _ctx.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
