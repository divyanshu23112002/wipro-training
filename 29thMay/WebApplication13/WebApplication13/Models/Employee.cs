using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication13.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]

        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string Department { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required]
        [Column(TypeName="decimal(18,2)")]
        [Display(Name ="Monthly Salary")]
        [Range(0,10000000,ErrorMessage ="Salary must between 0 and 1,000,000")]
        public decimal Salary { get; set; }
    }
}
