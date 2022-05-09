using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;



namespace Code_FIrst.Models
{

    public class CustClass
    {   [Key]
        public int userid { get; set; }


        [Required(ErrorMessage = "Please enter your Name")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please enter your valid Email_id")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter your valid email which contains the @ Sign")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string pwd { get; set; }



        [Required(ErrorMessage = "Please enter Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("pwd")]
        public string Confirmpwd { get; set; }


        [Required(ErrorMessage = "Please enter your valid Phone Number")]
        [DataType(DataType.PhoneNumber)]
       // [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public int PhoneNumber { get; set; }
    }
}
