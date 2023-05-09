using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        //get the data from the session object
        AnPayment = (clsPayment)Session["AnPayment"];
        //display the Card Name Holder for this entry
        Response.Write(AnPayment.NameAdded);
        Response.Write(AnPayment.CardAdded);
        Response.Write(AnPayment.DateTime);
        Response.Write(AnPayment.CVVAdded);
        Response.Write(AnPayment.IDAdded);

    }
}