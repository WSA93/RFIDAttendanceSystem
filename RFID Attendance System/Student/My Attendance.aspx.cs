using System;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Student
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Attendance attendanceObj = new Attendance();
            showattendance.DataSource = attendanceObj.ViewAttendance("12345",Request.QueryString["cId"]);
            showattendance.DataBind();
                
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}