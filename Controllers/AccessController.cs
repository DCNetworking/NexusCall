using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;
using nexus_connect.Data.DefaultSettings;
using AutoMapper;

namespace nexus_connect.Controllers;


public class AccessController : Controller
{
    private readonly ILogger<AccessController> _logger;
    private readonly ISession _session;
    readonly IMapper _mapper;
    readonly IHttpContextAccessor _httpContextAccessor;
    readonly SignInManager<StoreUser> _signInManager;
    readonly UserManager<StoreUser> _userManager;
    public AccessController(ILogger<AccessController> logger, SignInManager<StoreUser> signInManager, UserManager<StoreUser> userManager, IHttpContextAccessor httpContextAccessor, IMapper mapper)
    {
        _mapper = mapper;
        _session = httpContextAccessor.HttpContext.Session;
        _userManager = userManager;
        _signInManager = signInManager;
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
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
                _httpContextAccessor.HttpContext.Session.SetString("SessionExpiresAt", DateTime.UtcNow.Add(TimeSpan.FromSeconds(10)).ToString("O"));
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
            StoreUser? NewUser = _mapper.Map<StoreUser>(model);
            UserDefaults? Defaults = new UserDefaults();
            NewUser.Status = Defaults.DefaultStatus;
            NewUser.Permission = Defaults.DefaultPermission;
            NewUser.TeamId = Defaults.DefaultTeam;
            if (await _userManager.FindByNameAsync(NewUser.UserName) != null)
            {
                ViewBag.ErrorMessage = $"User {model.Username} Already Exists";
                return View(model);
            }
            var result = await _userManager.CreateAsync(NewUser, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
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
        ModelState.AddModelError("", "Failed to signup");
        return View();
    }
}