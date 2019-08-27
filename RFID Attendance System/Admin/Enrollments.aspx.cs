using System;
using System.Web.UI.WebControls;
using RFID_Attendance_System.Classes;

namespace RFID_Attendance_System.Admin
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        Enrollment enrollmentsObj = new Enrollment();
        Course courseObj = new Course();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["uId"] != null)
            {
                fromCourse.Visible = false;
                showEnroll.DataSource = enrollmentsObj.ViewEnrollment(Request.QueryString["uId"], "-1");
                showEnroll.DataBind();

                if (!IsPostBack)
                {
                    courseList.DataTextField = "Course";
                    courseList.DataValueField = "Course";
                    courseList.DataSource = courseObj.SelectCourseNames();
                    courseList.DataBind();
                }
            }
            else
            {
                fromUser.Visible = false;
                showUser.DataSource = enrollmentsObj.ViewEnrollment("-1", Request.QueryString["cId"]);
                showUser.DataBind();

                if (!IsPostBack)
                {
                    User userObj = new User();
                    userList.DataTextField = "User";
                    userList.DataValueField = "User";
                    userList.DataSource = userObj.SelectUserNames();
                    userList.DataBind();
                }
            }
            
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton)(sender);
            if (Request.QueryString["uId"] != null)
            {
                enrollmentsObj.DeleteEnrollment(Request.QueryString["uId"], link.CommandArgument);
                Response.Redirect("~/Admin/Enrollments.aspx?uId=" + Request.QueryString["uId"]);
            }
            else
            {
                enrollmentsObj.DeleteEnrollment(link.CommandArgument, Request.QueryString["cId"] );
                Response.Redirect("~/Admin/Enrollments.aspx?cId=" + Request.QueryString["cId"]);
            }
            
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["uId"] != null)
            {
                string[] Code = courseList.SelectedValue.Split(',');
                enrollmentsObj.AddEnrollment(Request.QueryString["uId"], Code[0]);
                Response.Redirect("~/Admin/Enrollments.aspx?uId=" + Request.QueryString["uId"]);
            }
            else
            {
                string[] RFID = userList.SelectedValue.Split(',');
                enrollmentsObj.AddEnrollment(RFID[0], Request.QueryString["cId"]);
                Response.Redirect("~/Admin/Enrollments.aspx?cId=" + Request.QueryString["cId"]);
            }
            
        }
    }
}