using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //PK variable
    Int32 Order_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the Number of Addresses to be deleted from the session obj
        Order_ID = Convert.ToInt32(Session["Order_ID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Creating instance of the collections class
        clsOrderCollection OrderList = new clsOrderCollection();
        //Find the record to delete
        OrderList.Delete();
        //Redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}