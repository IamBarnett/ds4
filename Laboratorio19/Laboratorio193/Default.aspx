<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio19_WebApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consumo de API - Obtener Dato por ID</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGetById" runat="server" Text="Obtener Dato con ID 2" OnClick="btnGetById_Click" />
            <br /><br />
            <asp:Label ID="lblDataById" runat="server" Text="El resultado aparecerá aquí." />
        </div>
    </form>
</body>
</html>

