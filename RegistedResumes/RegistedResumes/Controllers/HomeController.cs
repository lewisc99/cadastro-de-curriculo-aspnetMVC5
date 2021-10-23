using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Http;
using RegistedResumes.Models;
using RegistedResumes.Data;
using System.Linq;

namespace RegistedResumes.Controllers
{
    public class HomeController : Controller
    {

        private readonly RegistedResumesContext _context;

        public HomeController(RegistedResumesContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login(int? id,Staff staff)
        {
            if(ModelState.IsValid)
            {
                bool email = _context.Staff.Any(x => x.Email == staff.Email);

                bool password = _context.Staff.Any(x => x.Password == staff.Password);
                if (email && password)
                {
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Persons");
                }


            }


            return View("Login");
        }
    }
}
