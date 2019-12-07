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

namespace CodeGenSample.Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Automobile()
    {
      List<AutomobileViewModel> xAutomobileViewModels = new List<AutomobileViewModel>();
      foreach (AutomobileWebEntity xAutomobileWebEntity in AutomobileWebEntity.Helper.Load(ApplicationInfo.BaseURI, null))
      {
        xAutomobileViewModels.Add(new AutomobileViewModel()
        {
          AutomobileGUID = xAutomobileWebEntity.AutomobileGUID,
          AutomobileMake = xAutomobileWebEntity.AutomobileMake,
          AutomobileModel = xAutomobileWebEntity.AutomobileModel,
          AutomobileYear = xAutomobileWebEntity.AutomobileYear
        });
      }
      xAutomobileViewModels.Add(new AutomobileViewModel()
      {
        AutomobileGUID = new emFrameworkCore.Core.GUID(),
        AutomobileMake = "Ford",
        AutomobileModel = "F150",
        AutomobileYear = 2014
      });
      xAutomobileViewModels.Add(new AutomobileViewModel()
      {
        AutomobileGUID = new emFrameworkCore.Core.GUID(),
        AutomobileMake = "Ford",
        AutomobileModel = "F250",
        AutomobileYear = 2001
      });
      return View(xAutomobileViewModels);
    }

    public IActionResult AutomobileView(string GUIDString)
    {
      AutomobileViewModel xAutomobileViewModel = new AutomobileViewModel()
      {
        AutomobileGUID = new emFrameworkCore.Core.GUID(GUIDString),
        AutomobileMake = "Ford",
        AutomobileModel = "F350",
        AutomobileYear = 2020,
        AutomobileParts = new List<AutomobilePartViewModel>()
      };
      xAutomobileViewModel.AutomobileParts.Add(new AutomobilePartViewModel()
      {
        AutomobilePartGUID = new emFrameworkCore.Core.GUID(),
        AutomobileGUID = xAutomobileViewModel.AutomobileGUID,
        AutomobilePartNumber = "",
        AutomobilePartName = "",
        AutomobilePartPrice = 0m,
        AutomobilePartDescription = ""
      });
      xAutomobileViewModel.AutomobileParts.Add(new AutomobilePartViewModel()
      {
        AutomobilePartGUID = new emFrameworkCore.Core.GUID(),
        AutomobileGUID = xAutomobileViewModel.AutomobileGUID,
        AutomobilePartNumber = "",
        AutomobilePartName = "",
        AutomobilePartPrice = 0m,
        AutomobilePartDescription = ""
      });

      return View(xAutomobileViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
