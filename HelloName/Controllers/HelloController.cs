using Microsoft.AspNetCore.Mvc;
using HelloName.Models;
using HelloName.Controllers;

namespace HelloName.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KindaRequest() {
            return View();
        }
    }
}
