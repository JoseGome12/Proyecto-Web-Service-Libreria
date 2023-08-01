<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerTusLibros.aspx.cs" Inherits="BibliotecaP.VerTusLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tus libros</title>
        <link href="https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="css/Normalize.css">
    <link rel="stylesheet" href="css/Normalize.css">
    <link href="css/main.css " rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <header>
        <h1 class="titulo">  StormBlessed
            <span>Library</span>
        </h1>
    </header>
    <div class="nav_bg">
        <nav class="Navegacion-Principal Contenedor">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkInicio_Click">Inicio</asp:LinkButton>
            <asp:LinkButton ID="linkMisLibros" runat="server" OnClick="LinkMisLibros_Click">Mis libros</asp:LinkButton>
        </nav>
    </div>
    <section class="hero">
        <div class="contenido-hero">
            <h2> Libreria Virtual</h2>
            <div class="ubicacion">
                <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-map-pin" width="88"
                    height="88" viewBox="0 0 24 24" stroke-width="1.5" stroke="#ff9300" fill="none"
                    stroke-linecap="round" stroke-linejoin="round">
                    <path stroke="none" d="M0 0h24v24H0z" fill="none" />
                    <circle cx="12" cy="11" r="3" />
                    <path d="M17.657 16.657l-4.243 4.243a2 2 0 0 1 -2.827 0l-4.244 -4.243a8 8 0 1 1 11.314 0z" />
                </svg>
                
                <p>Cartago Costa Rica</p>

            </div>

            <a href="#" class="boton">Contactar</a>
        </div>
    </section>

    <main class="Contenedor sombra">

        <section>
            <h2>Tus libros</h2>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:ImageField HeaderText="Portadas">
                        </asp:ImageField>
                        <asp:ButtonField ButtonType="Button" HeaderText="Eliminar Libro" Text="Eliminar" />
                    </Columns>
                </asp:GridView>
            

        </section>
    </main>


    </section>
    <footer class="footer">
        <p>© Derechos Reservados José Julián Gómez</p>
    </footer>
    </form>
</body>
</html>
