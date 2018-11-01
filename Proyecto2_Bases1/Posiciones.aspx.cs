using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Posiciones : System.Web.UI.Page
    {
        protected string ListaE = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Coneccion a = new Coneccion();




            string equipos = a.getRanking();

            string[] equipo = equipos.Split(';');

            for (int i = 0; i < equipo.Length - 1; i++)
            {
                string[] b = equipo[i].Split(',');

                ListaE += "<tr><td>" + b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td></tr>\n ";


            }



        }

    }
}