using System;
using System.Collections.Generic;
// using System.Linq;
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of customer class
        clsCustomer ACustomer = new clsCustomer();
        //store primary key
        Int32 CustomerID;
        //variable to store result of find
        Boolean Found = false;
        //get primary key from user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display value of properties in form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtAddressLine1.Text = ACustomer.AddressLine1;
            txtPostCode.Text = ACustomer.PostCode;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            chkEmailVerification.Checked = ACustomer.EmailVerification;
            txtAccountCreationDate.Text = ACustomer.AccountCreationDate.ToString();
        }
    }
}