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
        //create new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture customer name
        string CustomerName = txtCustomerName.Text;
        //capture address line
        string AddressLine1 = txtAddressLine1.Text;
        //capture post code
        string PostCode = txtPostCode.Text;
        //capture email address
        string EmailAddress = txtEmailAddress.Text;
        //capture account creation date
        string AccountCreationDate = txtAccountCreationDate.Text;
        //store any error messages in variable
        string Error = "";
        //validate data
        Error = ACustomer.Valid(CustomerName, AddressLine1, PostCode, EmailAddress, AccountCreationDate);
        if (Error == "")
        {
            //capture customer name
            ACustomer.CustomerName = txtCustomerName.Text;
            //capture address line
            ACustomer.AddressLine1 = txtAddressLine1.Text;
            //capture post code
            ACustomer.PostCode = txtPostCode.Text;
            //capture email address
            ACustomer.EmailAddress = txtEmailAddress.Text;
            //capture account creation date
            ACustomer.AccountCreationDate = Convert.ToDateTime(txtAccountCreationDate.Text);
            //store customer in session object
            Session["ACustomer"] = ACustomer;
            //redirect to view page
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display error message 
            lblError.Text = Error;
        }
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