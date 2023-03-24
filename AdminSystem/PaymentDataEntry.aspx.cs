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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        // capture the card holder name
        AnPayment.NameAdded = txtHolderName.Text;
        // capture the card number
        AnPayment.CardAdded = txtCardNumber.Text;
        // capture the expiry date
        AnPayment.DateTime = txtExp_Date.Text;
        // capture the CVV number
        AnPayment.CVVAdded = CVV.Text;
        // capture the customer ID
        AnPayment.IDAdded = CustomerID.Text;
        //store the name in the session object
        Session["AnPayment"] = AnPayment;
        //navigate to the viewer page
        Response.Redirect("PaymentViewer.aspx");
    }
}