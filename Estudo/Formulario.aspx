<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Estudo.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label  runat="server" AssociatedControlID="name">Nome: </asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button id="buttonsend" Text="Enviar" runat="server" onClick="enviar_Click"/>
            <p ID="txtsucess" runat="server"></p>
            <asp:GridView ID="pessoatable" runat="server"/>
        </div>
    </form>
</body>
</html>
