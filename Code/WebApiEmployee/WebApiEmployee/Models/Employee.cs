using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Reflection;

namespace WebApiEmployee.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int FirstName { get; set; }   
        public int LastName { get; set; }
        public int DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int MaritalStatus { get; set; }
        public int Address { get; set; }
        public int PhoneNumber { get; set; }
        public int Email { get; set; }
        public int HireDate { get; set; }
        public int Salary { get; set; }
        public int SupervisorID { get; set; }
        public int EmploymentStatus { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
    }
}
