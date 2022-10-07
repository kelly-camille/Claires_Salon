
using Microsoft.AspNetCore.Mvc;

namespace Claires_Salon.Controllers
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