using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntitiyLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var value = _contactService.GetListAll();
            return View(value);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {

            var value = _contactService.GetById(id);
            return View(value);
        }

       
    }
}
