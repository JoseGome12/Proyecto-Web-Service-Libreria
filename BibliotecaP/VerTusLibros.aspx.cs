using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace BibliotecaP
{
    public partial class VerTusLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string datoRecibido = Request.QueryString["idusuario"];
            using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
            {
                string datosLibro = client.VerTusLibors(datoRecibido);
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(new StringReader(datosLibro));
                if (dataSet.Tables.Count > 0)
                {
                    // Obtener la primera tabla del DataSet
                    DataTable dataTable = dataSet.Tables[0];
                    GridView1.DataSource = dataTable;
                    // Asignar los datos al GridView
                    GridView1.DataBind();


                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {
                        // Establecer la ruta de la imagen para cada columna
                        GridViewRow row = GridView1.Rows[i];
                        string idLibroP = row.Cells[3].Text;
                        row.Cells[0].Text = "<img src='Portadas/" + idLibroP + ".jpg' />";
                    }
                }

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void MisLibros_Click()
        {
            Response.Redirect("CrearUsuario.aspx?idUsuario=123");
        }

        protected void LinkMisLibros_Click(object sender, EventArgs e)
        {
            string IddatoRecibido = Request.QueryString["idusuario"];
            Response.Redirect("VerTusLibros.aspx?idusuario=" + IddatoRecibido);
        }

        protected void LinkInicio_Click(object sender, EventArgs e)
        {
            string IddatoRecibido = Request.QueryString["idusuario"];
            Response.Redirect("Main.aspx?idusuario=" + IddatoRecibido);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            string idLibrovalue = GridView1.Rows[rowIndex].Cells[2].Text;
            Response.Write("<script>alert("+ idLibrovalue +");</script>");
            using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
            {
                bool respuesta = client.EliminarLibro(idLibrovalue);
                if (respuesta == true)
                {
      
                    Response.Write("<script>alert(Se ha eliminado el libro);</script>");
                    string IddatoRecibido = Request.QueryString["idusuario"];
                    Response.Redirect("VerTusLibros.aspx?idusuario=" + IddatoRecibido);
                }
               

            }
        }
    }
}