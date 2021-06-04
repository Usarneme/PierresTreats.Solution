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
  public class FlavorsController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly PierresTreatsContext _db;

    public FlavorsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    [AllowAnonymous]
    [HttpGet("/flavors")]
    public ActionResult Index()
    {
      ViewBag.flavors = _db.Flavors.ToList();
      return View();
    }

    [HttpGet("/flavors/create")] public ActionResult Create() => View();

    [HttpPost("/flavors/create")]
    public ActionResult Create(Flavor f)
    {
      _db.Flavors.Add(f);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [AllowAnonymous]
    [HttpGet("/flavors/details/{flavorId}")]
    public ActionResult Details(string flavorId)
    {
      Flavor f = _db.Flavors.FirstOrDefault(f => f.FlavorId == flavorId);
      return View(f);
    }

    [HttpGet("/flavors/edit/{flavorId}")]
    public ActionResult Edit(string flavorId)
    {
      Flavor f = _db.Flavors.FirstOrDefault(f => f.FlavorId == flavorId);
      return View(f);
    }

    [HttpPost("/flavors/edit/{flavorId}")]
    public ActionResult Edit(Flavor f)
    {
      _db.Entry(f).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}
