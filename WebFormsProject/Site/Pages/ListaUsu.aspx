<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsu.aspx.cs" Inherits="Site.Pages.ListaUsu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                    <h3 class="well">Lista de Usuários</h3>
                    <a id="botaoDireita" href="/Pages/DetalhesUsu.aspx" class="btn btn-default btn-lg">Detalhes dos Usuários</a>
                    <asp:GridView ID="gridUsuarios" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#ccffff">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                        </Columns>
                        <RowStyle CssClass="cursor-pointer" />
                    </asp:GridView>
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                
                    <a href="/Pages/CriarUsu.aspx" class="btn btn-info btn-lg">Novo Usuário</a>
                    <a href="/Pages/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
