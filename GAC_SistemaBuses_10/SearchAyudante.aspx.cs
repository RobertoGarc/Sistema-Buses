using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Entidades_10;
using GAC_Logica_Negocio_10;

namespace GAC_SistemaBuses_10
{
    public partial class SearchAyudante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Ayudante_10_Logica datos = new GAC_Ayudante_10_Logica();
            List<ayudante> listayudantes = new List<ayudante>();

            if (txt_Criterio.Text == string.Empty)
            {
                listayudantes = datos.getAyudantes();
            }
            else
            {
                listayudantes = datos.getAyudante_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Ayudantes.DataSource = listayudantes;
            gv_Ayudantes.DataBind();
        }

        protected void gv_Ayudantes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idayudante = Convert.ToInt32(gv_Ayudantes.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_ayudante"] = idayudante;
                Response.Redirect("UpdateAyudante.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                ayudante borrarayudante = new ayudante();
                List<ayudante> listayudante = new List<ayudante>();
                GAC_Ayudante_10_Logica datos = new GAC_Ayudante_10_Logica();

                listayudante = datos.getAyudante_id(idayudante);
                foreach (ayudante registro in listayudante)
                {
                    borrarayudante.id_ayudante = registro.id_ayudante;
                    borrarayudante.nombres = registro.nombres;
                    borrarayudante.cedula = registro.cedula;
                    borrarayudante.fechanac = registro.fechanac;
                    borrarayudante.direccion = registro.direccion;
                    borrarayudante.telefono = registro.telefono;

                 
                }
                datos.deleteAyudante(borrarayudante);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewAyudante.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}