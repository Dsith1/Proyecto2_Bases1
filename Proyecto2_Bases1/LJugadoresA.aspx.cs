using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class LJugadoresA : System.Web.UI.Page
    {
        protected string ListaJ = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            string p = Request.QueryString["p"];

            Coneccion a = new Coneccion();


            if (p != "1")
            {

            }
            else
            {
                string codigo = Request.QueryString["codigo"];

                a = new Coneccion("EliminarJugador", codigo, 7);
            }

            string players = a.getJugadores();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');

                ListaJ += "<tr><td><a href=\"DetalleA.aspx?Cuenta=" + Usuario + "&codigo=+" + b[0] + "\">" + b[1] + "</a></td><td>" + b[2] + "</td><td>" + b[3] + "</td><td><a href=\"ModificarJ.aspx?Cuenta=" + Usuario + "&codigo=+" + b[0] + "\">Modificar</a></td><td><a href=\"LJugadoresA.aspx?Cuenta=" + Usuario + "&codigo=+" + b[0] + "&p=1\">Eliminar</a></td></tr>\n ";


            }
        }
    }
}