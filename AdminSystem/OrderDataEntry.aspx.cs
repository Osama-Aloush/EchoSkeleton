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
        //Capture the Order data
        AnOrder.Order_ID = Convert.ToInt32(OrderIDTextBox.Text);
        AnOrder.Order_Description = OrderDescTextBox.Text;
        AnOrder.Delivery_Address = AddressTextBox.Text;
        AnOrder.Delivery_Status = StatusCheckBox.Checked;
        AnOrder.Order_Date = Convert.ToDateTime(OrderDateTextBox.Text);
        AnOrder.Item_Quantity = Convert.ToInt32(ItemNoTextBox.Text); 
        //Storing an order into a session object
        Session["AnOrder"] = AnOrder;
        //Redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Instance of the class
        clsOrder anOrder = new clsOrder();
        //variable to store the primary key entered into the textbox
        Int32 pkValue;
        pkValue = Convert.ToInt32(OrderIDTextBox.Text);
        Boolean Found = false;

        //Find the record if it exists in the database
        Found = anOrder.Find(pkValue);

        if (Found == true) {
            OrderDescTextBox.Text = anOrder.Order_Description;
            OrderDateTextBox.Text = anOrder.Order_Date.ToString();
            AddressTextBox.Text = anOrder.Delivery_Address;
            StatusCheckBox.Checked = anOrder.Delivery_Status;
            ItemNoTextBox.Text = anOrder.Item_Quantity.ToString();
        }

    }
}