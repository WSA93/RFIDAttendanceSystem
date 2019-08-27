<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mark Attendance.aspx.cs" Inherits="RFID_Attendance_System.temp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Assets/styles/bootstrap.min.css" rel="stylesheet" />
    <title>Mark Attendance</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-6 mr-auto ml-auto" style="margin-top: 15%;">
            <div class="card border-primary">
                <div class="card-header" style="background-color: #e3f2fd;">Mark Attendance</div>
                <div class="card-body text-primary">

                    <div class="form-group">
                        <label class="text-info">Student RFID</label>
                        <asp:Panel ID="panel" runat="server" DefaultButton="button">
                            <asp:TextBox ID="RFID" OnTextChanged="RFID_TextChanged" runat="server" Required class="form-control"></asp:TextBox>
                            <asp:Button ID="button" runat="server" Visible="false" OnClick="button_Click" />
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
