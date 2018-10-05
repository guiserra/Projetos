<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriarUsu.aspx.cs" Inherits="Site.Pages.CriarUsu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Criar Usuário</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Criar novo Usuário</h3>
                <br />

                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor, digite um nome válido" ForeColor="Red" />
                <br /><br />

                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Por favor, digite um email válido" ForeColor="Red" />
                <br /><br />

                <asp:TextBox type="password" ID="txtSenha" runat="server" placeholder="Senha" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Por favor, digite uma senha válido" ForeColor="Red" />
                <br /><br />

                <p><asp:Label ID="lblMensagem" runat="server" /></p>

                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarUsuario" />
                
                <a href="/Pages/ListaUsu.aspx" class="btn btn-default btn-lg">Voltar</a>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
