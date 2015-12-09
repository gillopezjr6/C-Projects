<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebAppDemo.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <p>Signup Page</p>

     <a href="Default.aspx">Home</a> <a href="#">Signup</a> <a href="Login.aspx">Login</a>
    <form id="form1" runat="server">
    <div>
    <p>First Name</p>
    <asp:TextBox ID="firstnameTextBox" Text="" runat="server" />
    <p>Last Name</p>
    <asp:TextBox ID="lastnameTextBox" Text="" runat="server" />
    <p>Email</p>
    <asp:TextBox ID="emailTextBox" Text="" runat="server" />
    <p>Phone Number</p>
    <asp:TextBox ID="phonenumberTextBox" Text="" runat="server" />
    <p>User Name</p>
    <asp:TextBox ID="usernameTextBox" Text="" runat="server" />
    <p>Password</p>
    <asp:TextBox ID="passwordTextBox" Text="" runat="server" />
    <asp:Button ID="registerButton" Text="REGISTER" runat="server" OnClick="registerEventMethod" />

    </div>
    </form>
</body>
</html>
