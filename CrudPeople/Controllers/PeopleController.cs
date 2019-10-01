using System;
using aula6CrudPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula6CrudPeople.Controllers
{
    public class PeopleController: Controller
    {
        PersonRepository _repository = new PersonRepository();

    public IActionResult Index()
        {
            var people = _repository.GetAll();          

            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _repository.Create(person);

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var person = _repository.GetById(id);

            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            _repository.Update(person);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return RedirectToAction("Index");
        }
    
    }
}