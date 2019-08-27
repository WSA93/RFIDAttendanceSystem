<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Add Courses.aspx.cs" Inherits="RFID_Attendance_System.Admin.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Add Courses
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-6 mr-auto ml-auto mt-5">
        <div class="card border-primary">
            <div class="card-header" style="background-color: #e3f2fd;">Add Courses</div>
            <div class="card-body text-primary">

                <div class="form-group">
                    <label class="text-info">Course Code</label>
                    <asp:TextBox ID="CourseCode" runat="server" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Course Name</label>
                    <asp:TextBox ID="CourseName" runat="server" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Credit Hours</label>
                    <asp:DropDownList ID="CreditHours" runat="server" class="form-control">
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="AddCourse" runat="server" class="btn btn-outline-info" Text="Save" OnClick="AddCourse_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
