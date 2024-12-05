<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaSoporteTecnico.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio de Sesión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Sistema de Soporte Técnico</h2>
            <asp:Login ID="LoginControl" runat="server" OnAuthenticate="LoginControl_Authenticate">
                <LayoutTemplate>
                    <table>
                        <tr>
                            <td>Email:</td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                    ControlToValidate="UserName" ErrorMessage="Email requerido" />
                            </td>
                        </tr>
                        <tr>
                            <td>Contraseña:</td>
                            <td>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                    ControlToValidate="Password" ErrorMessage="Contraseña requerida" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Iniciar Sesión" />
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>
        </div>
    </form>
</body>
</html>
