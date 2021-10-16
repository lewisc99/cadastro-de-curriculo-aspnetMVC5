using Microsoft.AspNetCore.Mvc;
using RegistedResumes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Controllers
{
    public class PersonsController : Controller
    {

        private readonly RegistedResumesContext _context;


       public PersonsController(RegistedResumesContext contexto)
        {
            _context = contexto;
        }


        public IActionResult Index()
        {
            var Person = _context.Person.ToList();
            
            return View(Person);
        }

    }
}
