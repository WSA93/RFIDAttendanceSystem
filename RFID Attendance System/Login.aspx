<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RFID_Attendance_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Assets/styles/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-6 mr-auto ml-auto" style="margin-top:120px;">
            <div class="card border-primary">
                <div class="card-header" style="background-color: #e3f2fd;">Login</div>
                <div class="card-body text-primary">

                    <div class="form-group">
                        <label class="text-info">RFID</label>
                        <asp:TextBox ID="RFID" runat="server" Required class="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label class="text-info">Password</label>
                        <asp:TextBox ID="Password" TextMode="Password" runat="server" Required class="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group text-center">
                        <asp:Button ID="login" runat="server" class="btn btn-outline-info" Text="Login" OnClick="login_Click" />
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
