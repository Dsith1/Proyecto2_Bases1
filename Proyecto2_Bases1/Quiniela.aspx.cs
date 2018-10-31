using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Quiniela : System.Web.UI.Page
    {
        protected string ListaT = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            string P = Request.QueryString["p"];

            Coneccion a = new Coneccion();

            string torneos = a.getQUinielas(Usuario);

            string[] torneo = torneos.Split(';');

            for (int i = 0; i < torneo.Length - 1; i++)
            {
                string[] b = torneo[i].Split(',');

                if (b[3].Equals("0"))
                {
                    ListaT += "<tr><td>" + b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td><td><a href=\"Quiniela.aspx?Cuenta=" + Usuario + "&p=+" + b[0] + "\">Participar</a></td></tr>\n ";
                }
                else
                {
                    ListaT += "<tr><td>" + b[0] + "</td><td>" + b[1] + "</td><td>" + b[2] + "</td><td>Participando</td></tr>\n ";
                }
            }

            if (P != null)
            {
                string operacion = P + "," + Usuario;

                a = new Coneccion("EntrarQuiniela", operacion, 2);
            }
        }
    }
}