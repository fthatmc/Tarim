using BusinessLayer.Concrete;
using DataAccesLayer.Concrete.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.Controllers
{
    public class DefaultController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
