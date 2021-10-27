using Microsoft.AspNetCore.Mvc;


using Microsoft.AspNetCore.Http;
using RegistedResumes.Models;
using RegistedResumes.Data;
using System.Linq;
using System.Threading.Tasks;

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


        [HttpPost]
        public  IActionResult Login(int? id, Staff staff)
        {


            bool email =  _context.Staff.Any(obj => obj.Email == staff.Email) ;

                bool password = _context.Staff.Any(x => x.Password == staff.Password);
                
                if (email == true && password == true )
                {
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Persons");
                }
                else
                {
                    if (password == false && email == false)
                    {
                        
                    ViewBag.Mensagem = "The email and  Password is invalid.";
                }
                    else if (email == false)  
                    {
                    ViewBag.Mensagem = "The E-mail is invalid.";
                    }
                    else
                    {
                    ViewBag.Mensagem = "The Password is invalid.";
                    
                    }
                    
                    return View("Login",staff);
                }
               


            ViewBag.Mensagem = "The E-mail or the password is invalid.";
            return View();


        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

          return  RedirectToAction("Index");
        }
    }
}
