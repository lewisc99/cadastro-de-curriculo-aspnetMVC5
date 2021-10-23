using Microsoft.AspNetCore.Mvc;
using RegistedResumes.Data;
using RegistedResumes.Library;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Controllers
{
    [Login]
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

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var department = _context.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return View("Edit",department);
        }
        [HttpPost]
        public IActionResult Edit(int id,Department department)
        {
           if (ModelState.IsValid)
            {
              //  var departmentt = _context.Department.Find(id);
                _context.Department.Update(department);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", _context.Department.Find(id));
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var department = _context.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }



        [HttpPost]
        public IActionResult Delete(int id)
        {
            var department = _context.Department.Find(id);

            _context.Department.Remove(department);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
