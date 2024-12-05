<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionTickets.aspx.cs" Inherits="SistemaSoporteTecnico.Pages.GestionTickets" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Tickets</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f4f7f6;
            background: url('https://plus.unsplash.com/premium_photo-1661963212517-830bbb7d76fc?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8dGVjaG5vbG9neXxlbnwwfHwwfHx8MA%3D%3D') no-repeat center center fixed;
        }
        .ticket-management-container {
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            padding: 30px;
            margin-top: 30px;
        }
        .status-badge {
            display: inline-block;
            padding: 5px 10px;
            border-radius: 4px;
            font-size: 0.8em;
        }
        .status-nuevo { background-color: #3498db; color: white; }
        .status-progreso { background-color: #f39c12; color: white; }
        .status-resuelto { background-color: #2ecc71; color: white; }
        .status-cerrado { background-color: #95a5a6; color: white; }
        .ticket-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 20px;
        }
        .table-hover tbody tr:hover {
            background-color: #f1f3f4;
            transition: background-color 0.3s ease;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container ticket-management-container">
            <div class="ticket-header">
                <h2>Gestión de Tickets</h2>
                <asp:Button ID="btnCrearNuevoTicket" runat="server" Text="Crear Nuevo Ticket" 
                    CssClass="btn btn-primary" OnClick="btnCrearNuevoTicket_Click" />
            </div>
            
            <div class="row mb-3">
                <div class="col-md-6">
                    <asp:DropDownList ID="ddlFiltroEstado" runat="server" CssClass="form-control" 
                        AutoPostBack="true" OnSelectedIndexChanged="ddlFiltroEstado_SelectedIndexChanged">
                        <asp:ListItem Text="Todos los Estados" Value="" />
                        <asp:ListItem Text="Nuevo" Value="Nuevo" />
                        <asp:ListItem Text="En Progreso" Value="EnProgreso" />
                        <asp:ListItem Text="Resuelto" Value="Resuelto" />
                        <asp:ListItem Text="Cerrado" Value="Cerrado" />
                    </asp:DropDownList>
                </div>
            </div>

            <asp:GridView ID="gvTickets" runat="server" CssClass="table table-striped table-hover" 
                AutoGenerateColumns="false" OnRowCommand="gvTickets_RowCommand">
                <Columns>
                    <asp:BoundField DataField="TicketID" HeaderText="ID" />
                    <asp:BoundField DataField="Titulo" HeaderText="Título" />
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <span class='status-badge status-<%# Eval("Estado").ToString().ToLower().Replace(" ", "") %>'>
                                <%# Eval("Estado") %>
                            </span>
                        </ItemTemplate>
                    </asp:TemplateField>
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
