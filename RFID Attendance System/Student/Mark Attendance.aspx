
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mark Attendance.aspx.cs" Inherits="RFID_Attendance_System.Student.Mark_Attendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Assets/styles/bootstrap.min.css" rel="stylesheet" />
    <title>Mark Attendance</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-6 mr-auto ml-auto" style="margin-top:15%;">
        <div class="card border-primary">
            <div class="card-header" style="background-color: #e3f2fd;">Mark Attendance</div>
            <div class="card-body text-primary">

                <div class="form-group">
                    <label class="text-info">Student RFID</label>
                    <%--<asp:TextBox ID="RFID" runat="server" OnTextChanged="RFID_TextChanged" Required class="form-control"></asp:TextBox>--%>
                </div>


                <asp:Panel ID="panel" runat="server" DefaultButton="buton">
                    <asp:TextBox ID="RFID" runat="server" Required class="form-control"></asp:TextBox>
                    <asp:Button ID="button" runat="server"/>
                </asp:Panel>

                <asp:Label runat="server" ID="failure" class="form-text text-danger"></asp:Label>
                <asp:Label runat="server" ID="success" class="form-text text-success text-center"></asp:Label>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
