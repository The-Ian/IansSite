<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="IansSite.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style6 {
            z-index: 1;
            left: 48px;
            top: 121px;
            position: absolute;
            margin-top: 0px;
        }
        .auto-style7 {
            z-index: 1;
            left: 50px;
            top: 229px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 67px;
            top: 189px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 49px;
            top: 87px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 67px;
            top: 44px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 220px;
            top: 154px;
            position: absolute;
            height: 16px;
            width: 82px;
        }
        .auto-style12 {
            z-index: 1;
            left: 219px;
            top: 199px;
            position: absolute;
        }
        .auto-style13 {
            width: 75px;
            height: 23px;
        }
        .auto-style14 {
            height: 23px;
        }
        .auto-style15 {
            z-index: 1;
            left: 620px;
            top: 19px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="Login" runat="server" style="text-align:left" NavigateUrl="~/Login.aspx" Visible="False">Login</asp:HyperLink>
            <asp:Label ID="User" runat="server" style="text-align:left" Text="Label"  Visible="False"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" CssClass="auto-style1" Height="264px" Width="300px" BorderColor="#CC6600" BorderStyle="Ridge">
            <asp:TextBox ID="resultTB" runat="server" CssClass="auto-style7" ReadOnly="True"></asp:TextBox>
            <asp:Label ID="runningTotalLbl" runat="server" CssClass="auto-style8" Text="Running Total"></asp:Label>
            <asp:Label ID="numberEntryLbl" runat="server" CssClass="auto-style9" Text="Enter Numbers Here"></asp:Label>
            <asp:TextBox ID="entryTB" runat="server" CssClass="auto-style6"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style10" Text="Ian's Super Useful Calculator"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style11">
                <asp:ListItem Value="Add"></asp:ListItem>
                <asp:ListItem>Subtract</asp:ListItem>
                <asp:ListItem>Multiply</asp:ListItem>
                <asp:ListItem>Divide</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style12" OnClick="Button1_Click" Text="Calculate" />
            <asp:Button ID="Button2" runat="server" BackColor="White" BorderStyle="None" CssClass="auto-style15" OnClick="Button2_Click" Text="Logout" />
        </asp:Panel>
        
                <a href="Default.aspx">Main Page</a>
                <a href="Info.aspx">Info Page</a>
                <a href="Sandbox.aspx">Sandbox</a>
    </form>
</body>
</html>
