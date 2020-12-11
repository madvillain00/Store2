using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Employee")]
    public class Employee
    {
        
        [Key]
        //[ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        //[Required]
        public string NameOfEmployee { get; set; }
        public string NameOfPosition { get; set; }
        public string Address { get; set; }
        public string PhoneOfEmployee { get; set; }
        public string Birthday { get; set; }


    }
}