using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class CargaUsuarios : System.Web.UI.Page
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
                        string info= new StreamReader(archivo.InputStream).ReadToEnd();

                        string[] datos = info.Split(new[] { "\r\n" }, StringSplitOptions.None);

                        for(int x=1;x< datos.Length - 1; x++){

                            string[] usuario = datos[x].Split(',');

                            string ncompleto = usuario[0];
                            string edad = usuario[1];
                            string pais = usuario[2];

                            bool epais = a.getPaisNE(pais);

                            if (epais)
                            {
                                pais = a.getPaisN(pais);
                            }
                            else
                            {
                                string op = pais + ",";
                                a = new Coneccion("NuevoPais", op, 5);
                                pais = a.getPaisN(pais);
                            }

                            string[] persona = ncompleto.Split(' ');
                            string nombre = persona[0];
                            string apellido = persona[1];

                            string operacion = ncompleto + "," + nombre + "," + apellido + ",123," + pais + "," + edad;
                            a = new Coneccion("NuevoUser", operacion, 1);

                            string pago = usuario[3];

                            if (pago.Equals("100"))
                            {
                                operacion = "1," + ncompleto;
                                a = new Coneccion("EntrarQuiniela", operacion, 2);
                            }
                            
                        }


                    }
                }
            }
        }
    }
}