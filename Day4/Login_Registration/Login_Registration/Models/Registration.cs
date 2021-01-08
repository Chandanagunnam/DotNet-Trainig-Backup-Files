using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Login_Registration.Models
{
    public class Registration
    {
        
        [Required(ErrorMessage ="Name is Mandatory")]
        [Display(Name ="UserName",Prompt ="Enter Name")]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Enter mailid")]
        [Display(Name="EmailiD")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter password for confirmation is Mandatory")]
        [Display(Name = "Confirm Password", Prompt = "Enter Name")]
        [Compare("Password", ErrorMessage ="Password not matching")]
        public string ConfirmPassword { get; set; }


    }

    public enum Country
    {
        India,Nepal,Bhutan,SriLanka,Bangladesh,Pakistan
    }

}