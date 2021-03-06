using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Angular_WebApp.Models;

namespace Angular_WebApp.ViewModels
{
    public class AppointmentViewModel
    {
        public string CustomerFirstName {get; set;}
        public string CustomerMiddleName {get; set;}
        public string CustomerLastName {get; set;}
        public int EmployeeId {get; set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MMM-dd, hh.mm tt}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentTime {get; set;}

    }
}