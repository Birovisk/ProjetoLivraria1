<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Livraria Leia Feliz</h1>
        <p>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuário: "></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text="Preencha o Usuário e Senha para acessar o sistema."></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
