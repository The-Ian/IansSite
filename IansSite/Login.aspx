<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IansSite.Login" %>

<!DOCTYPE html>
<link href="LoginPageCSS.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            width: 343px;
            height: 249px;
        }
        .auto-style2 {}
    </style>
    
</head>
<body class="auto-style1" style="background-color:azure">
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center;">Login Form</h2>
        </div>

        <div>Username<br />
            <div class="inptbox";>
                &nbsp;<asp:TextBox ID="userTB" runat="server" placeholder="Enter Username"></asp:TextBox>
            </div>
         
            <br />
        
            
            Password<br />
            <div class="inptbox";>
                &nbsp;<asp:TextBox ID="passTB" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
            </div>

         </div>

        <div class="btn">
        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Login" BackColor="#009933"  CssClass="auto-style2" ForeColor="White" Width="302px" />
        </div>
        <br />
        <a href="Register.aspx">Register</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="Default.aspx">Continue Without Logging In</a>
    </form>
</body>
</html>
