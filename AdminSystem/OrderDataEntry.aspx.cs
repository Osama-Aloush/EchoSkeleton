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

        //Store the textbox data into variables
        String orderDescVal = OrderDescTextBox.Text;
        String addressVal = AddressTextBox.Text;
        int itemNoVal = Convert.ToInt32(ItemNoTextBox.Text);
        String orderDateVal = OrderDateTextBox.Text;

        //Store the errors in a variable
        String Error = "";

        //Validating the data
        Error = AnOrder.Valid(orderDescVal, addressVal, itemNoVal, orderDateVal);
        //If there are no errors store the values
        if (Error == "")
        {
            AnOrder.Order_Description = orderDescVal;
            AnOrder.Delivery_Address = addressVal;
            AnOrder.Item_Quantity = itemNoVal;
            AnOrder.Order_Date = Convert.ToDateTime(orderDateVal);

            //Storing an order into a session object
            Session["AnOrder"] = AnOrder;
            //Redirect to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
        else {
            //Display Error Message
            ErrorLabel.Text = Error;
        }


        
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