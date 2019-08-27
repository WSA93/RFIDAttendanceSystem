using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RFID_Attendance_System.Classes
{
    public class User
    {
        private string connection;
        private SqlConnection con;

        public User()
        {
            connection = ConfigurationManager.ConnectionStrings["ASDB"].ConnectionString;
            con = new SqlConnection(connection);
        }

        public void AddUser(string RFID, string Name, string Email, string Password, string Status)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAddUser";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Status", Status);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateUser(string Id, string RFID, string Name, string Email, string Password, string Status)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spUpdateUser";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Status", Status);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteUser(string Id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spDeleteUser";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ViewUser(string Id)
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spViewUserList";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }

        public DataTable SelectUserNames()
        {
            DataTable dbData = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spSelectUserNames";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = cmd;
            adapter.Fill(dbData);
            return dbData;
        }

        public int Authentication(string RFID, string Password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spAuthentication";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RFID", RFID);
            cmd.Parameters.AddWithValue("@Password", Password);
            con.Open();
            int returnCode = (int)cmd.ExecuteScalar();
            con.Close();
            return returnCode;
        }
    }

}