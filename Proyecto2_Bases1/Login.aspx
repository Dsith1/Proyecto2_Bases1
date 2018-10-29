<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto2_Bases1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                    <li><a href="Registro.aspx" class="button">Sign Up</a></li>
                </ul>
            </nav>
        </header>
     <!-- Main -->
				<section id="main" class="container medium">
					<header>
						<h2>Identificarse</h2>
					</header>
					<div class="box">
						<form method="post" action="#">
							<div class="row gtr-50 gtr-uniform">
								<div class="col-6 col-12-mobilep">
									<input type="text" name="Usuario" id="Usuario" value="" placeholder="Usuario" />
								</div>
								
                                 <div class="col-6 col-12-mobilep">
									<input type="password" name="Contra" id="Contra" value="" placeholder="Contraseña" />
								</div>

								<div class="col-12">
									<ul class="actions special">
										<li><input runat="server" type="submit" value="Login"/></li>
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
