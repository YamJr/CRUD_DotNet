using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCrud.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is required")]
        [Key]
        [Column("emp_id", Order = 0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Length 2 to 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 500000, ErrorMessage = "Range is 0 to 500000")]
        public double Salary { get; set; }
      
    }
}
