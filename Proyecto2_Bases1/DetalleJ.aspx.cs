using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class DetalleJ : System.Web.UI.Page
    {
        protected string Jnombre = "";
        protected string Jgoles = "";
        protected string Jdorsal = "";
        protected string Jposicion = "";
        protected string Jaltura = "";
        protected string Jpeso = "";
        protected string Jedad = "";
        protected string Jnacimiento = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            string codigo = Request.QueryString["codigo"];

            Coneccion a = new Coneccion();

            string players = a.getJugadoresD(codigo);

            string[] jugadores = players.Split(',');

            Jnombre = jugadores[0];
            Jgoles = jugadores[1];
            Jposicion = jugadores[2];
            Jaltura = jugadores[3];
            Jpeso = jugadores[4];
            Jedad = jugadores[5];
            Jnacimiento = jugadores[6];





        }
    }
}