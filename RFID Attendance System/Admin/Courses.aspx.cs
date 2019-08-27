using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        Course coursesObj = new Course();
        protected void Page_Load(object sender, EventArgs e)
        {
            showCourses.DataSource = coursesObj.ViewCourseList("-1");
            showCourses.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton)(sender);
            coursesObj.DeleteCourse(link.CommandArgument);
            Response.Redirect("~/Admin/Courses.aspx");
        }
    }
}