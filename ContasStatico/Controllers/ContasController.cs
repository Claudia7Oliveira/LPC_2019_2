using ContasStatico.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContasStatico.Controllers
{
    /*acho que é isso */
    public class ContasController : Controller
    {
        ContasRepository _repository = new ContasRepository();
        public IActionResult Index()
        {
            var contas = _repository.GetAll();
            return View(contas);
        }
        
        public IActionResult Create()
        {            
            return View();
        }

        public RedirectToActionResult Create(Conta contas)
        {            
            _repository.Create(contas);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {   
            return View(_repository.GetById(id));
        }

    
        public RedirectToActionResult Update(Conta conta)
        {            
            _repository.Update(conta);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {   
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}