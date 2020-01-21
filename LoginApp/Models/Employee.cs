using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="This field is requered!")]
        [DisplayName("Full Name")]
        [Column(TypeName ="nvarchar(250)")]
        public string FullName { get; set; }

        [DisplayName("Emp. Code")]
        [Column(TypeName ="varchar(10)")]
        public string EmpCode { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string Possition { get; set; }

        [Column(TypeName ="varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
