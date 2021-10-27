using Microsoft.AspNetCore.Mvc;
using RegistedResumes.Data;
using RegistedResumes.Library;
using RegistedResumes.Models;
using RegistedResumes.Services;
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
        private readonly DepartmentService _department;

       public  DepartmentsController(RegistedResumesContext context,DepartmentService department)
        {
            _context = context;
            _department = department;
        }

      async  public Task<IActionResult> Index()
        {
            var department = await _department.FindAllAsync();

            return View(department);
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
       async public Task<IActionResult> Edit(int? id)
        {
            var department = await _context.Department.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View("Edit",department);
        }
        [HttpPost]
      async  public Task<IActionResult> Edit(int id,Department department)
        {
           if (ModelState.IsValid)
            {
              //  var departmentt = _context.Department.Find(id);
                _context.Department.Update(department);
               await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Edit", _context.Department.Find(id));
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var department = await _context.Department.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _context.Department.FindAsync(id);

            _context.Department.Remove(department);
           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
