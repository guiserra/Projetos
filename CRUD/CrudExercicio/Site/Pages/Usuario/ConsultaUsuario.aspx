<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consulta</title>
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

                    <asp:GridView ID="gridUsuario" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#999999">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Login" HeaderText="Usuario" />
                            <asp:BoundField DataField="Senha" HeaderText="Senha" />
                        </Columns>
                    </asp:GridView>

                    <p>
                        <asp:Label ID="lblMessagem" runat="server" />
                    </p>

                    <a href="/Default.aspx" class="btn btn-danger">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
