using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly PierresTreatsContext _db;
    public TreatsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    [HttpGet("/treats")]
    public ActionResult Index()
    {
      ViewBag.treats = _db.Treats.ToList();
      return View();
    }

  }
}
