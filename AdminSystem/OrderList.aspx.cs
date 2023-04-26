using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false) {
            //Update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders() {
        clsOrderCollection Orders = new clsOrderCollection();
        //Set the data source to list of address in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //Set the name of the primary key
        lstOrderList.DataValueField = "Order_ID";
        //Set the data field to display
        lstOrderList.DataTextField = "Delivery_Address";
        //Bind the data to the list
        lstOrderList.DataBind();
    }
}