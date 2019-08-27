<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Add Users.aspx.cs" Inherits="RFID_Attendance_System.Admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Add Users
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="col-6 mr-auto ml-auto mt-3">
        <div class="card border-primary">
            <div class="card-header" style="background-color: #e3f2fd;">Add Users</div>
            <div class="card-body text-primary">
                <div class="form-group">
                    <label class="text-info">RFID No.</label>
                    <asp:TextBox ID="RFIDNo" runat="server" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Full Name</label>
                    <asp:TextBox ID="UserName" runat="server" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Email</label>
                    <asp:TextBox ID="UserEmail" runat="server" TextMode="Email" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Password</label>
                    <asp:TextBox ID="UserPassword" runat="server" TextMode="Password" Required class="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="text-info">Status</label>
                    <asp:DropDownList ID="UserStatus" runat="server" class="form-control">
                        <asp:ListItem>Student</asp:ListItem>
                        <asp:ListItem>Faculty</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="AddUserButton" runat="server" class="btn btn-outline-info" Text="Save" OnClick="AddUserButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
