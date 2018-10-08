<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalhesProj.aspx.cs" Inherits="Site.Pages.DetalhesProj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Detalhes do Projeto</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <link href="../Assets/css/Exemplo.css" rel="stylesheet" />
</head>
<script src="Script/jquery-1.9.0.min.js"></script>
<script src="Script/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes dos Projetos</h3>

                    Informe o Código do Projeto:
                    <br />
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="20%" />
                    <br />

                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info" OnClick="btnPesquisarProj" />
                    <a href="/Pages/Default.aspx" class="btn btn-default">Voltar</a>
                    <br />
                    <br />
                    <br />
                    <br />

                    <asp:Panel ID="pnlDados" runat="server">
                        Nome do Projeto:
                        <br />
                        <div class="form-inline">
                            <div class="form-group">
                                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%" />

                                <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" CssClass="btn btn-success" OnClick="btnAtualizarProj" />
                                <asp:Button ID="btnExclui" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluirProj" />
                            </div>
                        </div>
                        <br />
                        <br />

                        <h4>Lista de Sprints do Projeto:</h4>
                        <br />
                        <asp:GridView ID="gridSprints" runat="server" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffff">

                            <Columns>
                                <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                <asp:BoundField DataField="Semanas" HeaderText="Duração/Semanas" />
                                <asp:BoundField DataField="Observacoes" HeaderText="Observações" />
                                <asp:BoundField DataField="Status" HeaderText="Status" />
                            </Columns>

                            <RowStyle CssClass="cursor-pointer" />

                        </asp:GridView>

                        <p>
                            <asp:Label ID="lblListaSprint" runat="server" />
                        </p>

                        <br />

                        <div id="botaoDireita">
                            <asp:Button ID="btnNewSprint" runat="server" Text="Adicionar Sprint" CssClass="btn btn-info btn-lg" OnClick="btnNovaSprint" />
                            <asp:Button ID="btnDeleteSprint" runat="server" Text="Remover Sprint" CssClass="btn btn-warning btn-lg" OnClick="btnRemoverSprint" />
                        </div>

                    </asp:Panel>

                    <p class="form-group">
                        <asp:Label ID="lblMensagem" runat="server"/>
                    </p>

                    <asp:Panel ID="pnlSprint" runat="server">
                        Nome da Sprint:
                        <br />
                        <asp:TextBox ID="txtSprintNome" runat="server" placeholder="Digite o Nome" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Digite seu Nome Completo" ForeColor="Red" />
                        <br />
                        <br />
                        Descricao/Observação:
                        <br />
                        <asp:TextBox ID="txtDescricaoSprint" runat="server" placeholder="Digite uma descrição/observação" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredDesc" runat="server" ControlToValidate="txtDescricaoSprint" ErrorMessage="Digite uma descricao" ForeColor="Red" />
                        <br />
                        <br />
                        Duração (Semana):
                        <br />
                        <asp:TextBox TextMode="Number" ID="txtDuracao" runat="server" placeholder="Digite a duração" Width="45%" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="requiredDur" runat="server" ControlToValidate="txtDuracao" ErrorMessage="Digite a duração" ForeColor="Red" />
                        <br />
                        <br />
                        Status da Sprint:
                        <br />
                        Completo: 
                        <asp:CheckBox ID="txtStatus" runat="server" Width="45%" CssClass="checkbox" />

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarSprint" />
                        <a href="/Pages/DetalhesProj.aspx" class="btn btn-danger btn">Cancelar</a>

                    </asp:Panel>

                    <asp:TextBox ID="txtCodigoSprint" placeholder="Id da Sprint a ser Excluida" runat="server" CssClass="form-control" Width="20%" />
                    <br />
                    <asp:Button ID="btnConfirm" runat="server" Text="Remover Sprint" CssClass="btn btn-danger btn-lg" OnClick="btnConfirmarExclusao" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-warning btn-lg" OnClick="btnCancelarExclusao" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>
