<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Laboratorio_15_4.WebForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suma de Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Suma de Dos Números</h2>
            <label for="txtNumero1">Número 1:</label>
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
            <br />
            <label for="txtNumero2">Número 2:</label>
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server" Text="El resultado aparecerá aquí"></asp:Label>
        </div>
    </form>
</body>
</html>
