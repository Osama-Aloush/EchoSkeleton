using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Creating a new instance of a class
        clsOrder AnOrder = new clsOrder();
        //Capture the Order ID
        AnOrder.Order_ID = OrderIDTextBox.Text;
        //Storing an order into a session object
        Session["An_Order"] = AnOrder;
        //Redirect to the viewer page
        Response.Redirect("OrderViewr.aspx");
    }
}