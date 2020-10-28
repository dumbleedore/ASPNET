<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Combobox.aspx.cs" Inherits="Estudo.Combobox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form_box" runat="server">
        <div>
            <asp:dropdownlist OnSelectedIndexChanged="ddl_SelectedIndexChanged" runat="server" ID="ddl"></asp:dropdownlist>
            <asp:Button runat="server" ID="button" OnClick="button_Click" Text="Clique"/>
        </div>
    </form>
    <p id="para" runat="server"></p>
</body>
</html>
