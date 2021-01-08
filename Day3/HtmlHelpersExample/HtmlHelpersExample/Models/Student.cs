using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelpersExample.Models
{
    public class Student
    {
        [Display(Name = "StudentRollno")]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}