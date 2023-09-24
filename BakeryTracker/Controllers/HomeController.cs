using Microsoft.AspNetCore.Mvc;

namespace BakeryTracker.Controllers
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