<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alterar.aspx.cs" Inherits="Paginas_Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link rel="stylesheet" href="../Css/main.css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.min.js" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css" />

    <title>Alterar Funcionário</title>
</head>
<body class="top">
    <div class="page">
        <form class="form" method="post" runat="server">
            <asp:Label CssClass="titulo" ID="lblTitulo" runat="server" Text="Alteração de Funcionário"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="lblNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox CssClass="box" ID="txtNome" runat="server"></asp:TextBox>
            <asp:Label ID="errorNome" CssClass="error" runat="server"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="lblSalario" runat="server" Text="Salário"></asp:Label>
            <asp:TextBox CssClass="box" ID="txtSalario" runat="server"></asp:TextBox>
            <asp:Label ID="errorSalario" CssClass="error" runat="server"></asp:Label>
            <br />
            <asp:Label CssClass="label" ID="lblCracha" runat="server" Text="Crachá"></asp:Label>
            <asp:TextBox CssClass="box" ID="txtCracha" runat="server"></asp:TextBox>
            <asp:Label ID="errorCracha" CssClass="error" runat="server"></asp:Label>
            <br />
            <div class="row">
                <asp:Button CssClass="btn" ID="btnSalvar" runat="server" Text="SALVAR" OnClick="btnSalvar_click" />
                <br />
                <br />
            </div>
            <div class="lista">
                <a><asp:LinkButton runat="server" href="../Paginas/Listar.aspx">Listagem de Funcionários</asp:LinkButton></a>
            </div>
            <div class="mensagem">
                <br />
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
