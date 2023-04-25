using System;
using System.Collections.Generic;
// using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //varibale to store primary key with page level scope
    Int32 CustomerID;
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
            //capture customer ID
            ACustomer.CustomerID = CustomerID;
            //capture customer name
            ACustomer.CustomerName = CustomerName;
            //capture address line
            ACustomer.AddressLine1 = AddressLine1;
            //capture post code
            ACustomer.PostCode = PostCode;
            //capture email address
            ACustomer.EmailAddress = EmailAddress;
            //capture account creation date
            ACustomer.AccountCreationDate = Convert.ToDateTime(AccountCreationDate);
            //capture email verification
            ACustomer.EmailVerification = chkEmailVerification.Checked;
            //create new instance of customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;
            //add new record 
            CustomerList.Add();
            //redirect to list page
            Response.Redirect("CustomerList.aspx");
            //update list box
            DisplayCustomers();

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
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtCustomerName.Text = ACustomer.CustomerName;
            txtAddressLine1.Text = ACustomer.AddressLine1;
            txtPostCode.Text = ACustomer.PostCode;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            chkEmailVerification.Checked = ACustomer.EmailVerification;
            txtAccountCreationDate.Text = ACustomer.AccountCreationDate.ToString();
        }
    }

    void DisplayCustomers()
    {
        //create instance of the customer list
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find record to update
        CustomerList.ThisCustomer.Find(CustomerID);
        //display data for record
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = CustomerList.ThisCustomer.CustomerName;
        txtAddressLine1.Text = CustomerList.ThisCustomer.AddressLine1;
        txtPostCode.Text = CustomerList.ThisCustomer.PostCode;
        txtEmailAddress.Text = CustomerList.ThisCustomer.EmailAddress;
        chkEmailVerification.Checked = CustomerList.ThisCustomer.EmailVerification;
        txtAccountCreationDate.Text = CustomerList.ThisCustomer.AccountCreationDate.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to list page
        Response.Redirect("CustomerList.aspx");
    }
}