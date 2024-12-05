<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionTickets.aspx.cs" Inherits="SistemaSoporteTecnico.Pages.GestionTickets" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Tickets</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="mb-4">Gestión de Tickets</h2>
            
            <div class="row mb-3">
                <div class="col-md-6">
                    <asp:DropDownList ID="ddlFiltroEstado" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlFiltroEstado_SelectedIndexChanged">
                        <asp:ListItem Text="Todos los Estados" Value="" />
                        <asp:ListItem Text="Nuevo" Value="Nuevo" />
                        <asp:ListItem Text="En Progreso" Value="EnProgreso" />
                        <asp:ListItem Text="Resuelto" Value="Resuelto" />
                        <asp:ListItem Text="Cerrado" Value="Cerrado" />
                    </asp:DropDownList>
                </div>
                <div class="col-md-6 text-right">
                    <asp:Button ID="btnCrearNuevoTicket" runat="server" Text="Crear Nuevo Ticket" 
                        CssClass="btn btn-primary" OnClick="btnCrearNuevoTicket_Click" />
                </div>
            </div>

            <asp:GridView ID="gvTickets" runat="server" CssClass="table table-striped table-hover" 
                AutoGenerateColumns="false" OnRowCommand="gvTickets_RowCommand">
                <Columns>
                    <asp:BoundField DataField="TicketID" HeaderText="ID" />
                    <asp:BoundField DataField="Titulo" HeaderText="Título" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                    <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                    <asp:BoundField DataField="FechaCreacion" HeaderText="Fecha Creación" DataFormatString="{0:dd/MM/yyyy}" />
                    
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnVerDetalle" runat="server" Text="Ver" 
                                CommandName="VerDetalle" CommandArgument='<%# Eval("TicketID") %>' 
                                CssClass="btn btn-info btn-sm" />
                            
                            <asp:Button ID="btnCambiarEstado" runat="server" Text="Cambiar Estado" 
                                CommandName="CambiarEstado" CommandArgument='<%# Eval("TicketID") %>' 
                                CssClass="btn btn-warning btn-sm" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger"></asp:Label>
        </div>
    </form>

    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
