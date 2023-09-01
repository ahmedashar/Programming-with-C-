<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            color:red;
        }
    </style>
</head>
<body>
    <h1>Hello World</h1>

    <h2 id="heading1">Hello World</h2>

    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hello, I'm Ashar Ahmed"></asp:Label>

            <br />


            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br />
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" style="width: 43px; height: 26px;" />

            <br />

            <asp:label ID="Label2" runat="server" Text="HEllo"></asp:label>
        </div>
    </form>
</body>
</html>
