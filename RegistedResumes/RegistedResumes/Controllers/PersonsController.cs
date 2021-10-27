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


        public async Task<IActionResult> Index()
        {
            var Person = await _personService.FindAllAsync();
            
            return View(Person);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {


            var departments = await _departmentService.FindAllAsync();
                var viewModel = new PersonViewModel() { Department = departments };
            
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Person person)
        {
            if(ModelState.IsValid)
            {
               await _personService.InsertAsync(person);
                return RedirectToAction(nameof(Index));
            }
            var departments = await _departmentService.FindAllAsync();
            var viewModel = new PersonViewModel() { Person = person, Department = departments };
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Person person = await _personService.FindByIdAsync(id.Value);

            List<Department> departments = await _departmentService.FindAllAsync();
            PersonViewModel personView = new PersonViewModel { Person = person, Department = departments };

            return View("Edit", personView);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Person person)
        {
           if(!ModelState.IsValid)
            {
                List<Department> department = await _departmentService.FindAllAsync();
                PersonViewModel viewModel = new PersonViewModel { Person = person, Department = department };

                return View( viewModel);
            }
            await _personService.UpdatePersonAsync(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var obj = await _personService.FindByIdAsync(id.Value);

            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
          await  _personService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
