<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.Master" AutoEventWireup="true" CodeBehind="My Courses.aspx.cs" Inherits="RFID_Attendance_System.Student.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    My Courses
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-2">
            <div class="col-12 h5 ">My Courses</div>
        </div>

        <asp:Repeater runat="server" ID="mycourses">
            <ItemTemplate>
                <asp:HyperLink runat="server" NavigateUrl='<%#Eval("CourseCode","~/Student/My Attendance.aspx?cId={0}") %>' style="text-decoration: none;">
                    <div class="row mt-3">
                        <div class="col-8 m-auto p-3 shadow">
                            <h3 class="text-center"><asp:Label runat="server" Text='<%#Eval("CourseName")%>'></asp:Label></h3>
                        </div>
                    </div>
                </asp:HyperLink>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
