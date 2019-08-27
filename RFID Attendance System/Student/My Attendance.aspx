<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.Master" AutoEventWireup="true" CodeBehind="My Attendance.aspx.cs" Inherits="RFID_Attendance_System.Student.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    My Attendance
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row mt-2">
            <table class="table table-striped">
                <thead class="bg-info text-light">
                    <tr>
                        <th>Date</th>
                        <th>Start Time</th>
                        <th>End Time</th>
                        <th>Status</th>
                        <th>Timestaamp</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="showattendance">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text='<%#((DateTime)Eval("ClassDate")).ToShortDateString()%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("ClassStartTime")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("ClassEndTime")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("AttendanceStatus")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("AttendanceTime")%>'></asp:Label></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
