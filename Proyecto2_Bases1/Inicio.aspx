<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto2_Bases1.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />

    <title>Gestor De Correo</title>
    <link rel="stylesheet" href="Estilos/assets/css/main.css" />
</head>
<body class="landing is-preload">
    <div id="page-wrapper">


        <!-- Cabeza -->
        <header id="header" class="alt">
            <h1><a href="">Proyecto 1</a> by Dannek Miranda</h1>
            <nav id="nav">
                <ul>

                    <li><a href="Registro.aspx" class="button">Registro</a></li>
                    <li><a href="Login.aspx" class="button">Login</a></li>
                </ul>
            </nav>
        </header>
        <form id="form1" runat="server">
            <div></div>
            <!-- banner -->
            <section id="banner">
                <h2>Gestor de Correo</h2>
                <p>Proyecto 2 Bases de Datos FIUSAC</p>
                <ul class="actions special">
                    <li><a href="Registro.aspx" class="button primary">Registro</a></li>
                    <li><a href="Login.aspx" class="button">Login</a></li>
                </ul>
            </section>



        </form>


        <!-- Footer -->
        <footer id="footer">
            <ul class="icons">
                <li><a href="#" class="icon fa-id-card"><span class="label">Acerca De</span></a></li>

            </ul>
        </footer>
    </div>

        <!-- Scripts -->
        <script src="Estilos/assets/js/jquery.min.js"></script>
        <script src="Estilos/assets/js/jquery.dropotron.min.js"></script>
        <script src="Estilos/assets/js/jquery.scrollex.min.js"></script>
        <script src="Estilos/assets/js/browser.min.js"></script>
        <script src="Estilos/assets/js/breakpoints.min.js"></script>
        <script src="Estilos/assets/js/util.js"></script>
        <script src="Estilos/assets/js/main.js"></script>

        <script>
            function getGET() {
                // capturamos la url
                var loc = document.location.href;
                // si existe el interrogante
                if (loc.indexOf('?') > 0) {
                    // cogemos la parte de la url que hay despues del interrogante
                    var getString = loc.split('?')[1];
                    // obtenemos un array con cada clave=valor
                    var GET = getString.split('&');
                    var get = {};

                    // recorremos todo el array de valores
                    for (var i = 0, l = GET.length; i < l; i++) {
                        var tmp = GET[i].split('=');
                        get[tmp[0]] = unescape(decodeURI(tmp[1]));
                    }
                    return get;
                }
            }




            window.onload = function () {
                // Cogemos los valores pasados por get
                var valores = getGET();
                if (valores) {
                    // hacemos un bucle para pasar por cada indice del array de valores
                    window.location.hash = "no-back-button";
                    window.location.hash = "Again-No-back-button" //chrome
                    window.onhashchange = function () { window.location.hash = "no-back-button"; }
                } else {
                    // no se ha recibido ningun parametro por GET
                    //document.write("<br>No se ha recibido ningún parámetro");
                }
            }
        </script>
</body>
</html>
