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
    
    protected void Button1_Click(object sender, EventArgs e) //find button
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable o store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID);
        //find the record 
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderPlacedDate.Text = AnOrder.OrderPlacedDate.ToString();
            chkOrderVerification.Checked = AnOrder.OrderVerification;
            txtProductQuantity.Text = AnOrder.ProductQuantity.ToString();
            txtUnitPrice.Text = AnOrder.UnitPrice.ToString();
            txtShippingDate.Text = AnOrder.ShippingDate.ToString(); 
        }
    }

    protected void btnOK_Click_Click(object sender, EventArgs e)//OK BUTTON
    {
        //create new instance of clsORder
        clsOrder AnOrder = new clsOrder();
        //capture placed date
        string OrderPlacedDate = txtOrderPlacedDate.Text;
        //capture product quantity
        string ProductQuantity = txtProductQuantity.Text;
        //capture unit price
        string UnitPrice = txtUnitPrice.Text;
        //capture shipping date
        string ShippingDate = txtShippingDate.Text;
        //store any error messages in variable
        string Error = "";
        //validate data
        Error = AnOrder.Valid(OrderPlacedDate, ProductQuantity, UnitPrice, ShippingDate);
        if (Error == "")
        {
            //capture the orderid
            AnOrder.OrderID = Convert.ToInt32(txtOrderID);
            //capture order placed date
            AnOrder.OrderPlacedDate = Convert.ToDateTime(txtOrderPlacedDate.Text);
            //capture product quantity
            AnOrder.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            //capture unit price
            AnOrder.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
            //capture shipping date
            AnOrder.ShippingDate = Convert.ToDateTime(txtShippingDate.Text);
            //capture active
            AnOrder.Active = chkOrderVerification.Checked;
            //store customer in session object
            Session["AnOrder"] = AnOrder;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //if this is a new record i.e. OrderID = -1 then add the data
            if (Convert.ToInt32(txtOrderID) == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the recotd to update
                OrderList.ThisOrder.Find(Convert.ToInt32(txtOrderID));
                //set the thisorder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }
    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(Convert.ToInt32(txtOrderID));
        //display the data for this record
        txtOrderPlacedDate.Text = OrderBook.ThisOrder.OrderPlacedDate.ToString();
        chkOrderVerification.Checked = OrderBook.ThisOrder.OrderVerification;
        txtProductQuantity.Text = OrderBook.ThisOrder.ProductQuantity.ToString();
        txtUnitPrice.Text = OrderBook.ThisOrder.UnitPrice.ToString();
        txtShippingDate.Text = OrderBook.ThisOrder.ShippingDate.ToString();
    }
}