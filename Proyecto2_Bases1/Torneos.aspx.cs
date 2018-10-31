using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Torneos : System.Web.UI.Page
    {
        protected string ListaE = "";
        protected string LTorneo = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Coneccion a = new Coneccion();
            string torneos = a.getTorneos();

            string[] torneo = torneos.Split(';');

            for (int i = 0; i < (torneo.Length - 1); i++)
            {
                string[] opcion = torneo[i].Split(',');

                LTorneo += "<option value=\"" + opcion[0] + "\">" + opcion[1] + "</option>\n";
            }


            if (!IsPostBack)
            {

                string Torneo = Request.Form["Torneos"];

                if (Torneo != null)
                {

                    string equipos = a.getRankingT(Torneo);

                    string[] equipo = equipos.Split(';');

                    for (int i = 0; i < equipo.Length - 1; i++)
                    {
                        string[] b = equipo[i].Split(',');

                        ListaE += "<tr><td>" + b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td></tr>\n ";


                    }


                }


            }
        }
    }
}