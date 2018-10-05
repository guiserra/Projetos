<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalhesUsu.aspx.cs" Inherits="Site.Pages.DetalhesUsu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes do Usuário</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Script/jquery-1.9.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
<body>
     <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes dos Usuários</h3>

                    Informe o Código do Usuário: <br />
                    <asp:TextBox ID="txtCodigo" runat="server" CssCLass="form-control" Width="20%" />
                    <br />
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick ="btnPesquisarUsu"/>
                    <a href="/Pages/ListaUsu.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br /><br /><br /><br />
                    
                    <asp:Panel ID="pnlDados" runat="server">

                    Nome do Usuário: <br />
                    <asp:TextBox ID="txtNome" runat="server" CssCLass="form-control" Width="45%" />
                    <br />

                    Email do Usuário: <br />
                    <asp:TextBox ID="txtEmail" runat="server" CssCLass="form-control" Width="45%" />
                    <br />
                    
                    Senha do Usuário: <br />
                    <asp:TextBox ID="txtSenha" runat="server" CssCLass="form-control" Width="45%" />
                    <br />
                    
                    <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" CssClass="btn btn-success btn-lg" OnClick="btnAtualizarUsu" />
                    <asp:Button ID="btnExclui" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirUsu" />
                    
                    </asp:Panel>
                    
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
