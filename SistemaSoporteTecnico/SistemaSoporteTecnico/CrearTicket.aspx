<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearTicket.aspx.cs" Inherits="SistemaSoporteTecnico.CrearTicket" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Ticket</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Crear Nuevo Ticket</h2>
            <asp:TextBox ID="txtTitulo" runat="server" placeholder="Título del problema"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" 
                ControlToValidate="txtTitulo" ErrorMessage="El título es requerido" />

            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" 
                placeholder="Describa detalladamente su problema"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" 
                ControlToValidate="txtDescripcion" ErrorMessage="La descripción es requerida" />

            <asp:Button ID="btnCrearTicket" runat="server" Text="Crear Ticket" OnClick="btnCrearTicket_Click" />
        </div>
    </form>
</body>
</html>
