using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeGenSample.Web.Models;
using CodeGenSample.Design.Web;
using CodeGenSample.WebTier.Models;
using CodeGenSample.Web.Entity;
using CodeGenSample.Design;
using CodeGenSample.Web.Entity.Extensions;
using emFrameworkCore.Core;

namespace CodeGenSample.Web.Controllers
{
  public class HomeController : Controller
  {

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    private readonly ILogger<HomeController> _logger;

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IActionResult Index()
    {
      return View();
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IActionResult Automobile()
    {
      IEnumerable<AutomobileViewModel> xAutomobileViewModels = AutomobileWebEntity.Helper.Load(ApplicationInfo.BaseURI).ToAutomobileViewModel();

      return View(xAutomobileViewModels);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IActionResult AutomobileView(string GUIDString)
    {
      AutomobileViewModel xAutomobileViewModel = AutomobileWebEntity.Helper.Read(ApplicationInfo.BaseURI, new GUID(GUIDString)).ToAutomobileViewModel();
      xAutomobileViewModel.AutomobileParts = AutomobilePartWebEntity.Helper.Load_ByAutomobileGUID(ApplicationInfo.BaseURI, new GUID(GUIDString)).ToAutomobilePartViewModel()?.ToList();

      return View(xAutomobileViewModel);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    public IActionResult AutomobilePartView(string GUIDString)
    {
      AutomobilePartViewModel xAutomobilePartViewModel = null;

      return View(xAutomobilePartViewModel);
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    //---------------------------------------------------------------------------------------------
    //---------------------------------------------------------------------------------------------

  }
}
