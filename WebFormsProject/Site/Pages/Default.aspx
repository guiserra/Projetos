<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                    <h3 class="well">
                    Sua lista de projetos
                    <a href="/Pages/DetalhesProj.aspx" class="btn btn-default btn-lg">Detalhes do Projetos</a>
                    <a id="botaoDireita" href="/Pages/ListaUsu.aspx" class="btn btn-warning btn">Lista de Usuários</a>

                    </h3>
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
                    <a href="/Login.aspx" class="btn btn-danger btn-lg">Sair</a>
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
