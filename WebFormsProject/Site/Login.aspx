<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h1>Acesso do Usuario</h1>
                <br /><br />
                
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="35%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Por favor, digite um Email" ForeColor="Red" />

                <asp:TextBox type="password" ID="txtSenha" runat="server" placeholder="Senha" Width="35%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Por favor, digite uma Senha" ForeColor="Red" />
                
                <p><asp:Label ID="lblMensagem" runat="server" /></p>

                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success btn-lg" OnClick="btnLogar" />
                <a href="/Pages/CadastroUsu.aspx" class="btn btn-default btn-lg">Cadastrar</a>
            </div>
        </div>
    </form>
</body>
</html>
