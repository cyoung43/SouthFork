using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SouthFork.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [DisplayName("Employee First Name")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Employee Last Name")]
        [StringLength(25, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Employee Email")]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Employee Phone")]
        [StringLength(15)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Employee Wage")]
        [Range(5, 100)]
        public int Wage { get; set; }

        [Required]
        [DisplayName("Employee Password")]
        [StringLength(25, MinimumLength = 7)]
        [PasswordPropertyText]
        public string Password { get; set; }

        [DisplayName("Position Type")]
        public int? PositionID { get; set; }
    }
}