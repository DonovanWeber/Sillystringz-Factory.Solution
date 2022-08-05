using Microsoft.AspNetCore.Mvc;
using SillystringzFactory.Models;

namespace SillystringzFactory.Controllers
{
  public class HomeController : Controller 
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}