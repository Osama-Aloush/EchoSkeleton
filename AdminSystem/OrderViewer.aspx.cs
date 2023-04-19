using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Creating instance of a class
        clsOrder AnOrder = new clsOrder();
        //Getting data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //Display OrderID on the page
        Response.Redirect(AnOrder.Order_ID);
    }
}