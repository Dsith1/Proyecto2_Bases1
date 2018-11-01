using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class LParticipantes : System.Web.UI.Page
    {
        protected string ListaP = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];

            Coneccion a = new Coneccion();

            string players = a.getParticipantes();

            string[] jugadores = players.Split(';');

            for (int i = 0; i < jugadores.Length - 1; i++)
            {
                string[] b = jugadores[i].Split(',');

                ListaP += "<tr><td>"+b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td><td>" + b[3] + "</td></tr>\n ";


            }
        }
    }
}