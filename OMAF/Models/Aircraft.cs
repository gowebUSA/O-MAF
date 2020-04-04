using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OMAF.Models
{
    public class Aircraft                       //This might be the table name for the database.
    {
        public int Id { get; set; }
        public string Buno { get; set; }    //Genre
        public string SysReason { get; set; }   //Title

        //[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int UDP { get; set; }        //Price
    }
}
