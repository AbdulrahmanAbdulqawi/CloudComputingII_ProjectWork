using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudComputingII_ProjectWork.Models
{
    public class Employee
    {
        [Key]
        public int  EmployeeId { get; set; }
        [Column("nvarchar(250)")]
        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column("nvarchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }
        [Column("nvarchar(1000)")]
        public string Position { get; set; }
        [Column("nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
