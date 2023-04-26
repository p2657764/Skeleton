using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStock Stock = new clsStock();
        //capture the product name
        Stock.StockName = txtProductName.Text;
        Stock.StockColour = txtColour.Text;
        Stock.UnitPrice = Convert.ToInt32(txtUnitPrice.Text); 
        Stock.StockNo = Convert.ToInt32(txtStockQuantity.Text);
        Stock.DateAdded = Convert.ToDateTime(txtDateGenerated.Text);
        Stock.Active = chkInStock.Checked;
        //store the stock in the session object
        Session["Stock"] = Stock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

}