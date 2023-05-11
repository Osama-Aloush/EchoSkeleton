using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void delbtn_Click(object sender, EventArgs e)
    {
        //this line of code re-directs back to the main page
        Response.Redirect("CustomerDataEntry.aspx");

    }

    protected void logbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }
}