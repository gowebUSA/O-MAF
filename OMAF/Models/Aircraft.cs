using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OMAF.Models
{
    public class Aircraft                       //This might be the table name for the database.
    {
        public int Id { get; set; }
        public string Buno { get; set; }    //Genre
        //
        [Display(Name = "System Reason")]
        public string SysReason { get; set; }   //Title
        //
        [Display(Name = "Date")]
        //[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int UDP { get; set; }        //Price
    }
}
