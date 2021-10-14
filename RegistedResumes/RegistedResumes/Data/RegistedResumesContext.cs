using Microsoft.EntityFrameworkCore;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Data
{
    public class RegistedResumesContext :DbContext
    {

        public RegistedResumesContext(DbContextOptions<RegistedResumesContext> options)
           : base(options)
        {

        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Person> Person { get; set; }

    }
}
