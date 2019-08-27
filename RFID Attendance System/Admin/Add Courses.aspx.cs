using System;
using RFID_Attendance_System.Classes;
using System.Data;

namespace RFID_Attendance_System.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Course addCourseObj = new Course();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                DataTable editCourse = new DataTable();
                editCourse = addCourseObj.ViewCourseList(Request.QueryString["id"]);

                if (!IsPostBack)
                {
                    CourseCode.Text = editCourse.Rows[0]["CourseCode"].ToString();
                    CourseName.Text = editCourse.Rows[0]["CourseName"].ToString();
                    CreditHours.Text = editCourse.Rows[0]["CourseCrHr"].ToString();
                }
            }

        }

        protected void AddCourse_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                addCourseObj.AddCourse(CourseCode.Text, CourseName.Text, CreditHours.Text);
                Response.Redirect("~/Admin/Courses.aspx");
            }
            else
            {
                addCourseObj.UpdateCourse(Request.QueryString["id"], CourseCode.Text, CourseName.Text, CreditHours.Text);
                Response.Redirect("~/Admin/Courses.aspx");
            }
        }
    }
}