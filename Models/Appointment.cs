using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angular_WebApp.Models
{
    public class Appointment : AuditInfo
    {
        [Key]
        public int AppointmentId {get; set;}

        [ForeignKey("Customer")]
        public int CustomerId {get; set;}
        public Customer Customer {get; set;}

        [ForeignKey("Employee")]
        public int EmployeeId {get; set;}
        public Employee Employee{get; set;}
        public DateTime AppointmentTime {get; set;}
    }
}