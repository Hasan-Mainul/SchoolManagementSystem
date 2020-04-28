using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SclManagementSystem.Data.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
