using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nexus_connect.Data;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Controllers
{

    public class GlobalController : Controller
    {
        private readonly ILogger<GlobalController> _logger;
        readonly UserManager<StoreUser> _userManager;
        readonly IMapper _mapper;
        readonly INexusConnectRepository _repository;
        public GlobalController(ILogger<GlobalController> logger, UserManager<StoreUser> userManager, IMapper mapper, INexusConnectRepository repository)
        {
            _repository = repository;
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IActionResult> MyAccount(MyAccountViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            return PartialView("MyAccount", _mapper.Map<MyAccountViewModel>(user));
        }
        public async Task<IActionResult> Notifications(NotificationViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            var notifiactions = await _repository.GetNotifcations(user.Id);
            return PartialView("Notifications", notifiactions);
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}