using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelper.CustomClasses
{
    public static class Customhelper
    {
        //int add();
        //float sub();
        //static
        public static IHtmlString LabelwithMark(string content)
        {
            string htmlstring = String.Format("<label><b><i>{0}</i></b></label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString LabelwithItalic(this HtmlHelper helper,string content)
        {
            string htmlstring = String.Format("<label><i>{0}</i></label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString LabelwithColor(this HtmlHelper helper, string content)
        {
            string htmlstring = String.Format("<label><font color=green>{0}</font></label>", content);
            return new HtmlString(htmlstring);
        }


    }
}