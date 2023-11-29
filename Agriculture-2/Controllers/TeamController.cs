using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiyLayer.Models;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;




namespace Agriculture_2.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team t)
        {
            // UI(Agriculture-2) ve busines katmanlarına fluent validator core nuget ekle
            // teamvalidator sınıfını oluştur miras al
            //alttaki kod satırını yaz ve view kısmında düzenlemeleri yap
            //<span asp-validation-for="PersonName" class="text-danger"></span>

            TeamValidator teamValidator = new TeamValidator();
            ValidationResult validationResult = teamValidator.Validate(t);
            if (validationResult.IsValid) 
            {
                _teamService.Insert(t);
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

        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var value = _teamService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditTeam(Team t)
        {

            TeamValidator teamValidator = new TeamValidator();
            ValidationResult validationResult = teamValidator.Validate(t);
            if (validationResult.IsValid)
            {
                _teamService.Update(t);
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
