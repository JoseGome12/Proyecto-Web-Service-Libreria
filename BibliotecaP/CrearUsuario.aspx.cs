using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaP
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
            {
                string usuario = usuariobox.Text;
                string contrasenna = TextBox1.Text;
                bool veri = client.CrearUsuario(usuario,contrasenna);
                if (veri == true)
                {
                    Response.Write("<script>confirm('Creado');</script>");
                    string url = "login.aspx";
                    Response.Redirect(url);
                }
                else
                {
                    Response.Write("<script>alert('Usuario no  encontrado');</script>");
                }
            }
        }
    }
}