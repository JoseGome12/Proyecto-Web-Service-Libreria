using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibliotecaP
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }
        public void Verificacion()
        {


         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
            {
                string usuario = usuariobox.Text;
                string contrasenna = TextBox1.Text;
                bool veri = client.VerificarUsuario(usuario, contrasenna);
                if (veri == true)
                {
                    Response.Write("<script>alert('Usuario encontrado');</script>");
                    int idusuario = client.IdUsuario(usuario, contrasenna);
                    string datoid = idusuario.ToString();
                    string url = "Main.aspx?idusuario=" + Server.UrlEncode(datoid);
                    Response.Redirect(url);
                }
                else
                {
                    Response.Write("<script>alert('Usuario no  encontrado');</script>");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");
        }
    }

        }
    
