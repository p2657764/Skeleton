using ClassLibrary;
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
        //create a new instance of clsStock
        clsStock Stock = new clsStock();
        //get the data from the session object
        Stock = (clsStock)Session["Stock"];
        //display the product name for this entry
        Response.Write(Stock.StockName);
        Response.Write(Stock.StockColour);
        Response.Write(Stock.UnitPrice);
        Response.Write(Stock.StockNo);
        Response.Write(Stock.DateAdded);
        Response.Write(Stock.Active);
    }
}