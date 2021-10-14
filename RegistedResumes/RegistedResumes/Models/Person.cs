using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }


        public string Resume { get; set; }

        public Department Department { get; set; }


    }
}
