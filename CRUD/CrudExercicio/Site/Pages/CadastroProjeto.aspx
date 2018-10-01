<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroProjeto.aspx.cs" Inherits="Site.Pages.CadastrarProjeto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de Projeto</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Projeto</h3>
                    <br />
                    <div class="form-group">
                        Nome:
                        <br />
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Digite o nome do projeto" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite o nome do projeto" ForeColor="Red" />
                        <br />
                        <br />
                        Tipo:
                        <br />
                        <asp:TextBox ID="txtTipo" runat="server" placeholder="Informe o tipo do projeto" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredTipo" runat="server" ControlToValidate="txtTipo" ErrorMessage="Digite o tipo do projeto" ForeColor="Red" />
                        <br />
                        <br />

                        <p>
                            <asp:Label ID="lblMessagem" runat="server" />
                        </p>

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarProjeto" />
                        <a href="/Default.aspx" class="btn btn-danger">Cancelar</a>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
