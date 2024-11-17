<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio20.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstruction" runat="server" Text="Ingrese un número:"></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnShowTable" runat="server" Text="Mostrar Tabla" OnClick="btnShowTable_Click" />
            <br /><br />
            <asp:Label ID="lblTable" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

