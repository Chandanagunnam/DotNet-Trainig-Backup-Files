﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace prjViewModelEg.ViewModel
{
    public class CustomerVM
    {
        [Key]
        public string CustomerID { get; set; }//Customer.cs
        public string CompanyName { get; set; }//Customer.cs
        public string ContactName { get; set; }//Customer.cs
        public int OrderID { get; set; }//Order.cs
        public Nullable<System.DateTime> OrderDate { get; set; }//Order.cs

    }
}