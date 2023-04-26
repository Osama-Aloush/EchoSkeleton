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
        string NameAdded = txtHolderName.Text;
        // capture the card number
        string CardAdded = txtCardNumber.Text;
        // capture the expiry date
        string DateTime = txtExp_Date.Text;
        // capture the CVV number
        string CVVAdded = CVV.Text;
        // capture the customer ID
        string IDAdded = CustomerID.Text;

        string AmountAdded = null;

        //variable to store any error messages
        string Error = "0";
        //validate the data
        Error = AnPayment.Valid(NameAdded, CardAdded, CVVAdded, IDAdded, AmountAdded);
        if (Error == "")
        {
            AnPayment.NameAdded = NameAdded;

            AnPayment.CardAdded = CardAdded;

            AnPayment.CVVAdded = CVVAdded;

            AnPayment.IDAdded = IDAdded;

            //store the name in the session object
            Session["AnPayment"] = AnPayment;
            //navigate to the viewer page
            Response.Write("PaymentViewer.aspx");

        }

        else
        {
            //display the error message
            IbIError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the payment class
        clsPayment AnPayment = new clsPayment();
        //variable to store the primary key
        string NameHolder;
        //variable to tstore the result of hte find operation
        Boolean Found = false;
        //get the primary key entered by the user
        NameHolder = Convert.ToString(txtHolderName.Text);
        //find the record
        Found = AnPayment.Find(NameHolder);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCardNumber.Text = AnPayment.CardAdded;
            txtHolderName.Text = AnPayment.NameAdded;
            txtExp_Date.Text = AnPayment.DateTime;
            CVV.Text = AnPayment.CVVAdded;
            CustomerID.Text = AnPayment.IDAdded;
            CheckBox.Checked = AnPayment.Active;
        }
    }

}
