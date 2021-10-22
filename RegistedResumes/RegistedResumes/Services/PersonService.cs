using Microsoft.EntityFrameworkCore;
using RegistedResumes.Data;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RegistedResumes.Services
{
    public class PersonService
    {
        private readonly RegistedResumesContext _context;

       public PersonService(RegistedResumesContext contexto)
        {
            _context = contexto;
        }

        public List<Person> FindAll()
        {
            return _context.Person.Include(obj => obj.Department).ToList();
        }

        public void Insert(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }

        public Person FindById(int id)
        {
            return _context.Person.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);

        }
        public void UpdatePerson( Person person)
        {
            bool hasAny = _context.Person.Any(x => x.Id == person.Id);

            if (!hasAny)
            {
                return;
            }
           // var find = _context.Person.FirstOrDefault(x => x.Id == person.Id);

            _context.Update(person);
            _context.SaveChanges();
        }

        public  void Remove(int id)
        {
           var obj = _context.Person.Find(id);
            _context.Remove(obj);
            _context.SaveChanges();

        }
    }
}
