using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistedResumes.Models
{
    public class Person:IValidatableObject
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="The name is required to fill it")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="The mininum length of the {0} must be 5 and max 20")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The E-mail is required to fill it")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Birthdate is required to fill it")]

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Display(Name="Birth date")]
        [DataType(DataType.Date )]

        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "The Resume is required to fill it")]
        [StringLength(100,MinimumLength =20,ErrorMessage ="size should be 20 between and 100")]

        public string Resume { get; set; }

        public Department Department { get; set; }

        [Display(Name="Department Name")]
        public int DepartmentId { get; set; }


        public Person()
        {

        }

        public Person(int id, string name, string email, DateTime birthday, string resume,Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthday;
            Resume = resume;
            Department = department;
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(!string.IsNullOrEmpty(this.Name))
            {
                var firstLetter = this.Name[0].ToString();

                if( firstLetter != firstLetter.ToUpper())
                {
                    yield return new
                        ValidationResult("The first letter must be Uppercase ", //vai retornar a exceção.
                        new[]
                        {
                            nameof(this.Name)  //e vai retornar uma lista de membros de validação.
                        });
                }
            }
            
          
        }
    }
}
