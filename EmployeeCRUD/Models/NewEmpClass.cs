using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class NewEmpClass
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Employee Position")]
        [Display(Name="Position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Enter Employee Office")]
        [Display(Name = "Office")]
        public string Office { get; set; }

        [Required(ErrorMessage = "Enter Employee Age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Employee Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
