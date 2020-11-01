using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin_Backend.Models
{
    [Table("Employee", Schema = "HumanResources")]
    public class Employee
    {
        [Key]
        public int BusinessEntityID { get; set; }
        //public string NationalIDNumber { get; set; }
        public string JobTitle { get; set; }
        //public DateTime BirthDate { get; set; }
        //public string MaritalStatus { get; set; }
        //public string Gender { get; set; }
        //public DateTime HireDate { get; set; }
        //public Int16 VacationHours { get; set; }
        //public Int16 SickLeaveHours { get; set; }
    }
}