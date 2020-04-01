using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OMAF.Models
{
    public class Aircraft   
    {
        public int Id { get; set; }
        public string SysReason { get; set; }   //string Title

        //[DataType(DataType.Date)]
        public DateTime InitiateDate { get; set; }  //ReleaseDate
        public int BUNO { get; set; }   //string Genre
        public int UDP  { get; set; }   //decimal Price, 1=U, 2=D, 3=D
    }
}
