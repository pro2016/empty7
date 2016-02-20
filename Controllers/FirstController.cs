
//namespace empty7.Controllers

using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}