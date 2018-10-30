using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class LJugadores : System.Web.UI.Page
    {

        protected string ListaJ = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];

            Coneccion a = new Coneccion();

            string players = a.getJugadores();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');

                ListaJ += "<tr><td><a href=\"DetalleJ.aspx?Cuenta="+Usuario+"&codigo=+"+b[0]+"\">" + b[1]+ "</a></td><td>" + b[2] + "</td><td>" + b[3] + "</td></tr>\n ";


            }
        }
    }
}