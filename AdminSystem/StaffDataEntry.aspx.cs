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

        //create a new instance of clsStaff
        ClsStaff staff = new ClsStaff();
        //capture things lad
        String Name = txtName.Text;
        String staffRole = txtRole.Text;
        String StaffWage = txtStaffWage.Text;
        String staffDepartment = txtDepartment.Text;
        String startDate = txtStartDate.Text;
        String Error = "";
        String StaffNo = txtStaffId.Text;

        Error = staff.Valid(StaffNo, StaffWage, staffRole, staffDepartment, startDate);
        if (Error == "")
        {
            //capture staff no
            //staff.StaffNo = StaffNo;
            //capture name
            staff.Name = Name;
            //capture wage
            //staff.StaffWage = StaffWage;
            //capture department
            staff.Department = staffDepartment;
            //capture start date
            staff.StartDate = Convert.ToDateTime(startDate);
            //capture update catalogue
            staff.UpdateCatalogue = chkUpdateCatalogue.Checked;
            //capture role
            staff.Role = staffRole;
            //store address in sess
            Session["StaffNo"] = staff;
            //redirect
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }







    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        ClsStaff staff = new ClsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = staff.Find(StaffNo);
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
}
