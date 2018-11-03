using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class ModificarE : System.Web.UI.Page
    {
        protected string OPais = "";
        protected string PNombre = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            string cpais = Request.QueryString["codigo"];

            Coneccion a = new Coneccion();
            string LPaises = a.getPaises();

            string nombreE = a.getEquipoNombre(cpais);

            PNombre = nombreE;

            nombreE = Request.Form["Nombre"];

            string pais = a.getEquipoPais(cpais);

            string[] Paises = LPaises.Split(';');

            for (int i = 0; i < (Paises.Length - 1); i++)
            {
                string[] opcion = Paises[i].Split(',');

                if (opcion[0].Equals(pais))
                {
                    OPais += "<option value=\"" + opcion[0] + "\" selected=\"selected\">" + opcion[1] + "</option>\n";
                }
                else
                {
                    OPais += "<option value=\"" + opcion[0] + "\">" + opcion[1] + "</option>\n";
                }

                
            }
            string Pais = Request.Form["Pais"];

            string operacion =cpais+","+ nombreE + "," + Pais;
            a = new Coneccion("ActualizarEQuipo", operacion, 8);



        }
    }
}