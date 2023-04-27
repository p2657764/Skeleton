using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }

    }
    void DisplayStaff()
    {
        clsStaffCollection staff = new clsStaffCollection();
        lstStaffList.DataSource = staff.StaffList;
        lstStaffList.DataValueField = "StaffNo";
        lstStaffList.DataTextField = "Name";
        lstStaffList.DataBind();
    }
}