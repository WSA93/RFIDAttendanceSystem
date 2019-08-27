using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RFID_Attendance_System.Classes
{
    public class Attendance
    {
        private string connection;
        private SqlConnection con;

        public Attendance()
        {
            connection = ConfigurationManager.ConnectionStrings["ASDB"].ConnectionString;
            con = new SqlConnection(connection);
        }

        public void AddAttendance(string RFID)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAddAttendance";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int MarkAttendance(string RFID)
        {
            SqlCommand cmd = new SqlCommand();
            int rowsAffected = -1; 
            cmd.CommandText = "spMarkAttendance";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            con.Open();
            rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }

        public DataTable ViewAttendance(string RFID, string CourseCode)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewAttendance";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@CourseCode", CourseCode);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }
    }
}