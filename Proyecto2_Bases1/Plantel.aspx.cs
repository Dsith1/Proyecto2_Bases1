using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Plantel : System.Web.UI.Page
    {
        protected string LEquipo = "";
        protected string ListaJ = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            Coneccion a = new Coneccion();
            string equipos = a.getLEquipos();

            string[] equipo = equipos.Split(';');

            for (int i = 0; i < (equipo.Length - 1); i++)
            {
                string[] opcion = equipo[i].Split(',');

                LEquipo += "<option value=\"" + opcion[0] + "\">" + opcion[1] + "</option>\n";
            }

            if (!IsPostBack)
            {

                string Equipo = Request.Form["Equipos"];

                if(Equipo != null)
                {
                    string players = a.getPlantel(Equipo);

                    string[] jugadores = players.Split(';');

                    for (int i = 0; i < jugadores.Length - 1; i++)
                    {
                        string[] b = jugadores[i].Split(',');

                        ListaJ += "<tr><td>"+ b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td></tr>\n ";


                    }
                }
            }

        }
    }
}