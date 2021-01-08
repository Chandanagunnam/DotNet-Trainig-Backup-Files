using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prjCodeFirstEg.Models
{
    [Table("tblCar")] //using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]//using System.ComponentModel.DataAnnotations

        public int carno { get; set; }
        public string carname { get; set; }
        public string cartype { get; set; }
    }
}