using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace prjCodeFirstEg.Models
{
    public class VehicleContext:DbContext
    {
        public VehicleContext():base("name=efVehicles")
        {

        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Bike> bikes { get; set; }
    }
    
    
}