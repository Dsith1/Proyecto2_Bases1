using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class AgregarEquipo : System.Web.UI.Page
    {
        protected string OPais = "";

        protected void Page_Load(object sender, EventArgs e)
        {



            Coneccion a = new Coneccion();
            string LPaises = a.getPaises();

            string[] Paises = LPaises.Split(';');

            for (int i = 0; i < (Paises.Length - 1); i++)
            {
                string[] opcion = Paises[i].Split(',');

                OPais += "<option value=\"" + opcion[0] + "\">" + opcion[1] + "</option>\n";
            }


            if (!IsPostBack)
            {
                string Nombre = Request.Form["Nombre"];

                if (Nombre != null)
                {
                    string Pais = Request.Form["Pais"];

                    string operacion = Nombre + "," + Pais;
                    a = new Coneccion("NuevoEQuipo", operacion, 6);

                }


            }
            else
            {

            }
        }
    }
}