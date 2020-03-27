using Microsoft.AspNetCore.Mvc;
using BakeryTreat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace BakeryTreat.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public FlavorsController(UserManager<ApplicationUser> UserManager, BakeryTreatContext db)
    {
      _userManager = UserManager;
      _db = db;
    }
    
  }
}