using Microsoft.AspNetCore.Mvc;
using RegistedResumes.Data;
using RegistedResumes.Models;
using RegistedResumes.Services;
using RegistedResumes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Controllers
{
    public class PersonsController : Controller
    {

        
        private readonly DepartmentService _departmentService;
        private readonly PersonService _personService;

        public PersonsController(PersonService personService,DepartmentService departmentService)
        {
            _personService = personService;
            _departmentService = departmentService;
        }


        public IActionResult Index()
        {
            var Person = _personService.FindAll();
            
            return View(Person);
        }

        [HttpGet]
        public IActionResult Create()
        {


            var departments = _departmentService.FindAll();
                var viewModel = new PersonViewModel() { Department = departments };
            
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                _personService.Insert(person);
                return RedirectToAction(nameof(Index));
            }
            var departments = _departmentService.FindAll();
            var viewModel = new PersonViewModel() { Person = person, Department = departments };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Person person = _personService.FindById(id.Value);

            List<Department> departments = _departmentService.FindAll();
            PersonViewModel personView = new PersonViewModel { Person = person, Department = departments };

            return View("Edit", personView);

        }
        [HttpPost]
        public IActionResult Edit(int id, Person person)
        {
           if(!ModelState.IsValid)
            {
                List<Department> department = _departmentService.FindAll();
                PersonViewModel viewModel = new PersonViewModel { Person = person, Department = department };

                return View( viewModel);
            }
            _personService.UpdatePerson(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var obj = _personService.FindById(id.Value);

            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _personService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
