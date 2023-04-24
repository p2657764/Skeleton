using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store primary key - page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first time page is displayed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1) 
            {
                //update list box
                DisplayCustomers();
            }
        }
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data to list of customers in collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set name of primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set data field to display
        lstCustomerList.DataTextField = "CustomerName";
        //bind data to list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session object to indicate new record
        Session["CustomerID"] = -1;
        //redirect to data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary key value of record to be edited
        Int32 CustomerID;
        //if record has been selected from list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value of record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in session object
            Session["CustomerID"] = CustomerID;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }

        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store primary key value of record to delete
        Int32 CustomerID;
        //if record has been seleted from list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get primary key value of record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in session object
            Session["CustomerID"] = CustomerID;
            //redirect to delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }

        else //if no record found
        {
            //display error
            lblError.Text = "Please select a record to delete from this list";
        }
    }
}
    