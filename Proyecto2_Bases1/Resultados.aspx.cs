﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Resultados : System.Web.UI.Page
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

                ListaR += "<tr><td align=\"right\">" + b[0]+ "</td><td align=\"center\">" + b[1] + "</td><td  align=\"center\">" + b[2] + "</td><td>" + b[3] + "</td></tr>\n ";


            }
        }
    }
}