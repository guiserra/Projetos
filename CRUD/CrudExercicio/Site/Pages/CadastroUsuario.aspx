<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de Usuário</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Usuário</h3>
                    <br />
                    <div class="form-group">
                        Nome:
                        <br />
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Digite o nome completo" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite seu Nome Completo" ForeColor="Red" />
                        <br />
                        <br />
                        Login:
                        <br />
                        <asp:TextBox ID="txtUser" runat="server" placeholder="Digite um nome de usuário" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredUser" runat="server" ControlToValidate="txtUser" ErrorMessage="Digite um Nome de Usuário" ForeColor="Red" />
                        <br />
                        <br />
                        Senha:
                        <br />
                        <asp:TextBox TextMode="Password" ID="txtSenha" runat="server" placeholder="Digite uma senha" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Digite uma Senha" ForeColor="Red" />
                        <br />
                        <br />

                        <p>
                            <asp:Label ID="lblMessagem" runat="server" />
                        </p>

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarUsuario" />
                        <a href="/Default.aspx" class="btn btn-danger">Cancelar</a>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
