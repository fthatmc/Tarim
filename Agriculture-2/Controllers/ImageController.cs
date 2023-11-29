using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiyLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.Controllers
{
    public class ImageController : Controller
    {
        private readonly IimageService _imageService;

        public ImageController(IimageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var value = _imageService.GetListAll();
            return View(value);
        }
        public IActionResult DeleteImage(int id)
        {
            var value = _imageService.GetById(id);
            _imageService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image img)
        {

            // UI(Agriculture-2) ve busines katmanlarına fluent validator core nuget ekle
            // teamvalidator sınıfını oluştur miras al
            //alttaki kod satırını yaz ve view kısmında düzenlemeleri yap
            //<span asp-validation-for="PersonName" class="text-danger"></span>

            ImageValidator imageValidator = new ImageValidator();
            ValidationResult validationResult = imageValidator.Validate(img);
            if (validationResult.IsValid)
            {
                _imageService.Insert(img);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var value = _imageService.GetById(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult EditImage(Image img)
        {
            ImageValidator imageValidator = new ImageValidator();
            ValidationResult validationResult = imageValidator.Validate(img);
            if (validationResult.IsValid)
            {
                _imageService.Update(img);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
