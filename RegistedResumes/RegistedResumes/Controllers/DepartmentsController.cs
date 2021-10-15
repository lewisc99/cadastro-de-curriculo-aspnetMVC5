using Microsoft.AspNetCore.Mvc;
using RegistedResumes.Data;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Controllers
{
    public class DepartmentsController : Controller
    {
       private readonly RegistedResumesContext _context;

       public  DepartmentsController(RegistedResumesContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           

            return View(_context.Department.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create([Bind( "Id,Name")]  Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Department.Add(department);
                _context.SaveChanges();
               return RedirectToAction(nameof(Index));

            }

            return View(department);
        }
    }
}
