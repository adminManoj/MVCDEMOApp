using System.ComponentModel.DataAnnotations;

namespace MVCDEMOApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        [Range(10000, 100000)]
        public decimal Salary { get; set; }
    }
}
