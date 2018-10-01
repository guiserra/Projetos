<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Home</title>
    <link rel="stylesheet" href="../Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="container">
                <h1>Bem-Vindo!</h1>
                <h2>Projeto CRUD - Controle de Projeto</h2>
                <p>
                    <asp:Label ID="lblMensagem" runat="server" CssClass="danger" />
                </p>
                <div>
                    Selecione a opção desejada:
                    <asp:DropDownList ID="ddlUsuario" runat="server">
                        <asp:ListItem Value="0" Text=" " />
                        <asp:ListItem Value="1" Text="Cadastrar Usuario" />
                        <asp:ListItem Value="2" Text="Listar Usuarios" />
                        <asp:ListItem Value="0" Text=" " />
                        <asp:ListItem Value="3" Text="Cadastrar Projeto" />
                        <asp:ListItem Value="4" Text="Visualizar Projeto" />
                    </asp:DropDownList>
                    <asp:Button ID="btnUsuario" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnAcessarUsuario" />
                </div>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
