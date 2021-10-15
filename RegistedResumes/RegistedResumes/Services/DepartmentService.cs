using RegistedResumes.Data;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Services
{
    public class DepartmentService
    {

        private readonly RegistedResumesContext _context;


        DepartmentService(RegistedResumesContext context)
        {
            _context = context;
        }


        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
