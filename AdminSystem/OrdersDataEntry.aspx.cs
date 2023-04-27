using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OrderID"] != null)
        {
            int OrderID = Convert.ToInt32(Session["OrderID"].ToString());
            //create instance of order class
            clsOrder AnOrder = new clsOrder();
            bool Found = AnOrder.Find(OrderID);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtOrderID.Text = AnOrder.OrderID.ToString();
                txtOrderPlacedDate.Text = AnOrder.OrderPlacedDate.ToString().Substring(0, 10);
                chkOrderVerification.Checked = AnOrder.OrderVerification;
                txtProductQuantity.Text = AnOrder.ProductQuantity.ToString();
                txtUnitPrice.Text = AnOrder.UnitPrice.ToString();
                txtShippingDate.Text = AnOrder.ShippingDate.ToString().Substring(0, 10);
            }
        }
    }
    
    protected void btnFind_Click(object sender, EventArgs e) //find button
    {
        bool emptychecker = string.IsNullOrEmpty(txtOrderID.Text);
        int number;
        bool numericchecker = int.TryParse(txtOrderID.Text, out number);
        if (emptychecker == false && numericchecker == true)
        {
            //create an instance of the address class
            clsOrder AnOrder = new clsOrder();
            //variable o store the primary key
            Int32 OrderID;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            OrderID = Convert.ToInt32(txtOrderID.Text);
            //find the record 
            Found = AnOrder.Find(OrderID);
            //if found
            if (Found == true)
            {
                //display the values of the properties in the form
                txtOrderPlacedDate.Text = AnOrder.OrderPlacedDate.ToString().Substring(0, 10);
                chkOrderVerification.Checked = AnOrder.OrderVerification;
                txtProductQuantity.Text = AnOrder.ProductQuantity.ToString();
                txtUnitPrice.Text = AnOrder.UnitPrice.ToString();
                txtShippingDate.Text = AnOrder.ShippingDate.ToString().Substring(0, 10);
            }
            else
            {
                lblError.Text = "Doesnt Exist";
                ClearAll();

            }
        }
        else
        {
            lblError.Text = "Enter a valid OrderID";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)//OK BUTTON
    {
        //create new instance of clsORder
        clsOrder AnOrder = new clsOrder();
        if (!string.IsNullOrEmpty(txtOrderID.Text))
        {
            OrderID = Convert.ToInt32(txtOrderID.Text);
        }
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
            AnOrder.OrderID = OrderID;
            //capture order placed date
            AnOrder.OrderPlacedDate = Convert.ToDateTime(OrderPlacedDate.Substring(0, 10));
            //capture product quantity
            AnOrder.ProductQuantity = Convert.ToInt32(ProductQuantity);
            //capture unit price
            AnOrder.UnitPrice = Convert.ToDecimal(UnitPrice);
            //capture shipping date
            AnOrder.ShippingDate = Convert.ToDateTime(ShippingDate.Substring(0, 10));
            //capture active
            AnOrder.Active = chkOrderVerification.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //if this is a new record i.e. OrderID = -1 then add teh data
            if(OrderID == -1)
            {
                //set the thisorder properrty
                OrderList.ThisOrder = AnOrder;
                //add the new reocord
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the Thisorder property
                OrderList.ThisOrder = AnOrder;
                //update the new record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrdersList.aspx");
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
        OrderBook.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderPlacedDate.Text = OrderBook.ThisOrder.OrderPlacedDate.ToString();
        chkOrderVerification.Checked = OrderBook.ThisOrder.OrderVerification;
        txtProductQuantity.Text = OrderBook.ThisOrder.ProductQuantity.ToString();
        txtUnitPrice.Text = OrderBook.ThisOrder.UnitPrice.ToString();
        txtShippingDate.Text = OrderBook.ThisOrder.ShippingDate.ToString();
    }

    protected void chkOrderVerification_CheckedChanged(object sender, EventArgs e)
    {

    }
    void ClearAll()
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //clear the boxes
        txtOrderID.Text = "";
        txtOrderPlacedDate.Text = "";
        chkOrderVerification.Checked = false;
        txtProductQuantity.Text = "";
        txtUnitPrice.Text = "";
        txtShippingDate.Text = "";
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //clear the boxes
        txtOrderID.Text = "";
        txtOrderPlacedDate.Text = "";
        chkOrderVerification.Checked = false;
        txtProductQuantity.Text = "";
        txtUnitPrice.Text = "";
        txtShippingDate.Text = "";
        lblError.Text = "";
    }

    protected void btnOrderList_Click(object sender, EventArgs e)
    {
        //redirect to list page
        Response.Redirect("OrdersList.aspx");
    }
}