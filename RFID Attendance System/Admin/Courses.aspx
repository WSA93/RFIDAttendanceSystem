<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="RFID_Attendance_System.Admin.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Courses
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row mt-2">
            <table class="table table-striped "> 
                <thead class="bg-info text-light">
                    <tr>
                        <th>Course Code</th>
                        <th>Course Name</th>
                        <th>Course CrHr</th>
                        <th>Enroll Student</th>
                        <th>Edit Course</th>
                        <th>Delete Course</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="showCourses">
                        <ItemTemplate>
                            <tr>
                                <td><asp:Label runat="server" Text='<%#Eval("CourseCode")%>'></asp:Label></td>
                                <td><asp:Label runat="server" Text='<%#Eval("CourseName")%>'></asp:Label></td>
                                <td><asp:Label runat="server" Text='<%#Eval("CourseCrHr")%>'></asp:Label></td>
                                <td><asp:HyperLink runat="server" NavigateUrl='<%#Eval("CourseCode","~/Admin/Enrollments.aspx?cId={0}")%>'><i class="fas fa-2x fa-info-circle text-success"></i></asp:HyperLink></td>
                                <td><asp:HyperLink runat="server" NavigateUrl='<%#Eval("Course","~/Admin/Add Courses.aspx?id={0}")%>'><i class="fas fa-2x fa-edit"></i></asp:HyperLink></td>
                                <td><asp:LinkButton runat="server" ID="delete" Text="Delete" OnClick="delete_Click" CommandArgument='<%#Eval("Course")%>'><i class="fas fa-2x fa-trash-alt text-danger"></i></asp:LinkButton> </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>

</asp:Content>
