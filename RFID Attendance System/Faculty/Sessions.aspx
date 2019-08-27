<%@ Page Title="" Language="C#" MasterPageFile="~/Faculty/Faculty.Master" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="RFID_Attendance_System.Faculty.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sessions
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-2">
            <div class="col-12">
                <asp:Button runat="server" ID="gotoaddsession" Text="Add Session" OnClick="gotoaddsession_Click" class="btn btn-fill btn-info"/>
            </div>
        </div>
        <div class="row mt-2">
            <table class="table table-striped">
                <thead class="bg-info text-light">
                    <tr>
                        <th>Date</th>
                        <th>Start Time</th>
                        <th>End Time</th>
                        <th>Edit Session</th>
                        <th>Delete Session</th>
                    </tr>
                </thead>
                <tbody>
                   <asp:Repeater runat="server" ID="showclasses">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text='<%#((DateTime)Eval("ClassDate")).ToShortDateString()%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("ClassStartTime")%>'></asp:Label></td>
                                    <td>
                                        <asp:Label runat="server" Text='<%#Eval("ClassEndTime")%>'></asp:Label></td>
                                    <td>
                                        <asp:HyperLink runat="server" ID="edit" Text="Delete" OnClick="edit_Click" NavigateUrl='<%#Eval("ClassID","~/Faculty/Add Session.aspx?classId={0}&cId=" + Request.QueryString["cId"])%>'><i class="fas fa-2x fa-edit"></i></asp:HyperLink>
                                    </td>
                                    <td>
                                        <asp:LinkButton runat="server" ID="delete" Text="Delete" OnClick="delete_Click" CommandArgument='<%#Eval("ClassID")%>'><i class="fas fa-2x fa-trash-alt text-danger"></i></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
