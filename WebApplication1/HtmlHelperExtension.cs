using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public static class HtmlHelperExtension
    {
        public static MvcHtmlString CustomlabelColorRed(this HtmlHelper html,string text)
        {
            return new MvcHtmlString($"<label class='danger'>{text}</label>");
        }
    }
}