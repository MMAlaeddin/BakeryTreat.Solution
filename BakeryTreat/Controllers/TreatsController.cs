using Microsoft.AspNetCore.Mvc;
using BakeryTreat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BakeryTreat.Controllers
{
  public class TreatsController : Controller
  {
    private readonly BakeryTreatContext _db; 

    public TreatsController(BakeryTreatContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}