using System.Diagnostics;
using ContasEF.Models;
using ContasEF.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ContasEF.Controllers
{
    public class ContasController : Controller
    {
        private readonly IContasRepository contaRepository;

        public ContasController(IContasRepository contaRepository)
        {
            this.contaRepository = contaRepository;
        }

        public IActionResult Index()
        {
            return View(new ContaViewModel(contaRepository));
        }

        public IActionResult View(int id)
        {
            return View(contaRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz contaLuz)
        {
            contaRepository.Insert(contaLuz);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(contaRepository.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaLuz contaLuz)
        {
            contaRepository.Update(contaLuz);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            contaRepository.Delete(id);
            return RedirectToAction("Index");
        }

        //Testando ...
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}