<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Bem Vindo</title>
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
                    <h1>BEM VINDO - <asp:Label ID="lblUsuarioLogado" runat="server" /> !
                        <a id="botaoDireita" href="/Pages/ListaUsu.aspx" class="btn btn-warning btn">Lista de Usuários</a>
                    <h3 class="well">Sua lista de projetos
                    <a href="/Pages/DetalhesProj.aspx" class="btn btn-default btn-lg">Detalhes do Projetos</a>
                        
                    </h3>
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
                <br />
                <asp:GridView ID="gridProjetos" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffff">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>
                <br />



                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <a href="/Pages/CadastroProj.aspx" class="btn btn-info btn-lg">Novo Projeto</a>
                <a href="/Login.aspx" class="btn btn-danger btn-lg">Sair Sessão</a>

            </div>
        </div>
    </form>
</body>
</html>
