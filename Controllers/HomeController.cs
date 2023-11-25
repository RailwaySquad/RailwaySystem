using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Diagnostics;

namespace Railway_Group01.Controllers
{
    public class HomeController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;

        public HomeController(RailwayDbContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            List<User> userList = _ctx.Users.ToList(); // get User list from context
            var id = _userManager.GetUserId(this.User); // get the current user id
            return View(await _ctx.Users!.SingleOrDefaultAsync(u => u.Id == id));
        }










        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
