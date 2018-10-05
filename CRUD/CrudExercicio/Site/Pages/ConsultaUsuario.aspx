<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consulta de Usuario</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Usuários</h3>

                    Informe o código: 
                    <div class="form-inline">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%" />
                        <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info" OnClick="btnPesquisarUsuario" />
                    </div>
                    <br />
                    <asp:GridView ID="gridUsuario" runat="server" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#999999">
                        <Columns>
                            <asp:BoundField DataField="UsuarioId" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Login" HeaderText="Usuario" />
                            <asp:BoundField DataField="Senha" HeaderText="Senha" />
                        </Columns>
                    </asp:GridView>

                    <p class="alert-danger">
                        <asp:Label ID="lblMessagem" runat="server" />
                    </p>

                    <asp:Panel ID="pnlDados" runat="server">
                        <div class="form-group">
                            Nome:
                        <br />
                            <asp:TextBox ID="txtNome" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite seu Nome Completo" ForeColor="Red" />
                            <br />
                            <br />
                            Login:
                        <br />
                            <asp:TextBox ID="txtUser" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredUser" runat="server" ControlToValidate="txtUser" ErrorMessage="Digite um Nome de Usuário" ForeColor="Red" />
                            <br />
                            <br />
                            Senha:
                        <br />
                            <asp:TextBox TextMode="Password" ID="txtSenha" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredSenha" runat="server" ControlToValidate="txtSenha" ErrorMessage="Digite uma Senha" ForeColor="Red" />
                            <br />
                            <br />
                        </div>


                        <div>
                            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluirUsuario" />
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" OnClick="btnEditarUsuario" />
                        </div>
                    </asp:Panel>

                    <br />
                    <br />

                    <div>
                        <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
