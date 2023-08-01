﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="BibliotecaP.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pagina Principal</title>
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
        <h2>servicios de Stormblessed Library</h2>
        <div class="servicios">
            <section class="servicio">
                <h3>Libro para todos</h3>
                <div class="Iconos">
<svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-book-2" width="44" height="44" viewBox="0 0 24 24" stroke-width="1.5" stroke="#000000" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path stroke="none" d="M0 0h24v24H0z" fill="none"/>
  <path d="M19 4v16h-12a2 2 0 0 1 -2 -2v-12a2 2 0 0 1 2 -2h12z" />
  <path d="M19 16h-12a2 2 0 0 0 -2 2" />
  <path d="M9 8h6" />
</svg>
                </div>
                <p>
                    Encuentra tus libros favoritos en este espacio para ti.
                </p>

            </section>
            <section class="servicio">
                <h3>Guarda tus libros favoritos</h3>
                <div class="Iconos">
                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-book-download" width="44" height="44" viewBox="0 0 24 24" stroke-width="1.5" stroke="#000000" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path stroke="none" d="M0 0h24v24H0z" fill="none"/>
  <path d="M12 20h-6a2 2 0 0 1 -2 -2v-12a2 2 0 0 1 2 -2h12v5" />
  <path d="M13 16h-7a2 2 0 0 0 -2 2" />
  <path d="M15 19l3 3l3 -3" />
  <path d="M18 22v-9" />
</svg>
                </div>
                <p>Puedes guardar tus libros favoritas y tener una lista ordenada de tus lecturas.</p>
            </section>
            <section class="servicio">
                <h3>Todas tus lecturas en un solo lugar</h3>
                <div class="Iconos">
                   <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-books" width="44" height="44" viewBox="0 0 24 24" stroke-width="1.5" stroke="#000000" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path stroke="none" d="M0 0h24v24H0z" fill="none"/>
  <path d="M5 4m0 1a1 1 0 0 1 1 -1h2a1 1 0 0 1 1 1v14a1 1 0 0 1 -1 1h-2a1 1 0 0 1 -1 -1z" />
  <path d="M9 4m0 1a1 1 0 0 1 1 -1h2a1 1 0 0 1 1 1v14a1 1 0 0 1 -1 1h-2a1 1 0 0 1 -1 -1z" />
  <path d="M5 8h4" />
  <path d="M9 16h4" />
  <path d="M13.803 4.56l2.184 -.53c.562 -.135 1.133 .19 1.282 .732l3.695 13.418a1.02 1.02 0 0 1 -.634 1.219l-.133 .041l-2.184 .53c-.562 .135 -1.133 -.19 -1.282 -.732l-3.695 -13.418a1.02 1.02 0 0 1 .634 -1.219l.133 -.041z" />
  <path d="M14 9l4 -1" />
  <path d="M16 16l3.923 -.98" />
</svg>
                </div>
                <p>Seguimiento de todas tus lecturas en un solo lugar.</p>
            </section>
        </div>
        <section>
            <h2>Libros disponibles<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-right: 3px" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ImageField HeaderText="Portada">
                    </asp:ImageField>
                    <asp:ButtonField ButtonType="Button" Text="Agregar"  CommandName="Añadir"/>
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </h2>

    </main>


    </section>
    <footer class="footer">
        <p>© Derechos Reservados José Julián Gómez</p>
    </footer>
    </form>
</body>
</html>
