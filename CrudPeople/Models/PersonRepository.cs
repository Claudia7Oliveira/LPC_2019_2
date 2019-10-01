using System.Collections.Generic;

namespace aula6CrudPeople.Models
{
    public class PersonRepository
    {
        public static List<Person> people = new List<Person>();
    
        public PersonRepository()
        {           
        }

        public void Create(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetAll()
        {
            return people;
        }
        
        public void Update(Person person)
        {
            Person newPerson = people.Find(x=>x.id == person.id);
            newPerson.name = person.name;
            newPerson.address = person.address;
        }

        public Person GetById(int id)
        {
            return people.Find(x=>x.id == id);
        }
        
        public void Delete(int id)
        {
            people.Remove(people.Find(x=>x.id == id));
        }

    }
}