<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alerta.aspx.cs" Inherits="Estudo.alerta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="textocaixa"></asp:TextBox>
            <p></p>
            <asp:Button Text="Enviar Mensagem" runat="server" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
