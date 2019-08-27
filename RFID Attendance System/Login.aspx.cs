using System;
using RFID_Attendance_System.Classes;
using System.Web.Security;

namespace RFID_Attendance_System
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            User loginObj = new User();
            int userType = loginObj.Authentication(RFID.Text, Password.Text);
            Session["user"] = RFID.Text;

            FormsAuthentication.SetAuthCookie(RFID.Text, false);
           
            if (userType == 1)
            {
                Response.Redirect("~/Admin/Add Users.aspx");
            }
            else if(userType == 2)
            {
                Response.Redirect("~/Faculty/My Courses.aspx");
            }
            else if(userType == 3)
            {
                Response.Redirect("~/Student/My Courses.aspx");
            }
        }
    }
}