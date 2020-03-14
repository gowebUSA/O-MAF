using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace O_MAF.Models
{
    public class LoginResponse
    {
        [Required(ErrorMessage = "Please enter your Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your pin")]
        [RegularExpression("^[\\(]{0,1}([0-9]){3}[\\)]{0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$",
            ErrorMessage = "Please enter a valid pin number xxx-xxx-xxxx")]
        public string Pin { get; set; }

    }
}
