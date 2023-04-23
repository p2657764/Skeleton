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
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo);
        //find the record 
        Found = AnOrder.Find(OrderNo);
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

    protected void btnOK_Click_Click(object sender, EventArgs e)
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

            //capture order placed date
            AnOrder.OrderPlacedDate = Convert.ToDateTime(txtOrderPlacedDate.Text);
            //capture product quantity
            AnOrder.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
            //capture unit price
            AnOrder.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
            //capture shipping date
            AnOrder.ShippingDate = Convert.ToDateTime(txtShippingDate.Text);
            //store customer in session object
            Session["AnOrder"] = AnOrder;
            //redirect to view page
            Response.Write("OrderViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }
   
}