using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //Varible to store the primary key
    Int32 Order_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        Order_ID = Convert.ToInt32(Session["Order_ID"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            if (Order_ID != -1)  {
                //Display current data for the record
                DisplayOrders();
            }
        }
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
            //Capture the data
            AnOrder.Order_ID = Order_ID;
            AnOrder.Order_Description = orderDescVal;
            AnOrder.Delivery_Address = addressVal;
            AnOrder.Item_Quantity = itemNoVal;
            AnOrder.Order_Date = Convert.ToDateTime(orderDateVal);
            //Create instance of the order collection class
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. Order_ID = -1 then add it
            if (Order_ID == -1)
            {
                //Set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //Add the new record...
                OrderList.Add();
            }
            //If not it must be updated
            else {
                //Find the record to update
                OrderList.ThisOrder.Find(Order_ID);
                //Set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //Update the record
                OrderList.Update();

            }
            //REdirect to the OrderList page
            Response.Redirect("OrderList.aspx");
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

    void DisplayOrders() {
        //Create an instance of the class
        clsOrderCollection Orders = new clsOrderCollection();
        //Find the record to update
        Orders.ThisOrder.Find(Order_ID);
        //Display the data for the record
        OrderIDTextBox.Text = Orders.ThisOrder.Order_ID.ToString();
        ItemNoTextBox.Text = Orders.ThisOrder.Item_Quantity.ToString();
        OrderDescTextBox.Text = Orders.ThisOrder.Order_Description;
        OrderDateTextBox.Text = Orders.ThisOrder.Order_Date.ToString();
        AddressTextBox.Text = Orders.ThisOrder.Delivery_Address;
        StatusCheckBox.Checked = Orders.ThisOrder.Delivery_Status;
    }
}