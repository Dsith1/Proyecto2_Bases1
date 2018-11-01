using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class ResultadosA : System.Web.UI.Page
    {
        protected string ListaR = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];

            Coneccion a = new Coneccion();

            string players = a.getResultados();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');


                if (b[1].Equals("-"))
                {
                    ListaR += "<tr><td align=\"right\">" + b[0] + "</td><td align=\"center\">" + b[1] + "</td><td align=\"center\"><a href=\"Partido.aspx?Cuenta=" + Usuario + "&codigo=+" + b[4] + "\">ver</a></td><td  align=\"center\">" + b[2] + "</td><td>" + b[3] + "</td><td><a href=\"Marcador.aspx?Cuenta=" + Usuario + "&codigo=+" + b[4] + "\">Agregar Marcador</a</td></tr>\n ";
                }
                else
                {
                    ListaR += "<tr><td align=\"right\">" + b[0] + "</td><td align=\"center\">" + b[1] + "</td><td align=\"center\"><a href=\"Partido.aspx?Cuenta=" + Usuario + "&codigo=+" + b[4] + "\">ver</a></td><td  align=\"center\">" + b[2] + "</td><td>" + b[3] + "</td><td></td></tr>\n ";

                }

            }
        }
    }
}