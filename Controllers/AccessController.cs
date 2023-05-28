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
    public AccessController(ILogger<AccessController> logger, SignInManager<StoreUser> signInManager)
    {
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
}