using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Partido : System.Web.UI.Page
    {
        protected string PSede = "";
        protected string PFecha = "";
        protected string Phora = "";
        protected string Pcental = "";
        protected string Pasis1 = "";
        protected string Pasis2 = "";
        protected string Ptorneo = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            string codigo = Request.QueryString["codigo"];

            Coneccion a = new Coneccion();

            string players = a.getPartidoD(codigo);

            string[] jugadores = players.Split(',');

            PSede = jugadores[0];
            PFecha = jugadores[1];
            Phora = jugadores[2];
            Ptorneo = jugadores[3];
            Pcental = jugadores[4];
            Pasis1 = jugadores[5];
            Pasis2 = jugadores[6];






        }
    }
}