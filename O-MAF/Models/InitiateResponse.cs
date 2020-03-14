using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace O_MAF.Models
{
    public class InitiateResponse
    {
        [Required(ErrorMessage = "Please enter your modex")]
        public int Modex { get; set; }

        [Required(ErrorMessage = "Please enter system reason")]
        public string SysReason { get; set; }

        [Required(ErrorMessage = "Please enter your discrepancy")]
        public string Discrepancy { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Initiator { get; set; }

        [Required(ErrorMessage = "Please enter your qualification")]
        public string Qual { get; set; }

        [Required(ErrorMessage = "Please enter your workcenter")]
        public string WkCtr { get; set; }

        [Required(ErrorMessage = "Please specify if aircraft is flyable")]
        public bool? AcftUp { get; set; }
    }
}
