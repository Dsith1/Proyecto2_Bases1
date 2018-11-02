using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class CargaMarcadores : System.Web.UI.Page
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

                            string[] Marcador = datos[x].Split(',');

                            string fecha = Marcador[0];
                            string Hora = Marcador[1];
                            string local = Marcador[2];
                            string glocal = Marcador[3];
                            string visitante = Marcador[5];
                            string gvisitante = Marcador[4];


                            local = a.getEquipoN(local);
                            visitante = a.getEquipoN(visitante);

                            string partido = a.getPartidoN(local, visitante);

                            string operacion = partido + "," + local + "," + glocal + "," + visitante + "," + gvisitante + ",1";

                            a = new Coneccion("ResultadoReal", operacion, 4);


                        }


                    }
                }
            }
        }
    }
}