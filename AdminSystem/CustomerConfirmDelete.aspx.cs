using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store primary key value of record to delete
    Int32 CustomerID;

    //event handler for load
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the customer to delete from session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of address book class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find record to delete
        CustomerList.ThisCustomer.Find(CustomerID);
        //delete record
        CustomerList.Delete();
        //redirect to main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}