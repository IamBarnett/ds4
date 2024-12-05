<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaSoporteTecnico.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Soporte Técnico - Iniciar Sesión</title>
    <style>
        body {
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            height: 100vh;
            background: url('https://images.pexels.com/photos/158826/structure-light-led-movement-158826.jpeg') no-repeat center center fixed;
            background-size: cover;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .login-container {
            background-color: rgba(255, 255, 255, 0.85);
            border-radius: 10px;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.2);
            padding: 30px;
            width: 350px;
            backdrop-filter: blur(5px);
        }
        /* ... (rest of the previous CSS remains the same) ... */
        .login-overlay {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.1);
            z-index: -1;
        }
    </style>
</head>
<body>
    <div class="login-overlay"></div>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2 class="login-title">Sistema de Soporte Técnico</h2>
            <asp:Login ID="LoginControl" runat="server" OnAuthenticate="LoginControl_Authenticate">
                <LayoutTemplate>
                    <div class="login-form">
                        <asp:TextBox ID="UserName" runat="server" placeholder="Correo Electrónico"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                            ControlToValidate="UserName" ErrorMessage="* Email requerido" 
                            CssClass="validation-error" Display="Dynamic" />
                        
                        <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                            ControlToValidate="Password" ErrorMessage="* Contraseña requerida" 
                            CssClass="validation-error" Display="Dynamic" />
                        
                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" 
                            Text="Iniciar Sesión" CssClass="login-button" />
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </div>
    </form>
</body>
</html>