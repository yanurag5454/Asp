using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Employee1.Models
{
	public class Employee
	{
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }  

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be positive")]
        public int Salary { get; set; }


        [Required(ErrorMessage = "Joining date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }


    }
}

