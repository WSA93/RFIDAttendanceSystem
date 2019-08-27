using System;
using System.Web.UI.WebControls;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        User userObj = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            showUser.DataSource = userObj.ViewUser("-1");
            showUser.DataBind();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            LinkButton arg = (LinkButton)(sender);
            userObj.DeleteUser(arg.CommandArgument);
            Response.Redirect("~/Admin/Users.aspx");
        }
    }
}