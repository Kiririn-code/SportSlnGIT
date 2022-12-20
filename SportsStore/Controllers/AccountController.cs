using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<IdentityUser> userManager;
		private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
			this.signInManager = signInManager;
			this.userManager = userManager;
        }

		public ViewResult Login(string returnUrl)
        {
			return View(new LoginModel
			{
				ReturnUrl = returnUrl
			});
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginModel logModel)
		{
			if (ModelState.IsValid)
			{
				IdentityUser user =
				await userManager.FindByNameAsync(logModel.Name);
				if (user != null)
				{
					await signInManager.SignOutAsync();
					if((await signInManager.PasswordSignInAsync(user, logModel.Password, false, false)).Succeeded)
                    {
						return Redirect(logModel?.ReturnUrl ?? "/Admin");
                    }
				}
			}
			ModelState.AddModelError("", "Invalid name of password");
			return View(logModel);
		}
		[Authorize]
		public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
			await signInManager.SignOutAsync();
			return Redirect(returnUrl);
        }
	}
}

