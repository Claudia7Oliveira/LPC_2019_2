using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;
using ToDoList.Repositories.Data;
using ToDoList.Repositories.Interface;

namespace ToDoList.Repositories.Repository
{
    public class ToDoRepository : IToDoRepository
    {
         private DataContext context;
        public ToDoRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(ToDo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }


        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ToDo> GetAll()
        {
            return context.Todos.Include(x=>x.typeToDo).ToList();
        }

        public ToDo GetById(int id)
        {
            return context.Todos.Include(x=>x.typeToDo).SingleOrDefault(x=>x.id==id);
        }

        public void Update(ToDo person)
        {
            throw new System.NotImplementedException();
        }
    }
}