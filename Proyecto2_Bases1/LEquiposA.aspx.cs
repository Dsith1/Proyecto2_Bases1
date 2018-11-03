using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class LEquiposA : System.Web.UI.Page
    {
        protected string ListaE = "";

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

                a = new Coneccion("EliminarEQuipo", codigo, 7);
            }


            string players = a.getEquipos();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');

                ListaE += "<tr><td>" + b[0] + "</td><td>" + b[1] + "</td><td><a href=\"ResultadosA.aspx?Cuenta=" + Usuario + "&codigo=" + b[2] + "\"> Ver Partidos</a></td>" + "</td><td><a href=\"ModificarE.aspx?Cuenta=" + Usuario + "&codigo=" + b[2] + "\"> Modificar</a></td>" + "</td><td><a href=\"LEquiposA.aspx?Cuenta=" + Usuario + "&codigo=" + b[2] + "&p=1\">Eliminar</a></td></tr>\n ";


            }
        }
    }
}