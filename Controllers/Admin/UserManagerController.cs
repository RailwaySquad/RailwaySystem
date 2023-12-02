
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;

namespace Railway_Group01.Controllers.Admin
{
	public class UserManagerController : Controller
	{
		UserManager<User> userManager;
		RailwayDbContext ctx;
		public UserManagerController(RailwayDbContext ctx, UserManager<User> userManager)
		{
			this.ctx = ctx;
			this.userManager = userManager;
		}
		public async Task<IActionResult> UserManager()
		{
			var user = await ctx.Users!.ToListAsync();
			return View(user);
		}
		public async Task<IActionResult> CreateUser()
		{

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateUser(UserDTO userDTO)
		{
			if (ModelState.IsValid)
			{
				var user = new User()
				{
					UserName = userDTO.UserName,
					Email = userDTO.Email,
					PhoneNumber = userDTO.Phone

				};
				

				var result = await userManager.CreateAsync(user, userDTO.Password);
				user = await ctx.Users.SingleOrDefaultAsync(u => u.UserName == userDTO.UserName);
				await userManager.AddToRoleAsync(user!, userDTO.Role);

				if (result.Succeeded)
				{
			/*		ctx.Users.Add(user);
					await ctx.SaveChangesAsync();*/
					TempData["SuccessMessage"] = "User Added successfully.";
					return RedirectToAction("UserManager");
				}
				
			}

			return View(userDTO);
		}
		public async Task<IActionResult> EditUser(string id)
		{
			var user = await ctx.Users!.SingleOrDefaultAsync(x => x.Id == id);
			return View(user);
		}
		[HttpPost]
		public async Task<IActionResult> EditUser(User user,string id)
		{
			ctx.Entry(user).State = EntityState.Modified;
			await ctx.SaveChangesAsync();
			TempData["SuccessMessage"] = "User Edit successfully.";
			return RedirectToAction("UserManager");
		}
	}
}
