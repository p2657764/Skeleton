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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.AddressLine1 = txtAddressLine1.Text;
        ACustomer.PostCode = txtPostCode.Text;
        ACustomer.EmailAddress = txtEmailAddress.Text;
        ACustomer.EmailVerification = chkEmailVerification.Visible;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void chkEmailVerification_CheckedChanged(object sender, EventArgs e)
    {

    }
}