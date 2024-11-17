<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio201.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz N x N</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInstruction" runat="server" Text="Ingrese el valor de N:"></asp:Label>
            <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerateMatrix" runat="server" Text="Generar Matriz" OnClick="btnGenerateMatrix_Click" />
            <br /><br />
            <asp:Panel ID="pnlMatrix" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>




