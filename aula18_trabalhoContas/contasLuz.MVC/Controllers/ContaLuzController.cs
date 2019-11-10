using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Entities;
using contasLuz.interfaces;
using contasLuz.MVC.Models;
using contasLuz.MVC.ViewsModels;

namespace contasLuz.MVC.Controllers
{
    public class ContaLuzController : Controller
    {
        private readonly IContaRepository ContaRepository;
        private readonly IImovelRepository imovelRepository;

        public ContaLuzController(IContaRepository ContaRepository, IImovelRepository imovel)
        {
            this.ContaRepository = ContaRepository;
            this.imovelRepository = imovel;
        }

        public IActionResult Index()
        {
            ViewBag.imovel= imovelRepository.GetAll();
            return View(new ContaLuzViewModel(ContaRepository));
        }

        public IActionResult View(int id)
        {
            return View(ContaRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
         //   ViewBag.Topico = new SelectList(db.Topicoes, "Id", "Nome");

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz contaLuz)
        {
            ContaRepository.Insert(contaLuz);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(ContaRepository.Get(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaLuz contaLuz)
        {
            ContaRepository.Update(contaLuz);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            ContaRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}