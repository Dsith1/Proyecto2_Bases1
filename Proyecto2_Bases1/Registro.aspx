<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto2_Bases1.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
    <link rel="stylesheet" href="Estilos/assets/css/main.css" />
</head>
<body class="is-preload">
    <div id="page-wrapper">
        <!-- Cabeza -->
        <header id="header">
            <h1><a href="Inicio.aspx">Proyecto 1</a> by Dannek Miranda</h1>
            <nav id="nav">
                <ul>
                    <li><a href="Inicio.aspx">Home</a></li>
                    <li><a href="Login.aspx" class="button">Login</a></li>
                </ul>
            </nav>
        </header>

        <!-- Main -->
        <section id="main" class="container medium" runat="server">
            <header>
                <h2>Registro</h2>
            </header>
            <div class="box">
                <form method="post" action="#">
                    <div class="row gtr-50 gtr-uniform">
                        <div class="col-6 col-12-mobilep">
                            <input type="text" name="Usuario" id="Usuario" value="" placeholder="Usuario" />
                        </div>
                        <div class="col-6 col-12-mobilep">
                            <input type="text" name="Nombre" id="Nombre" value="" placeholder="Nombre" />
                        </div>
                        <div class="col-6 col-12-mobilep">
                            <input type="text" name="Apellido" id="Apellido" value="" placeholder="Apellido" />
                        </div>

                        <div class="col-6 col-12-mobilep">
                            <input type="text" name="Edad" id="Edad" value="" placeholder="Edad" />
                        </div>

                        <div class="col-6 col-12-mobilep">
                            <input type="password" name="Contra1" id="Contra1" value="" placeholder="Contraseña" />
                        </div>
                        <div class="col-6 col-12-mobilep">
                            <input type="password" name="Contra2" id="Contra2" value="" placeholder="Repita Contraseña" />
                        </div>

                        <div class="col-6 col-12-mobilep">
                            <select name="Pais" id="Pais">
                                <option value="">- Pais -</option>
                                <%= this.OPais %>
                            </select>
                        </div>

                        <div class="col-12">
                            <ul class="actions special">
                                <li>
                                    <input runat="server" type="submit" value="Registrarse" /></li>
                            </ul>
                        </div>
                    </div>
                </form>
            </div>
        </section>
        <div>
        </div>
    </div>

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
