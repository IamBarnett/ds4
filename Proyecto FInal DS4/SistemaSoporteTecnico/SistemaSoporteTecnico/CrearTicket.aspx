<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearTicket.aspx.cs" Inherits="SistemaSoporteTecnico.CrearTicket" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crear Ticket de Soporte</title>
    <style>
        body {
        font-family: 'Inter', 'Segoe UI', sans-serif;
        background: url('https://images.unsplash.com/photo-1526374965328-7f61d4dc18c5?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8dGVjaHxlbnwwfHwwfHx8MA%3D%3D') no-repeat center center fixed;
        background-size: cover;
        display: flex;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
        margin: 0;
        padding: 20px;
        }
        .ticket-container {
            background-color: white;
            border-radius: 12px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            padding: 40px;
            width: 500px;
            max-width: 100%;
            border-top: 5px solid #3498db;
        }
        .ticket-title {
            text-align: center;
            color: #2c3e50;
            margin-bottom: 30px;
            font-weight: 600;
        }
        .form-group {
            margin-bottom: 20px;
            position: relative;
        }
        .form-control {
            width: 100%;
            padding: 12px;
            border: 1px solid #e0e0e0;
            border-radius: 6px;
            transition: all 0.3s ease;
            font-size: 14px;
        }
        .form-control:focus {
            outline: none;
            border-color: #3498db;
            box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.1);
        }
        .validation-error {
            color: #e74c3c;
            font-size: 0.8em;
            margin-top: 5px;
            position: absolute;
            bottom: -20px;
        }
        .btn-submit {
            width: 100%;
            padding: 14px;
            background-color: #3498db;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-weight: 500;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        .btn-submit:hover {
            background-color: #2980b9;
            transform: translateY(-2px);
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
        }
        textarea {
            resize: vertical;
            min-height: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ticket-container">
            <h2 class="ticket-title">Crear Nuevo Ticket de Soporte</h2>
            <div class="form-group">
                <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" 
                    placeholder="Título del problema"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" 
                    ControlToValidate="txtTitulo" ErrorMessage="El título es requerido" 
                    CssClass="validation-error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Seleccione una categoría" Value="" />
                    <asp:ListItem Text="Hardware" Value="1" />
                    <asp:ListItem Text="Software" Value="2" />
                    <asp:ListItem Text="Red" Value="3" />
                    <asp:ListItem Text="Otro" Value="4" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvCategoria" runat="server" 
                    ControlToValidate="ddlCategoria" ErrorMessage="Seleccione una categoría" 
                    CssClass="validation-error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" 
                    CssClass="form-control" 
                    placeholder="Describa detalladamente su problema"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" 
                    ControlToValidate="txtDescripcion" ErrorMessage="La descripción es requerida" 
                    CssClass="validation-error" Display="Dynamic" />
            </div>
            <div class="form-group">
                <asp:FileUpload ID="fuAdjunto" runat="server" CssClass="form-control" />
            </div>
            <asp:Button ID="btnCrearTicket" runat="server" Text="Crear Ticket" 
                CssClass="btn-submit" OnClick="btnCrearTicket_Click" />
        </div>
    </form>
</body>
</html>
