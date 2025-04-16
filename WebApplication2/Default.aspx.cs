using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default :Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lbl1.Text = "Server side webforms page loading";
        }
        protected void Load(object sender, EventArgs e)
        {

        }
        protected void init(object sender, EventArgs e)
        {

        }
    }
}