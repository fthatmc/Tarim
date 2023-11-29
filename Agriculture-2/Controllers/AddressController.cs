using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiyLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditAddress(Address a)
        {

            AddressValidator addressValidator = new AddressValidator();
            ValidationResult validationResult = addressValidator.Validate(a);
            if (validationResult.IsValid)
            {
                _addressService.Update(a);
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
