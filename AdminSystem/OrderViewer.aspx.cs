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
        Response.Write(AnOrder.Order_ID);
        Response.Write("\r\n\r\n");
        Response.Write(AnOrder.Order_Description);
        Response.Write("\r\n");
        Response.Write(AnOrder.Delivery_Address);
        Response.Write("\r\n");
        Response.Write(AnOrder.Item_Quantity);
        Response.Write("\r\n");
        Response.Write(AnOrder.Delivery_Status);
        Response.Write("\r\n");
        Response.Write(AnOrder.Order_Date);
    }
}