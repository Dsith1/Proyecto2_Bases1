<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Plantel.aspx.cs" Inherits="Proyecto2_Bases1.Plantel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />

    <title>Inicio</title>
    <link rel="stylesheet" href="Estilos/assets/css/main.css" />
</head>
<body class="is-preload">
    <div id="page-wrapper">
        <!-- Cabeza -->

        <header id="header">
            <h1><a href="Inicio.aspx">Proyecto 1</a> by Dannek Miranda</h1>
            <nav id="nav">
                <ul>
                    <li><a href="Menu.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Home</a></li>

                    <li><a href="#" class="button">Quinielas</a></li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Jugadores</a>
                        <ul>
                            <li><a href="LJugadores.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Listado</a></li>
                            <li><a href="LGoleadores.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Goles</a></li>

                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Equipos</a>
                        <ul>
                            <li><a href="LEquipos.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Listado</a></li>
                            <li><a href="LEquipos.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Posiciones</a></li>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Planteles</a></li>
                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Partidos</a>
                        <ul>
                            <li><a href="Resultados.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Resultados</a></li>

                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Torneo</a>
                        <ul>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Grupos</a></li>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Posiciones</a></li>

                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Cuenta</a>
                        <ul>

                            <li><a href="Inicio.aspx?logof=1">Cerrar Sesión</a></li>

                        </ul>
                    </li>

                </ul>
            </nav>
        </header>


    </div>

    <section id="main" class="container">
        <!-- Main -->

        <section class="box">
            <header>
                <h2>Plantel</h2>
            </header>
            <div class="box">
                <form method="post" action="#">
                    <div class="row gtr-50 gtr-uniform">
                        

                        <div class="col-6 col-12-mobilep">
                            <select name="Equipos" id="Equipos">
                                <option value="">- Equipos -</option>
                                <%= this.LEquipo %>
                            </select>
                        </div>

                        <div class="col-12">
                            <ul class="actions special">
                                <li>
                                    <input runat="server" type="submit" value="Ver" /></li>
                            </ul>
                        </div>
                    </div>
                </form>
            </div>

            <div class="table-wrapper">
                <table>
                    <thead>
                        <tr>
                            <th>Nombre</th>
                            <th>Posicion</th>
                            <th>Dorsal</th>
                        </tr>
                    </thead>
                    <tbody>

                        <%= this.ListaJ %>
                    </tbody>

                </table>
            </div>

            
        </section>

    </section>
    <!-- Footer -->
    <footer id="footer">
        <ul class="icons">
            <li><a href="Acerca.html" class="icon fa-id-card"><span class="label">Acerca De</span></a></li>

        </ul>
    </footer>

    <!-- Scripts -->
    <script src="Estilos/assets/js/jquery.min.js"></script>
    <script src="Estilos/assets/js/jquery.dropotron.min.js"></script>
    <script src="Estilos/assets/js/jquery.scrollex.min.js"></script>
    <script src="Estilos/assets/js/browser.min.js"></script>
    <script src="Estilos/assets/js/breakpoints.min.js"></script>
    <script src="Estilos/assets/js/util.js"></script>
    <script src="Estilos/assets/js/main.js"></script>
</body>
</html>
