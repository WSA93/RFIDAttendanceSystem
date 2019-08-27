using System.Data;
using System.Data.SqlClient;
using System.Configuration;
    
namespace RFID_Attendance_System.Classes
{
    public class Enrollment
    {
        private string connection;
        private SqlConnection con;

        public Enrollment()
        {
            connection = ConfigurationManager.ConnectionStrings["ASDB"].ConnectionString;
            con = new SqlConnection(connection);
        }

        public void AddEnrollment(string RFID, string Code)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAddEnrollment";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Code", Code);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteEnrollment(string RFID, string Code)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spDeleteEnrollment";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Code", Code);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ViewEnrollment(string RFID, string Code)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewEnrollment";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Code", Code);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }

        public DataTable SelectStudentsInCourse(string CourseCode)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spSelectStudentsInCourse";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseCode", CourseCode);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }
    }
}