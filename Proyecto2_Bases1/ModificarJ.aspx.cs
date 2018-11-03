using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class ModificarJ : System.Web.UI.Page
    {
        protected string OPais = "";
        protected string Nnombre = "";
        protected string Ngoles = "";
        protected string NPortero = "";
        protected string NDefensa = "";
        protected string NMedio = "";
        protected string NDelantero = "";
        protected string Nestatura = "";
        protected string Npeso = "";
        protected string Nnacimiento = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Coneccion a = new Coneccion();
            string LPaises = a.getPaises();
            string codj = Request.QueryString["codigo"];

            string pais = a.getJugadorPais(codj);

            string djugador = a.getJugadoresD(codj);

            string[] detalle = djugador.Split(',');

            Nnombre = detalle[0];
            Ngoles = detalle[1];
            string posicion = detalle[2];

            if (posicion.Equals("GK"))
            {
                NPortero = "selected=\"selected\"";

            }
            else if (posicion.Equals("DF"))
            {
                NDefensa = "selected=\"selected\"";

            }
            else if (posicion.Equals("MF"))
            {
                NMedio = "selected=\"selected\"";
            }
            else if (posicion.Equals("FW"))
            {
                NDelantero= "selected=\"selected\"";
            }

            Nestatura = detalle[3];
            Npeso = detalle[4];
            Nnacimiento = detalle[6];


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



            if (!IsPostBack)
            {
                string Nombre = Request.Form["Nombre"];

                if (Nombre != null)
                {
                    string Posicion = Request.Form["Posicion"];
                    string Goles = Request.Form["Goles"];
                    string Estatura = Request.Form["Estatura"];
                    string Peso = Request.Form["Peso"];
                    string Nacimiento = Request.Form["Nacimiento"];
                    string Pais = Request.Form["Pais"];

                    string Operacion = codj+","+Nombre + "," + Posicion + "," + Estatura + "," + Peso + "," + Goles+","+Pais + "," + Nacimiento;

                    a = new Coneccion("ActualizarJugador", Operacion, 10);
                }
            }
        }
    }
}