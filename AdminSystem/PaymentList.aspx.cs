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
}