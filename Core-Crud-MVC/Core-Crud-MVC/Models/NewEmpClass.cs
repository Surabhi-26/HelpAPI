using System.ComponentModel.DataAnnotations;

namespace Core_Crud_MVC.Models

{
    public class NewEmpClass
    {
        [Key]
        public int Empid { get; set; }
        [Required(ErrorMessage ="Enter Employee name")]
        [Display(Name ="Employee Name")]
        public string Empname { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Employee age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }


        [Required(ErrorMessage = "Enter Employee salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
