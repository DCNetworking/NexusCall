using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using nexus_connect.Data;
using nexus_connect.Models;
using nexus_connect.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace nexus_connect.Controllers;

public class HomeController : Controller
{
    readonly IMapper _mapper;
    readonly ILogger<HomeController> _logger;
    readonly INexusConnectRepository _repository;
    public HomeController(ILogger<HomeController> logger, INexusConnectRepository repository, IMapper mapper)
    {
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
        var clientsAsync = await _repository.GetAllClientsAsync();
        var results = _mapper.Map<IEnumerable<ClientViewModel>>(clientsAsync);
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
