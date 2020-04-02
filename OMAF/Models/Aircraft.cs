using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMAF.Models
{
    public class Aircraft   
    {
        public int Id { get; set; }
        [Display(Name = "System Reason")]
        public string SysReason { get; set; }   //string Title

        [Display(Name = "Initiate Date")]
        //[DataType(DataType.Date)] //Commented put bec I wanted to show the time as (DataType.DateTime).
        public DateTime InitiateDate { get; set; }  //ReleaseDate
        public int BUNO { get; set; }   //string Genre
        //[Display(Name = "1U/2D/3P")]  //Commented bec I just wanat to play around on looks.
        public int UDP  { get; set; }   //decimal Price, 1=U, 2=D, 3=D
    }
}
