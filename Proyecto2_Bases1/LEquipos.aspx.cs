using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class LEquipos : System.Web.UI.Page
    {
        protected string ListaE = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            

            Coneccion a = new Coneccion();

            

            string players = a.getEquipos();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');

                ListaE += "<tr><td>"+b[0] +"</td><td>" + b[1] + "</td><td><a href=\"ResultadosE.aspx?Cuenta=" + Usuario + "&codigo=" + b[2] +"\"> Ver Partidos</a></td></tr>\n ";

               
            }

           
        }
    }
}