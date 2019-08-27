<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="RFID_Attendance_System.Admin.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Users
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row mt-2">
            <table class="table table-striped">
                <thead class="bg-info text-light">
                    <tr>
                        <th>RFID</th>
                        <th>Full Name</th>
                        <th>Status</th>
                        <th>Enrollment</th>
                        <th>Edit User</th>
                        <th>Delete User</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="showUser">
                        <ItemTemplate>
                            <tr>
                                <td><asp:Label runat="server" Text='<%#Eval("UserRFID")%>'></asp:Label></td>
                                <td><asp:Label runat="server" Text='<%#Eval("UserName")%>'></asp:Label></td>
                                <td><asp:Label runat="server" Text='<%#Eval("UserStatus")%>'></asp:Label></td>
                                <td><asp:HyperLink runat="server" NavigateUrl='<%#Eval("UserRFID","~/Admin/Enrollments.aspx?uId={0}")%>'><i class="fas fa-2x fa-info-circle text-success"></i></asp:HyperLink></td>
                                <td><asp:HyperLink runat="server" NavigateUrl='<%#Eval("UserID","~/Admin/Add Users.aspx?id={0}")%>'><i class="fas fa-2x fa-edit"></i></asp:HyperLink></td>
                                <td><asp:LinkButton runat="server" ID="delete" Text="Delete" OnClick="delete_Click" CommandArgument='<%#Eval("UserID")%>'><i class="fas fa-2x fa-trash-alt text-danger"></i></asp:LinkButton> </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
    </asp:Content>


