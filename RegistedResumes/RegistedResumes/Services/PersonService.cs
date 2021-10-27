using Microsoft.EntityFrameworkCore;
using RegistedResumes.Data;
using RegistedResumes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RegistedResumes.Services
{
    public class PersonService
    {
        private readonly RegistedResumesContext _context;

       public PersonService(RegistedResumesContext contexto)
        {
            _context = contexto;
        }

        public async Task<List<Person>> FindAllAsync()
        {
            return await _context.Person.Include(obj => obj.Department).ToListAsync();
        }

        public async Task InsertAsync(Person person)
        {
            _context.Add(person);
           await _context.SaveChangesAsync();
        }

        public async Task<Person> FindByIdAsync(int id)
        {
            return await _context.Person.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);

        }
        public  async Task UpdatePersonAsync( Person person)
        {
            bool hasAny = await _context.Person.AnyAsync(x => x.Id == person.Id);

            if (!hasAny)
            {
                return;
            }
           // var find = _context.Person.FirstOrDefault(x => x.Id == person.Id);

            _context.Update(person);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(int id)
        {
           var obj =  _context.Person.FindAsync(id);
            _context.Remove(obj);
           await _context.SaveChangesAsync();

        }
    }
}
