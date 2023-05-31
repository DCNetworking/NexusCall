using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using nexus_connect.Data;
using nexus_connect.Models;
using nexus_connect.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using nexus_connect.Data.Entities;

namespace nexus_connect.Controllers;

public class HomeController : Controller
{
    readonly IMapper _mapper;
    readonly UserManager<StoreUser> _userManager;
    readonly ILogger<HomeController> _logger;
    readonly INexusConnectRepository _repository;
    public HomeController(ILogger<HomeController> logger, INexusConnectRepository repository, IMapper mapper, UserManager<StoreUser> userManager)
    {
        _userManager = userManager;
        _mapper = mapper;
        _logger = logger;
        _repository = repository;
    }
    public async Task<IActionResult> Index()
    {
        if (!this.User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Login", "Access");
        }
        var user = await _userManager.FindByNameAsync(userName: User.Identity.Name);
        var userId = await _userManager.GetUserIdAsync(user);
        var clientsAsync = await _repository.GetUserClientsView(userId);
        var results = _mapper.Map<IEnumerable<UserClientViewModel>>(clientsAsync);
        return View(results);
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
