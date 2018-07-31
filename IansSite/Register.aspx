<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="IansSite.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
.inptbox {
    margin-top: 10px;
}

.btn {
    background-color:aliceblue;
    width: 327px;
    margin-top: 10px;
}
        .auto-style1 {
            width: 327px;
            height: 217px;
        }
        .auto-style2 {
            height: 326px;
        }
    </style>
</head>
<body class="auto-style2" style="background-color: azure">
    <form id="form2" runat="server">
        <div>
            <h2 style="text-align:center; width: 328px;">Register Form</h2>
        </div>

        <div class="auto-style1">Username<br />
            <div class="inptbox";>
                &nbsp;<asp:TextBox ID="userTB" runat="server" placeholder="Enter Username"></asp:TextBox>
            </div>
         
            <br />
        
            
            Password<br />
            <div class="inptbox";>
                &nbsp;<asp:TextBox ID="passTB" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
            </div>

            <br />

            Confirm Password<br />
            <div class="inptbox";>
                &nbsp;<asp:TextBox ID="conpassTB" runat="server" placeholder="Enter Password Again" TextMode="Password"></asp:TextBox>
            </div>
         </div>

        <div class="btn">
        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Register" BackColor="#009933"  CssClass="auto-style2" ForeColor="White" Width="331px" Height="24px" />
            <br />
        </div>
        <a href="Default.aspx">Continue Without Registering</a>
    </form>
    
</body>
</html>
