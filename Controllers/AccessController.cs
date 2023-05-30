using System.Data.Common;
using System.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Controllers;


public class AccessController : Controller
{
    private readonly ILogger<AccessController> _logger;
    readonly SignInManager<StoreUser> _signInManager;
    readonly UserManager<StoreUser> _userManager;
    public AccessController(ILogger<AccessController> logger, SignInManager<StoreUser> signInManager, UserManager<StoreUser> userManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _logger = logger;
    }
    public IActionResult Login()
    {
        if (this.User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }
    public IActionResult Signup()
    {
        if (this.User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    public async Task<IActionResult> Logout()
    {
        if (this.User.Identity.IsAuthenticated)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Access");
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                if (Request.Query.Keys.Contains("ReturnUrl"))
                {
                    return Redirect(Request.Query["ReturnUrl"].First());
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        ModelState.AddModelError("", "Failed to login");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Signup(SignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            var NewUser = new StoreUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Username,
                UserName = model.Username,
                Permission = Data.PermissionType.Operator,
                Status = Data.StatusType.Active
            };
            if (await _userManager.FindByNameAsync(NewUser.UserName) != null)
            {
                ViewBag.ErrorMessage = $"User {model.Username} Already Exists";
                return View(model);
            }
            var result = await _userManager.CreateAsync(NewUser, model.Password);
            if (result.Succeeded)
            {
                if (Request.Query.Keys.Contains("ReturnUrl"))
                {
                    return Redirect(Request.Query["ReturnUrl"].First());
                }
                else
                {
                    return RedirectToAction("Login", "Access");
                }
            }
        }
        ModelState.AddModelError("", "Failed to signup");
        return View();
    }
}