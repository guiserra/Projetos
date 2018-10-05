<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaProjeto.aspx.cs" Inherits="Site.Pages.ConsultarProjeto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consulta de Projeto</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Projetos</h3>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" CssClass="alert-danger" />
                    </p>

                    Informe o código: 
                    <div class="form-inline">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%" />
                        <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info" OnClick="btnPesquisarProjeto" />
                    </div>
                    <br />
                    <div class="dropdown">
                        Selecione a opção desejada:
                    <asp:DropDownList ID="ddlProjeto" runat="server">
                        <asp:ListItem Value="0" Text=" " />
                        <asp:ListItem Value="1" Text="Cadastrar Sprint" />
                        <asp:ListItem Value="2" Text="Listar Sprint" />
                    </asp:DropDownList>
                        <asp:Button ID="btnSprint" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnAcessarSprint" />
                    </div>
                    <asp:GridView ID="gridProjeto" runat="server" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#999999">
                        <Columns>
                            <asp:BoundField DataField="ProjetoId" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
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
                            <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite o Nome" ForeColor="Red" />
                            <br />
                            <br />
                            Tipo:
                        <br />
                            <asp:TextBox ID="txtTipo" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredTipo" runat="server" ControlToValidate="txtTipo" ErrorMessage="Digite um Tipo" ForeColor="Red" />
                            <br />
                            <br />
                        </div>


                        <div>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" OnClick="btnEditarProjeto" />
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
