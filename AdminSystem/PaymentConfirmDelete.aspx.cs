using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Delete : System.Web.UI.Page
{
    Int32 NameAdded;
    protected void Page_Load(object sender, EventArgs e)
    {
        NameAdded = Convert.ToInt32(Session["NameAdded"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsPaymentCollection PaymentBook = new clsPaymentCollection();

        PaymentBook.ThisPayment.Find("NameAdded");

        PaymentBook.Delete();

        Response.Redirect("PaymentList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        clsPaymentCollection PaymentBook = new clsPaymentCollection();


        Response.Redirect("PaymentList.aspx");
    }
}