using System;
using System.Data;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        User addUserObj = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] != null)
            {
                DataTable editUser = new DataTable();
                editUser = addUserObj.ViewUser(Request.QueryString["id"]);

                if (!IsPostBack)
                {
                    RFIDNo.Text = editUser.Rows[0]["UserRFID"].ToString();
                    UserName.Text = editUser.Rows[0]["UserName"].ToString();
                    UserEmail.Text = editUser.Rows[0]["UserEmail"].ToString();
                    UserPassword.Text = editUser.Rows[0]["UserPassword"].ToString();
                    UserStatus.Text = editUser.Rows[0]["UserStatus"].ToString();
                }
            }
            
        }

        protected void AddUserButton_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] == null)
            {
                addUserObj.AddUser(RFIDNo.Text, UserName.Text, UserEmail.Text, UserPassword.Text, UserStatus.Text);
                Response.Redirect("~/Admin/Users.aspx");
            }
            else
            {
                addUserObj.UpdateUser(Request.QueryString["id"], RFIDNo.Text, UserName.Text, UserEmail.Text, UserPassword.Text, UserStatus.Text);
                Response.Redirect("~/Admin/Users.aspx");

            }

            
        }
    }
}