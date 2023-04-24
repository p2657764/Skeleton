using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first time page is displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayCustomers();
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
}
    