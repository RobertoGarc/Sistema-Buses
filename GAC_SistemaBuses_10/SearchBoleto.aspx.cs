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
    public partial class SearchBoleto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Boleto_10_Logica datos = new GAC_Boleto_10_Logica();
            List<boleto> listboletos = new List<boleto>();

            if (txt_Criterio.Text == string.Empty)
            {
                listboletos = datos.getBoletos();
            }
            else
            {
                listboletos = datos.getBoletos_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Buses.DataSource = listboletos;
            gv_Buses.DataBind();
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewBoleto.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void gv_Buses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idboleto = Convert.ToInt32(gv_Buses.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_boleto"] = idboleto;
                Response.Redirect("UpdateBoleto.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                boleto borrarboleto = new boleto();
                List<boleto> listboleto = new List<boleto>();
                GAC_Boleto_10_Logica datos = new GAC_Boleto_10_Logica();

                listboleto = datos.getBoletos_id(idboleto);
                foreach (boleto registro in listboleto)
                {
                    borrarboleto.id_boleto = registro.id_boleto;
                   
                    borrarboleto.horasalida = registro.horasalida;

                    borrarboleto.fechasalida = registro.fechasalida;
                    borrarboleto.asientos = registro.asientos;
                    borrarboleto.precio = registro.precio;
                    
                }
                datos.deleteBoleto(borrarboleto);
            }
        }
    }
}