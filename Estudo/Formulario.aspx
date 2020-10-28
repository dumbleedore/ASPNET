<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Estudo.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        #listaid{
            margin : 5px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label  runat="server" AssociatedControlID="name">Nome: </asp:Label>
            <asp:TextBox id="name" runat="server"></asp:TextBox>
            <asp:DropDownList runat="server" ID="ddl"></asp:DropDownList>
            <br />
            <br />
            <asp:Button id="buttonsend" Text="Enviar" runat="server" onClick="enviar_Click"/>
            <asp:Button id="buttonupdt" Text="Update" runat="server" OnClick="buttonupdt_Click"/>
            <asp:Button id="buttondlt" Text="Delete" runat="server" OnClick="buttondlt_Click"/>
         
            <p id="txtsucess" runat="server"></p>
            <asp:GridView ID="pessoatable" runat="server"/>
        </div>
    </form>
    <p id="teste" runat="server"></p>
</body>
</html>
