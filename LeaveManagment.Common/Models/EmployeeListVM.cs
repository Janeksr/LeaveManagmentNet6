﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.Common.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [Display(Name = "First name")]
        public string Firstname { get; set; }

        [Display(Name = "Last name")]
        public string Lastname { get; set; }

        [Display(Name = "Email adress")]
        public string Email { get; set; }

        [Display(Name = "Date Joined")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime DateJoined { get; set; }
    }
}
