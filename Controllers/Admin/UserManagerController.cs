
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using System.Data;

namespace Railway_Group01.Controllers.Admin
{
	[Authorize(Roles = "Admin")]
	public class UserManagerController : Controller
	{
		UserManager<User> userManager;
		RailwayDbContext ctx;
		public UserManagerController(RailwayDbContext ctx, UserManager<User> userManager)
		{
			this.ctx = ctx;
			this.userManager = userManager;
		}
		public async Task<IActionResult> UserManager(int page = 1, int pageSize = 10)
		{
			var totalItemCount = await ctx.Users.CountAsync(); // Đếm tổng số mục
			var users = await ctx.Users!.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

			ViewBag.Users = users;
			ViewBag.Page = page;
			ViewBag.PageSize = pageSize;
			ViewBag.TotalItemCount = totalItemCount;

			return View(users);
		}
		public async Task<IActionResult> CreateUser()
		{

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateUser(UserDTO userDTO)
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
				


			return View(userDTO);
		}
		public async Task<IActionResult> EditUser(string id)
		{

			var user = await userManager.FindByIdAsync(id);

			if (user == null)
			{
				return NotFound();
			}

			var roles = await userManager.GetRolesAsync(user);
			var userDTO = new UserDTO
			{
				Id = user.Id,
				UserName = user.UserName,
				Email = user.Email,
				Phone = user.PhoneNumber,
				Role = roles.FirstOrDefault()
			};

			return View(userDTO);
		}
		[HttpPost]
		public async Task<IActionResult> EditUser(UserDTO userDTO)
		{
			var user = await userManager.FindByIdAsync(userDTO.Id);
			user.UserName = userDTO.UserName;
			user.Email = userDTO.Email;
			user.PhoneNumber = userDTO.Phone;

			// Cập nhật các thuộc tính khác nếu cần

			var result = await userManager.UpdateAsync(user);

			if (result.Succeeded)
			{
				// Cập nhật vai trò của người dùng
				var currentRoles = await userManager.GetRolesAsync(user);

				if (currentRoles.Any())
				{
					// Loại bỏ các vai trò hiện tại
					await userManager.RemoveFromRolesAsync(user, currentRoles);
				}

				// Thêm vai trò mới
				await userManager.AddToRoleAsync(user, userDTO.Role);

				TempData["SuccessMessage"] = "User Edit successfully.";
				return RedirectToAction("UserManager");
			}
			return View(userDTO);
		}
		[HttpPost]
		public async Task<IActionResult> DeleteUser(string id)
		{
			var user = await userManager.FindByIdAsync(id);

			if (user == null)
			{
				return NotFound();
			}

			var result = await userManager.DeleteAsync(user);

			if (result.Succeeded)
			{
				TempData["SuccessMessage"] = "User deleted successfully.";
				return RedirectToAction("UserManager");
			}

			TempData["ErrorMessage"] = "Failed to delete user.";
			return RedirectToAction("UserManager");
		}
	}
}
