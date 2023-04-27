using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDepartment_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtUpdateCatalogue_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of ClsStaff
        ClsStaff staff = new ClsStaff();
        //capture the name
        staff.Name = txtName.Text;
        //store the name in session object
        Session["Staff"] = staff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }







    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        ClsStaff staff = new ClsStaff();
        //variable to store the primary key
        Int32 StaffId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = staff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffId.Text = staff.StaffNo.ToString();
            txtStaffWage.Text = staff.StaffWage.ToString();
            txtDepartment.Text = staff.Department;
            txtName.Text = staff.Name;
            txtStartDate.Text = staff.StartDate.ToString();
            txtRole.Text = staff.Role;
            chkUpdateCatalogue.Checked = staff.Active;
            


        }

    }

    protected void txtRole_TextChanged(object sender, EventArgs e)
    {

    }
}
