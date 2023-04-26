using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        clsStock AStock = new clsStock();
        clsCustomer ACustomer = new clsCustomer();
        AnOrder = (clsOrder)Session["AnOrder"];
        string NewLine = ("\n");
        Response.Write(AnOrder.OrderID + NewLine);
        Response.Write(AnOrder.OrderVerification + NewLine);
        Response.Write(AnOrder.OrderPlacedDate + NewLine);
        Response.Write(AnOrder.ShippingDate + NewLine);
        Response.Write(AnOrder.ProductQuantity + NewLine);
        Response.Write(AnOrder.UnitPrice + NewLine);
        Response.Write(AStock.ProductID + NewLine);
        Response.Write(ACustomer.CustomerID + NewLine);

    }
}