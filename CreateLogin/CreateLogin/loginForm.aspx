<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="CreateLogin.loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
       <p>Login Page</p>
     <a href="Default.aspx">Home</a> <a href="Registration.aspx">Signup</a> <a href="#">Login</a>
    <form id="form1" runat="server">
    <div>
        <p>Enter Username</p>
        <asp:TextBox ID="usernameTextBox" Text="" runat="server" />
        <p>Enter Password</p>
        <asp:TextBox ID="passwordTextBox" Text="" runat ="server" />

        <asp:Button ID="submitButton" Text="Log in" runat ="server" OnClick ="submitEventMethod" />
    </div>
    </form>
</body>
</html>
