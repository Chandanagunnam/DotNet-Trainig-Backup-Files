﻿using System.Web;
using System.Web.Mvc;

namespace Eager_Lazy_Loading_Ex
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
