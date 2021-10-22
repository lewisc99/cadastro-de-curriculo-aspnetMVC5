using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.ViewModels
{
    public class PersonViewModel
    {

        public Person Person { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
