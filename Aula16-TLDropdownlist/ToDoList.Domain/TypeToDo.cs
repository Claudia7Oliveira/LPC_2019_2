using System.Collections.Generic;

namespace ToDoList.Domain
{
    public class TypeToDo
    {
        public TypeToDo(){}
        public TypeToDo(int id, string description)
        {
            this.id = id;
            this.description = description;

        }
        public int id { get; set; }
        public string description { get; set; }

        public List<ToDo> Todos { get; set; }
    }
}