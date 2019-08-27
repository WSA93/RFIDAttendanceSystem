using System;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Faculty
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Course myCoursesObj = new Course();
            mycourses.DataSource = myCoursesObj.ViewFacultyCourses(Session["user"].ToString());
            mycourses.DataBind();
        }
    }
}