<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaSprint.aspx.cs" Inherits="Site.Pages.ListaSprint" %>

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
                    <asp:GridView ID="gridSprint" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffff">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Observacoes" HeaderText="Descricao" />
                            <asp:BoundField DataField="Semanas" HeaderText="Duracao" />
                            <asp:BoundField DataField="Status" HeaderText="Status" />
                        </Columns>
                    </asp:GridView>

                    <p class="alert-danger">
                        <asp:Label ID="lblMessagem" runat="server" />
                    </p>

                    <asp:Panel ID="pnlDados" runat="server">
                        <div class="form-group">
                            Nome:
                        <br />
                            <asp:TextBox ID="txtNome" runat="server" placeholder="Digite o Nome" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite seu Nome Completo" ForeColor="Red" />
                            <br />
                            <br />
                            Descricao/Observação:
                        <br />
                            <asp:TextBox ID="txtDescricao" runat="server" placeholder="Digite uma descrição/observação" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredDesc" runat="server" ControlToValidate="txtDescricao" ErrorMessage="Digite uma descricao" ForeColor="Red" />
                            <br />
                            <br />
                            Duração (semana):
                        <br />
                            <asp:TextBox TextMode="Number" ID="txtDuracao" runat="server" placeholder="Digite a duração" Width="45%" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="requiredDur" runat="server" ControlToValidate="txtDuracao" ErrorMessage="Digite a duração" ForeColor="Red" />
                            <br />
                            <br />
                            Status Sprint:
                        <br />
                            Completo: 
                        <asp:CheckBox ID="txtStatus" runat="server" Width="45%" CssClass="checkbox" /> - Status Atual. 
                            <br />
                            <br />
                        </div>


                        <div>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" OnClick="btnEditarSprint" />
                        </div>
                    </asp:Panel>

                    <br />
                    <br />

                    <div>
                        <a href="/Pages/Default.aspx" class="btn btn-default">Voltar</a>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
