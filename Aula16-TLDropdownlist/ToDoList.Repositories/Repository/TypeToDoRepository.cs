using System.Collections.Generic;
using System.Linq;
using ToDoList.Domain;
using ToDoList.Repositories.Data;
using ToDoList.Repositories.Interface;

namespace ToDoList.Repositories.Repository
{
    public class TypeToDoRepository : ITypeToDoRepository
    {
 private DataContext context;
 
        public TypeToDoRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(TypeToDo type)
        {
            context.TypeTodos.Add(type);
            context.SaveChanges();
        }


        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TypeToDo> GetAll()
        {
            return context.TypeTodos.ToList();
        }

        public TypeToDo GetById(int id)
        {
            return context.TypeTodos.SingleOrDefault(x=>x.id==id);
        }

        public void Update(TypeToDo typeToDo)
        {
            throw new System.NotImplementedException();
        }
    }
}