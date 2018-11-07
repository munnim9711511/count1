using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coouncil.Models;
using Microsoft.AspNetCore.Identity;

namespace Coun.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _siginManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AccountController(SignInManager<IdentityUser> _siginManager,UserManager<IdentityUser> _userManager)
        {
            this._userManager = _userManager;
            this._siginManager = _siginManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserModel user)
        {
            var result = await _siginManager.PasswordSignInAsync(user.UserName,user.Password,user.RememberMe,false);
            if(!result.Succeeded){
                  return RedirectToAction("Login","Account");
            }

            return RedirectToAction("Index","Admin");
        }




    }
}
