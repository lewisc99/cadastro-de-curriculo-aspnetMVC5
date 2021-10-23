using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        public ICollection<Person> Person { get; set; }
        public Department()
        {

        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
