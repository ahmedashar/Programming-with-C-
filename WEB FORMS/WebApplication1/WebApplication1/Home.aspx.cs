using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script> alert('Hello') </script>");
            //Button1.Text = "Press";
            //Label1.Text = "Hello, I'm Haseeb Solungi";

            string name = TextBox1.Text;
            Label2.Text = name;

            Response.Redirect("About.aspx");

        }
    }
}