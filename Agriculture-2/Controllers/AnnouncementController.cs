using BusinessLayer.Abstract;
using EntitiyLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Agriculture_2.Controllers
{
    public class AnnouncementController : Controller
    {

        private readonly IAnnouncemenetService _AnnouncemenetService;

        public AnnouncementController(IAnnouncemenetService announcemenetService)
        {
            _AnnouncemenetService = announcemenetService;
        }

        public IActionResult Index()
        {
            var value = _AnnouncemenetService.GetListAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcemenet a)
        {
            a.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            a.Status = false;
            _AnnouncemenetService.Insert(a);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _AnnouncemenetService.GetById(id);
            _AnnouncemenetService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var value = _AnnouncemenetService.GetById(id);
            return View(value);
        }
        [HttpPost]

        public IActionResult EditAnnouncement(Announcemenet a)
        {

            _AnnouncemenetService.Update(a);
            return RedirectToAction("Index");
        }

        public IActionResult ChangesStatusToTrue(int  id)
        {
            _AnnouncemenetService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
            //index de pasif yap /Announcement/ChangesStatusToTrue/
        }
        public IActionResult ChangesStatusToFalse(int id)
        {
            _AnnouncemenetService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
            //index de pasif yap /Announcement/ChangesStatusToFalse/
        }
    }
}
