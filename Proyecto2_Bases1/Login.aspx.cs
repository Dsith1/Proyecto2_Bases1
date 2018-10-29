using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2_Bases1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Usuario;
            string Contra;

            if (!IsPostBack)
            {
                Usuario = Request.Form["Usuario"];

                if (Usuario != null)
                {

                    Contra = Request.Form["Contra"];

                    Coneccion a = new Coneccion();

                    string tipo = a.Login(Usuario, Contra);

                    if (tipo.Equals("1"))
                    {
                        Response.Redirect("MenuA.aspx?Cuenta=" + Usuario);
                    }
                    else if (tipo.Equals("0"))
                    {
                        Response.Redirect("Menu.aspx?Cuenta=" + Usuario);
                    }
                    else
                    {
                        Response.Write("<script>alert('Usuari/contraseña Incorrectos');</script>");
                    }
                }
            }
        }
    }
}