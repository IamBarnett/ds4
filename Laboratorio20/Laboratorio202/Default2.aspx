<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Laboratorio202.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 50%; margin: auto; padding: 20px; border: 1px solid #ccc; border-radius: 5px;">
            <h2 style="text-align: center;">Gestión de Productos</h2>

            <asp:Label ID="LabelId" runat="server" Text="ID:" AssociatedControlID="txtId" />
            <asp:TextBox ID="txtId" runat="server" Enabled="false" Width="100%"></asp:TextBox>

            <asp:Label ID="LabelNombre" runat="server" Text="Nombre:" AssociatedControlID="txtNombre" />
            <asp:TextBox ID="txtNombre" runat="server" Width="100%"></asp:TextBox>

            <asp:Label ID="LabelPrecio" runat="server" Text="Precio:" AssociatedControlID="txtPrecio" />
            <asp:TextBox ID="txtPrecio" runat="server" Width="100%"></asp:TextBox>

            <asp:Label ID="LabelStock" runat="server" Text="Stock:" AssociatedControlID="txtStock" />
            <asp:TextBox ID="txtStock" runat="server" Width="100%"></asp:TextBox>

            <br /><br />
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>
    </form>
</body>
</html>
