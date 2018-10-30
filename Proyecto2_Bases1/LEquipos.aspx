<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LEquipos.aspx.cs" Inherits="Proyecto2_Bases1.LEquipos" %>

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
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Listado</a></li>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Goles</a></li>

                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Equipos</a>
                        <ul>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Listado</a></li>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Planteles</a></li>
                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Partidos</a>
                        <ul>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Resultados</a></li>

                        </ul>
                    </li>

                    <li>
                        <a href="#" class="icon fa-angle-down">Torneo</a>
                        <ul>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Grupos</a></li>
                            <li><a href="NuevaCarpeta.aspx?Cuenta=<%=Request.QueryString["Cuenta"]%>">Resultados</a></li>

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

            <div class="table-wrapper">
                <table>
                    <thead>
                        <tr>
                            <th>Nombre</th>
                            <th>Confederacion</th>
                            
                        </tr>
                    </thead>
                    <tbody>

                        <%= this.ListaE %>
                    </tbody>

                </table>
            </div>
            <ul>
            </ul>


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
