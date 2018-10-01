<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaSprint.aspx.cs" Inherits="Site.Pages.ConsultaSprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sprint</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Sprint</h3>

                    Informe o código: 
                    <div class="form-inline">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%" />
                        <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info" OnClick="btnPesquisarSprint" />
                    </div>
                    <br />
                    <asp:GridView ID="gridSprint" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#999999">
                        <Columns>
                            <asp:BoundField DataField="SprintId" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Descricao" HeaderText="Descricao" />
                            <asp:BoundField DataField="Duracao" HeaderText="Duracao" />
                            <asp:BoundField DataField="DtInicio" HeaderText="Data de Inicio" />
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
                            Descricao/Observação:
                        <br />
                            <asp:TextBox ID="txtDescricao" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredDesc" runat="server" ControlToValidate="txtDescricao" ErrorMessage="Digite uma descricao" ForeColor="Red" />
                            <br />
                            <br />
                            Duração (semana):
                        <br />
                            <asp:TextBox TextMode="Number" ID="txtDuracao" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredDur" runat="server" ControlToValidate="txtDuracao" ErrorMessage="Digite a duração" ForeColor="Red" />
                            <br />
                            <br />
                            Data de Início:
                        <br />
                            <asp:TextBox TextMode="DateTime" ID="txtDataInicio" runat="server" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredDtInicio" runat="server" ControlToValidate="txtDataInicio" ErrorMessage="Selecione a data de inicio" ForeColor="Red" />
                            <br />
                            <br />
                        </div>


                        <div>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" OnClick="btnEditarUsuario" />
                        </div>
                    </asp:Panel>

                    <br />
                    <br />

                    <div>
                        <a href="/Pages/ConsultaProjeto.aspx" class="btn btn-default">Voltar</a>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
