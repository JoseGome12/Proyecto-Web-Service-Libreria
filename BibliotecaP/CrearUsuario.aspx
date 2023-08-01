<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="BibliotecaP.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Crear Usuario</title>
      <link rel="stylesheet" href="css/login.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label  ID="Label1" runat="server" style="z-index: 1; left: 14px; top: 27px; position: absolute" Text="Crear Usuario" Font-Bold="True" Font-Overline="False" ForeColor="#0066FF"></asp:Label>
        
        <p>
            <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="usuariobox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear usuario" />
        </p>
            </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>


</body>
</html>
