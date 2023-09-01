<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>About Page</h1>

            <asp:Image ID="Image1" runat="server" ImageUrl="Capture.PNG" Width="400"/>

            <br />

            <label>Username</label>
           

            <asp:Button ID="Button1" runat="server" Text="ChangeImage" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
