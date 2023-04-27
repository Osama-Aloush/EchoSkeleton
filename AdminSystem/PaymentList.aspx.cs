using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayPayments();
        }

    }
    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        //set the name of teh primary key
        lstPaymentList.DataSource = Payments.PaymentList;
        //set the name of the primary key
        lstPaymentList.DataValueField = "NameAdded";
        //set the data field to display
        lstPaymentList.DataTextField = "CardAdded";
        //bind the data to the list
        lstPaymentList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["NameAdded"] = -1;

        Response.Redirect("PaymentDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 NameAdded;
        //if a record has been selected from the list
        if (lstPaymentList.SelectedIndex != -1)
        {
            NameAdded = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["NameAdded"] = NameAdded;

            Response.Redirect("PaymentDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 NameAdded;
        //if a record has been selected from the list
        if (lstPaymentList.SelectedIndex != -1)
        {
            NameAdded = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["NameAdded"] = NameAdded;

            Response.Redirect("PaymentConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}