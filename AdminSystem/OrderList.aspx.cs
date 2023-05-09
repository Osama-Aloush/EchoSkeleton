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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session obj to indicate this is a new record
        Session["Order_ID"] = -1;
        //Redirect to the Data Entry Page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Varible to store the primary key
        Int32 Order_ID;

        //If a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            Order_ID = Convert.ToInt32(lstOrderList.SelectedValue); //Get the primary key of the record to value
            //Store data in session obj
            Session["Order_ID"] = Order_ID;
            //Redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");

        }
        else { //If no record has been selected
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Primary key variable
        Int32 PK;

        //If the record has been selected from the list
        if (lstOrderList.SelectedIndex != -1) {
            //Get the primary key of the record to delete
            PK = Convert.ToInt32(lstOrderList.SelectedValue);
            //Store the data in the Session obj
            Session["Order_ID"] = PK;
            //Redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Create an instance of the collections class
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByStreetType(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        //Set the name of the primary key
        lstOrderList.DataValueField = "Order_ID";
        //Set the name of the data to be displayed
        lstOrderList.DataTextField = "Delivery_Address";
        //Bind the data to the list
        lstOrderList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Create an instance of the collections class
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByStreetType("");
        //Clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;

        //Set the name of the primary key
        lstOrderList.DataValueField = "Order_ID";
        //Set the name of the data to be displayed
        lstOrderList.DataTextField = "Delivery_Address";
        //Bind the data to the list
        lstOrderList.DataBind();

    }



    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}