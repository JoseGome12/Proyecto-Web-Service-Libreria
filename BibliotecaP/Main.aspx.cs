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
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string datoRecibido = Request.QueryString["idusuario"];
            using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
            {
                string datosLibro = client.Verlibros();
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
                        row.Cells[0].Text = "<img src='Portadas/" + (i + 1) + ".jpg' />";
                    }
                }

            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string IddatoRecibido = Request.QueryString["idusuario"];
            if (e.CommandName == "Añadir")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                
                string idLibrovalue = GridView1.Rows[rowIndex].Cells[2].Text;
                string nombrelibro = GridView1.Rows[rowIndex].Cells[3].Text;
                Response.Write("<script>alert(' Se ha añadido el libro: "+ nombrelibro + " a tu colección');</script>");

                using (Miservicio.WebServiceSoapClient client = new Miservicio.WebServiceSoapClient())
                {
                    bool veriAñadirLibro = client.AgregarLibro(IddatoRecibido, idLibrovalue);
                    if (veriAñadirLibro == true)
                    {
                        Response.Write("<script>alert(' Se ha añadido el libro: " + nombrelibro + " a tu colección');</script>");
                    } else
                    {
                        Response.Write("<script>alert(' No se a podido añadir');</script>");
                    }
                
                
                }

            }
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
    }
}