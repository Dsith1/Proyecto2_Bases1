using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class CargaPronostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile file = Request.Files["Archivo"];

            Coneccion a = new Coneccion();

            if (file != null)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFile archivo = Request.Files[i];
                    if (archivo.ContentLength > 0)
                    {
                        string info = new StreamReader(archivo.InputStream).ReadToEnd();

                        string[] datos = info.Split(new[] { "\r\n" }, StringSplitOptions.None);

                        for (int x = 1; x < datos.Length - 1; x++)
                        {

                            string[] Pronostico = datos[x].Split(',');

                            string fecha = Pronostico[0];
                            string Hora = Pronostico[1];
                            string Usuario = Pronostico[2];
                            string local = Pronostico[3];
                            string glocal = Pronostico[4];
                            string visitante = Pronostico[6];
                            string gvisitante = Pronostico[5];

                            local = a.getEquipoN(local);
                            visitante = a.getEquipoN(visitante);

                            string partido = a.getPartidoN(local,visitante);

                            string operacion = partido + "," + local + "," + glocal + "," + visitante + "," + gvisitante + "," + Usuario;

                            a = new Coneccion("ResultadoUsuario", operacion, 3);


                        }


                    }
                }
            }
        }
    }
}