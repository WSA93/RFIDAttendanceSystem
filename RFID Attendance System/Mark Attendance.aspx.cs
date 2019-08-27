using System;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System
{
    public partial class temp : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            RFID.Focus();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Attendance markAtt = new Attendance();
            markAtt.MarkAttendance(RFID.Text);
            RFID.Text = "";
        }

        protected void RFID_TextChanged(object sender, EventArgs e)
        {
            button_Click(sender,e);
        }
    }
}