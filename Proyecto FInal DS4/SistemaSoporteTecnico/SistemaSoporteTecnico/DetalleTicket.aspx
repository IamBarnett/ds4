<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleTicket.aspx.cs" Inherits="SistemaSoporteTecnico.DetalleTicket" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .ticket-detail-container {
            background-image: url('https://wallpapercat.com/w/full/b/1/6/2138343-1920x1080-desktop-full-hd-high-tech-background-image.jpg');
            background-size: cover;
            background-position: center;
            background-attachment: fixed;
            min-height: 100vh;
            padding: 40px 0;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .ticket-card {
            background-color: rgba(255, 255, 255, 0.9);
            border-radius: 12px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            padding: 30px;
            max-width: 600px;
            width: 100%;
            backdrop-filter: blur(5px);
        }

        .ticket-header {
            text-align: center;
            margin-bottom: 25px;
            color: #333;
        }

        .ticket-detail {
            margin-bottom: 20px;
        }

        .ticket-detail label {
            font-weight: bold;
            color: #555;
            display: block;
            margin-bottom: 5px;
        }

        .ticket-detail-value {
            background-color: #f9f9f9;
            border: 1px solid #e0e0e0;
            border-radius: 6px;
            padding: 10px;
            font-size: 16px;
            color: #333;
        }

        .btn-estado {
            width: 100%;
            padding: 12px;
            font-size: 16px;
            background-color: #007bff;
            border-color: #0056b3;
            transition: all 0.3s ease;
        }

        .btn-estado:hover {
            background-color: #0056b3;
            transform: translateY(-2px);
        }
    </style>

    <div class="ticket-detail-container">
        <div class="ticket-card">
            <div class="ticket-header">
                <h2>Detalles del Ticket</h2>
                <p>Información detallada de su solicitud de soporte</p>
            </div>

            <asp:Panel ID="pnlDetalleTicket" runat="server">
                <div class="ticket-detail">
                    <label>Título del Ticket:</label>
                    <div class="ticket-detail-value">
                        <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                    </div>
                </div>
                
                <div class="ticket-detail">
                    <label>Descripción:</label>
                    <div class="ticket-detail-value">
                        <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
                    </div>
                </div>
                
                <div class="ticket-detail">
                    <label>Estado Actual:</label>
                    <div class="ticket-detail-value">
                        <asp:Label ID="lblEstado" runat="server"></asp:Label>
                    </div>
                </div>
                
                <div class="ticket-detail">
                    <label>Fecha de Creación:</label>
                    <div class="ticket-detail-value">
                        <asp:Label ID="lblFechaCreacion" runat="server"></asp:Label>
                    </div>
                </div>
                
                <div class="ticket-detail">
                    <asp:Button ID="btnCambiarEstado" runat="server" 
                        Text="Actualizar Estado del Ticket" 
                        CssClass="btn btn-primary btn-estado" 
                        OnClick="btnCambiarEstado_Click" />
                </div>
            </asp:Panel>
            
            <asp:Panel ID="pnlMensaje" runat="server" Visible="false">
                <div class="alert alert-danger">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </div>
            </asp:Panel>

            <asp:Button ID="btnIrGestionTickets" runat="server" 
                Text="Ir a Gestión de Tickets" 
                CssClass="btn btn-primary btn-estado" 
                OnClick="btnIrGestionTickets_Click" />
        </div>
    </div>
</asp:Content>
