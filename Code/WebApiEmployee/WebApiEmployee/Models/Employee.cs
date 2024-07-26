using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Reflection;

namespace WebApiEmployee.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public required string FirstName { get; set; }   
        public required string LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required char Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required DateTime HireDate { get; set; }
        public required decimal Salary { get; set; }
        public int? SupervisorID { get; set; }
        [ForeignKey("SupervisorID")]
        public virtual Employee? Supervisor { get; set; }
        public required string EmploymentStatus { get; set; }
    }
}
