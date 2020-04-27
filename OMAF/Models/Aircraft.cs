using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace OMAF.Models
{
    public class Aircraft                       //This might be the table name for the database.
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a MCN. Ex. orgddd###")]
        [StringLength(9)]
        public string MCN { get; set; }
        [Required(ErrorMessage = "Please enter a Buno. 6 digits only.")]
        public string Buno { get; set; }    //Genre
        [Display(Name = "System Reason")]
        [Required(ErrorMessage = "Please enter a System Reason")]
        public string SysReason { get; set; }   //Title
        public string JobStat { get; set; } //Rating
        [Display(Name = "Initiate Date")]
        [Required(ErrorMessage = "Please enter Date and Time.")]
        //[DataType(DataType.Date)]
        public DateTime InitiateDate { get; set; }
        public int UDP { get; set; }        //Price
        public string Initiator { get; set; }
        public string Discrepancy { get; set; }
        [Display(Name = "IW Date")]
        public DateTime IwDate { get; set; }
        public string Worker { get; set; }
        [Display(Name = "Corrective Action")]
        public string CorrAction { get; set; }
        public string Inspector { get; set; }
        [Display(Name = "Completion Date")]
        public DateTime ComplDate { get; set; }
        [Display(Name = "Mx Controller")]
        public string MxCtrl { get; set; }
        public string MxCtrlNotes { get; set; }
    }
}
