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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order id for this entry
        Response.Write(AnOrder.OrderID);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable o store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order 

        //store the order id in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page 
        Response.Redirect("OrderDataEntry.aspx");
    }

}