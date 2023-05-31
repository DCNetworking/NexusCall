using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Controllers
{

    public class GlobalController : Controller
    {
        private readonly ILogger<GlobalController> _logger;
        readonly UserManager<StoreUser> _userManager;
        readonly IMapper _mapper;
        public GlobalController(ILogger<GlobalController> logger, UserManager<StoreUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IActionResult> MyAccount(MyAccountViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            return View(_mapper.Map<MyAccountViewModel>(user));
        }
        public IActionResult Notifications()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}