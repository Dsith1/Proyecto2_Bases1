using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Pronostico : System.Web.UI.Page
    {
        protected string Glocal = "";
        protected string Gvisitante = "";
        protected string Nomlocal = "";
        protected string Nomvisitante = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario = Request.QueryString["Cuenta"];
            string cpartido = Request.QueryString["codigo"];
            string Nlocal = Request.Form["Local"];
            string NVisitante = Request.Form["Visitante"];
            int update=0;

            Coneccion a = new Coneccion();

            string resultado = a.getResultado(Usuario, cpartido);

            string nombres = a.getEpartido(cpartido);

            string[] nombre = nombres.Split(',');

            Nomlocal = nombre[0];
            Nomvisitante = nombre[1];

            if (resultado != "")
            {
                update = 1;
                string[] datos = resultado.Split(',');

                Glocal = datos[1];
                Gvisitante = datos[2];
            }

            if(!IsPostBack){

                string idlocal = a.getNOmbreE(Nomlocal);
                string idvisita = a.getNOmbreE(Nomvisitante);
                string idtorneo = a.getTorneoP(cpartido);

                string operacion = cpartido + "," + idlocal + "," + Nlocal + "," + idvisita + "," + NVisitante + "," + Usuario;

                if (update == 1)
                {
                    if (Nlocal != null && NVisitante != null)
                    {

                        a = new Coneccion("ActulizaResultadoUser", operacion, 3);
                        Response.Redirect(Request.RawUrl);
                    }

                }
                else
                {
                    if (Nlocal != null && NVisitante!= null)
                    {
                        
                        a = new Coneccion("ResultadoUsuario", operacion, 3);
                        Response.Redirect(Request.RawUrl);
                    }

                    

                }
            }

        }
    }
}