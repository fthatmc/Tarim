using Agriculture_2.Models;
using BusinessLayer.Abstract;
using EntitiyLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_2.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var value = _serviceService.GetListAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            //UI Katmanında ServiceAddViewModel sınıfı oluşturulup Data.Annotation
            //bu sınıfta verildi sonra aşağıdaki gibi eklendi
            //view kısmında da bu sınıf çağrıldı
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid) 
            {
                _serviceService.Insert(new Service()
                {
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description,
                });
                return RedirectToAction("Index");
            }
            return View(model);
            
        }
        public IActionResult DeleteService(int id)
        {
            var service = _serviceService.GetById(id);
            _serviceService.Delete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var service = _serviceService.GetById(id);
            return View(service);
        }
        [HttpPost]

        public IActionResult UpdateService(Service s)
        {

            _serviceService.Update(s);
            return RedirectToAction("Index");
        }

      

        public IActionResult DenemeService1()
        {
            return View();
        }
        public IActionResult DenemeService2()
        {
            var value = _serviceService.GetListAll();
            return View(value);
        }

    }
}
