using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Data
{
    public class SendingService
    {
        private RegistedResumesContext _context;
       public  SendingService(RegistedResumesContext contexto)
        {
            _context = contexto;
        }


        public void Seed()
        {
            if (_context.Department.Any() || _context.Person.Any())
            {
                return;
            }
            else

            {
                Department d1 = new Department(1, "Sales");
                Department d2 = new Department(2, "Costumer's service");
                Department d3 = new Department(3, "Software Engineer");
                Department d4 = new Department(4, "Cleaning work");


                Person p1 = new Person(1, "Maria", "maria@gmail.com", new DateTime(1972, 12, 20), " I already worked in a supermarket for two years cleaning and washing", d4);
                Person p2 = new Person(2, "Joao", "joaopera@gmail.com", new DateTime(1993, 3, 20), "I am professional for 2 years, worked in a large company, where " +
                    "I haved developed a app to increased the flexibility to the client", d3);


                _context.Department.AddRange(d1, d2, d3, d4);
                _context.Person.AddRange(p1, p2);

                _context.SaveChanges();
            }
        }
    
    
    }
}
