<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroProj.aspx.cs" Inherits="Site.Pages.Scripts.CadastroProj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Projeto</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Cadastrar Projeto</h3>
                <br />

                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome do Projeto" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor, digite um nome de projeto válido" ForeColor="Red" />
                <br /><br />

                <p><asp:Label ID="lblMensagem" runat="server" /></p>

                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarProj" />
                <a href="/Pages/Default.aspx" class="btn btn-default btn-lg">Voltar</a>

            </div>
        </div>
    </div>
    </form>
</body>
</html>
