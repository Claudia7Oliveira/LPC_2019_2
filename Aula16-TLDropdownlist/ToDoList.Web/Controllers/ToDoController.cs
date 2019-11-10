
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories.Interface;

namespace ToDoList.Web.Controllers
{
    public class ToDoController : Controller
    {
        private IToDoRepository repositoryToDo;
        private ITypeToDoRepository repositoryType;
        public ToDoController(IToDoRepository repositoryToDo,
        ITypeToDoRepository repositoryType)
        {
            this.repositoryToDo = repositoryToDo;
            this.repositoryType = repositoryType;
        }

        public IActionResult Index()
        {
            var todos = repositoryToDo.GetAll();
            
            return View(todos);
        }

        public IActionResult Create()
        {
            ViewBag.TypesToDos = repositoryType.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo todo)
        {
            todo.typeToDo = repositoryType.GetById(todo.typeToDo.id);
            repositoryToDo.Create(todo);
            return RedirectToAction("Index");
        }

     
    }
}
