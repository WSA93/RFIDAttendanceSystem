using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RFID_Attendance_System.Classes
{
    public class CourseClasses
    {
        private string connection;
        private SqlConnection con;

        public CourseClasses()
        {
            connection = ConfigurationManager.ConnectionStrings["ASDB"].ConnectionString;
            con = new SqlConnection(connection);
        }

        public void AddClass(string CourseCode, string Date, string StartTime, string EndTime)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAddClass";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseCode", CourseCode);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@StartTime", StartTime);
            cmd.Parameters.AddWithValue("@EndTime", EndTime);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateClass(string ClassId, string Date, string StartTime, string EndTime)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spUpdateClass";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@StartTime", StartTime);
            cmd.Parameters.AddWithValue("@EndTime", EndTime);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteClass(string Id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spDeleteClass";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ViewClasses(string CourseCode, string ClassId)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewClasses";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseCode", CourseCode);
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }
    }
}