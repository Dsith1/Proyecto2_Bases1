using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Grupos : System.Web.UI.Page
    {
        protected string ListaE = "";
        protected string LTorneo = "";
        protected string LGrupos = "";

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
                string Grupo = Request.Form["Grupos"];

                if (Torneo != null)
                {

                    if (Torneo != "")
                    {

                        string grupos = a.getGrupos(Torneo);

                        string[] grupo = grupos.Split(';');

                        for (int i = 0; i < (grupo.Length - 1); i++)
                        {
                            string[] opcion = grupo[i].Split(',');

                            LGrupos += "<option value=\"" + opcion[0] + "\">" + opcion[1] + "</option>\n";
                        }
                    }


                }

                if (Grupo != null)
                {

                    if (Grupo != "")
                    {
                        string equipos = a.getRankingG(Grupo);

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
}