using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace prjViewModelEg.ViewModel
{
    public class ProductVM
    {
        [Key]

        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
    }
}