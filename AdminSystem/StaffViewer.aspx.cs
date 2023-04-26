using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of ClsStaff
        ClsStaff staff = new ClsStaff();
        //get the data from session object
        staff = (ClsStaff)Session["Staff"];
        //display the staff name for the entry
        Response.Write(staff.Name);
    }
}