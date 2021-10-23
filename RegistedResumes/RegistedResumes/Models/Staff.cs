using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Models
{
    public class Staff
    {

        [Key]

        public int Id { get; set; }


        [Required]

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(20,MinimumLength =5,ErrorMessage ="Password {0} must be beetween 5 and 20 caracters.")]

        [Required(ErrorMessage = "The Password is required to fill it")]

        public string Password { get; set; }



        public Staff()
        {

        }
        public Staff(int id,string email, string password)

        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
