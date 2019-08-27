using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RFID_Attendance_System.Classes
{
    public class Course
    {
        private string connection;
        private SqlConnection con;

        public Course()
        {
            connection = ConfigurationManager.ConnectionStrings["ASDB"].ConnectionString;
            con = new SqlConnection(connection);
        }

        public void AddCourse(string Code, string Name, string CrHr)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAddCourse";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@CrHr", CrHr);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateCourse(string Id, string Code, string Name, string CrHr)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spUpdateCourse";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Code", Code);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@CrHr", CrHr);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCourse(string Id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spDeleteCourse";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ViewCourseList(string Id)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewCourseList";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }

        public DataTable SelectCourseNames()
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spSelectCourseNames";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }

        public DataTable ViewFacultyCourses(string RFID)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewFacultyCourses";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }
    }
}