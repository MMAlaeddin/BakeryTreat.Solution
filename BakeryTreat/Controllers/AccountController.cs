using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BakeryTreat.Models;
using System.Threading.Tasks;
using BakeryTreat.ViewModels;

namespace BakeryTreat.Controllers
{
  public class AccountController : Controllers{
    private readonly BakeryTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ToDoListContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

  }
}