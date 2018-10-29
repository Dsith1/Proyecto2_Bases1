using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Registro : System.Web.UI.Page
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

                OPais += "<option value=\"" + opcion[0] + "\">" + opcion[1] +"</option>\n";
            }


            if (!IsPostBack)
            {
                string Usuario = Request.Form["Usuario"];

                if(Usuario != null)
                {
                    string contra1= Request.Form["Contra1"];
                    string contra2 = Request.Form["Contra2"];
                    string Nombre = Request.Form["Nombre"];
                    string Apellido = Request.Form["Apellido"];
                    string Edad = Request.Form["Edad"];
                    string Pais = Request.Form["Pais"];

                    if (contra1.Equals(contra2))
                    {
                        string operacion = Usuario + "," + Nombre + "," + Apellido + "," + contra1 + "," + Pais+","+ Edad;
                        a = new Coneccion("NuevoUser", operacion, 1);

                        Response.Write("<script>alert('Usuario Creado');</script>");
                        Response.Redirect("Inicio.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('No Coinciden las Contraseñas');</script>");

                    }
                }

               
            }
            else
            {

            }
        }
    }
}