using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store  primary  key -page level scope
    Int32 OrderID;
    string OrderPlacedDate;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                //update the list box
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderPlacedDateFormatted";
        //bind the data to the list
        lstOrderList.DataBind();
        lblError.Text = "";
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            clsOrder AnOrder = new clsOrder();
            //get the primary key of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selectrd from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the reocrd to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //if no record has been seleceted
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //ctore -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
        //update list box
        DisplayOrders();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create instance of the class we want to create
        clsOrderCollection Orders = new clsOrderCollection();
        try
        {
            //try format the data eneterd into the correct format
            DateTime TempDate = DateTime.ParseExact(txtEnterAnOrderPlacedDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //store the new formatted data into  a string to pass it to reportbyorderplaceddate
            string orderPlacedDateFormatted = TempDate.ToString("yyyy/MM/dd");
            Orders.ReportByOrderPlacedDate(orderPlacedDateFormatted);
            lstOrderList.DataSource = Orders.OrderList;
            //set the name of the primary key
            lstOrderList.DataValueField = "OrderID";
            //set name of field to display
            lstOrderList.DataTextField = "OrderPlacedDateFormatted";
            //bind data to list
            lstOrderList.DataBind();
            lblError.Text = "";
        }
        catch (FormatException exception)
        {
            lblError.Text = "Please enter a valid date in the format dd/mm/yyyy";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        DisplayOrders();
        txtEnterAnOrderPlacedDate.Text = "";
    }


    protected void txtEnterAName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}