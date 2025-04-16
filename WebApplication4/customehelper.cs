using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString RedText(this HtmlHelper htmlHelper, string text)
        {
            string html = $"<span style='color:red;'>{HttpUtility.HtmlEncode(text)}</span>";
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString HighlightText(this HtmlHelper helper, string text)
        {
            return new MvcHtmlString($"<span style='background-color:yellow'>{text}</span>");
        }
    }
}