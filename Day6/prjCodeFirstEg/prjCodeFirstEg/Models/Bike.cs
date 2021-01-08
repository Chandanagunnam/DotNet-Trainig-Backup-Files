using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prjCodeFirstEg.Models
{
    [Table("tblBike")]
    public class Bike
    {
        [Key]

        public int BikeNo { get; set; }

        public string Bikename { get; set; }
        public string BikeType { get; set; }
    }
}