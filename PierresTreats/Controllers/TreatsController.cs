using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  [Authorize]
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

    [AllowAnonymous]
    [HttpGet("/treats")]
    public ActionResult Index()
    {
      ViewBag.treats = _db.Treats.ToList();
      return View();
    }

    [HttpGet("/treats/create")] public ActionResult Create() => View();

    [HttpPost("/treats/create")]
    public ActionResult Create(Treat t)
    {
      _db.Treats.Add(t);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    [HttpGet("/treats/details/{treatId}")]
    public ActionResult Details(string treatId)
    {
      Treat t = _db.Treats.FirstOrDefault(t => t.TreatId == treatId);
      return View(t);
    }

    [HttpGet("/treats/edit/{treatId}")]
    public ActionResult Edit(string treatId)
    {
      Treat t = _db.Treats.FirstOrDefault(t => t.TreatId == treatId);
      return View(t);
    }

    [HttpPost("/treats/edit/{treatId}")]
    public ActionResult Edit(Treat t)
    {
      _db.Entry(t).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
