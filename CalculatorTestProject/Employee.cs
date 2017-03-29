using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculatorTestProject
{
    public class Employee
    {
        [Required(ErrorMessage ="Employee id shouldnot be Empty")]
        public string EmpId { get; set; }
        [Required(ErrorMessage ="Enter your Name")]
        public string EmpName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        [Required(ErrorMessage ="Enter your Email.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid Email Address.")]
        public string Email { get; set; }
       
        public int age { get; set; }

    }
}
