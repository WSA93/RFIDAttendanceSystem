using System;
using System.Web.UI.WebControls;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Faculty
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        CourseClasses sessionsObj = new CourseClasses();

        protected void Page_Load(object sender, EventArgs e)
        {    
            showclasses.DataSource = sessionsObj.ViewClasses(Request.QueryString["cId"], "-1");
            showclasses.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void edit_Click(object sender, EventArgs e)
        {
            
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton)sender;
            sessionsObj.DeleteClass(link.CommandArgument);
            Response.Redirect("~/Faculty/Sessions.aspx?cId=" + Request.QueryString["cId"]);
        }

        protected void gotoaddsession_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Faculty/Add Session.aspx?cId=" + Request.QueryString["cId"]);
        }
    }
}