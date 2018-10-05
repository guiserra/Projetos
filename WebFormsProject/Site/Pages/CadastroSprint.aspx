<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSprint.aspx.cs" Inherits="Site.Pages.CadastroSprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro Sprint</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<script src="../../Scripts/bootstrap.min.js"></script>
<script src="../../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Sprint</h3>
                    <br />
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
                        <asp:CheckBox ID="txtStatus" runat="server" Width="45%" CssClass="checkbox" />
                        <br />
                        <br />

                        <p>
                            <asp:Label ID="lblMessagem" runat="server" />
                        </p>

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrarSprint" />
                        <a href="/Pages/ConsultaProjeto.aspx" class="btn btn-danger">Cancelar</a>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
