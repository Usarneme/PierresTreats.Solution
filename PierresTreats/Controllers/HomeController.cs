using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly PierresTreatsContext _db;

    public HomeController(PierresTreatsContext db, ILogger<HomeController> logger)
    {
      _db = db;
      _logger = logger;
    }

    public IActionResult Index()
    {
      ViewBag.treats = _db.Treats.ToList();
      ViewBag.flavors = _db.Flavors.ToList();
      return View();
    }

  }
}
