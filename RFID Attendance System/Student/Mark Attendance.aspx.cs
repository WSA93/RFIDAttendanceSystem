using System;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Student
{
    public partial class Mark_Attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RFID.Text = "";
            RFID.Focus();

            
        }

        protected void RFID_TextChanged(object sender, EventArgs e)
        {
            int rowsAffected = -1;
            Attendance markAtt = new Attendance();
        
            rowsAffected = markAtt.MarkAttendance(RFID.Text);
            if (rowsAffected == 1)
            {
                success.Text = "Attendance Marked Successfully!";
            }
            else if (rowsAffected == 0)
            {
                failure.Text = "Sorry You Don't Have A Class!";
            }
            else if (rowsAffected == -1)
            {
                failure.Text = "Sorry";
            }
        }
    }
}