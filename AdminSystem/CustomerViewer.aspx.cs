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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        string NewLine = ("\n");
        Response.Write(ACustomer.CustomerName + NewLine);
        Response.Write(ACustomer.AddressLine1 + NewLine);
        Response.Write(ACustomer.PostCode + NewLine);
        Response.Write(ACustomer.EmailAddress + NewLine);
        Response.Write(ACustomer.EmailVerification + NewLine);
        Response.Write(ACustomer.AccountCreationDate + NewLine);
    }
}