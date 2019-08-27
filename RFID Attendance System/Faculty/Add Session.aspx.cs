using System;
using RFID_Attendance_System.Classes;
using System.Data;

namespace RFID_Attendance_System.Faculty
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        CourseClasses addSessionsObj = new CourseClasses();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["classId"] != null)
            {
                DataTable classData = new DataTable();
                classData = addSessionsObj.ViewClasses("-1" ,Request.QueryString["classId"]);
               
                string date = classData.Rows[0]["ClassDate"].ToString();
                date = DateTime.Parse(date).ToString("dd-MM-yyyy");
                string startTime = classData.Rows[0]["ClassStartTime"].ToString();
                string endTime = classData.Rows[0]["ClassEndTime"].ToString();

                if (!IsPostBack)
                {
                    Day.Text = date.Substring(0, 2);
                    Month.Text = date.Substring(3, 2);
                    Year.Text = date.Substring(6, 4);

                    starthour.Text = startTime.Substring(0, 2);
                    startmin.Text = startTime.Substring(3, 2);

                    endhour.Text = endTime.Substring(0, 2);
                    endmin.Text = endTime.Substring(3, 2);
                }
            }
        }

        protected void AddSession_Click(object sender, EventArgs e)
        {
            string date = Year.SelectedValue + "-" + Month.SelectedValue + "-" + Day.SelectedValue;
            string startTime = starthour.SelectedValue + ":" + startmin.SelectedValue;
            string endTime = endhour.SelectedValue + ":" + endmin.SelectedValue;

            if(Request.QueryString["cId"] != null && Request.QueryString["classId"] == null)
            {
                addSessionsObj.AddClass(Request.QueryString["cId"], date, startTime, endTime);
                
                Enrollment enrollmentObj = new Enrollment();
                DataTable students = new DataTable();
                students = enrollmentObj.SelectStudentsInCourse(Request.QueryString["cId"]);

                Attendance attendanceObj = new Attendance();
                for (int i = 0; i < students.Rows.Count; ++i)
                {
                    attendanceObj.AddAttendance(students.Rows[i][0].ToString());
                }

                Response.Redirect("~/Faculty/Sessions.aspx?cId=" + Request.QueryString["cId"]);
            }
            else
            {
                addSessionsObj.UpdateClass(Request.QueryString["classId"], date, startTime, endTime);
                Response.Redirect("~/Faculty/Sessions.aspx?cId=" + Request.QueryString["cId"]);
            }
        }
    }
}