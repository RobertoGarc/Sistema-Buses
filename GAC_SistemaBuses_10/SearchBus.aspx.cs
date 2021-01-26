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
    public partial class SearchBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Bus_10_Logica datos = new GAC_Bus_10_Logica();
            List<bus> listbuses = new List<bus>();

            if (txt_Criterio.Text == string.Empty)
            {
                listbuses = datos.getBuses();
            }
            else
            {
                listbuses = datos.getBuses_id(Convert.ToInt32(txt_Criterio.Text));
            }
           
            gv_Buses.DataSource = listbuses;
            gv_Buses.DataBind();
        }

        protected void gv_Buses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idbus = Convert.ToInt32(gv_Buses.Rows[indice].Cells[0].Text);

            if(e.CommandName=="Actualizar")
            {
                Session["id_bus"] = idbus;
                Response.Redirect("UpdateBus.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                bus borrarbus = new bus();
                List<bus> listbus = new List<bus>();
                GAC_Bus_10_Logica datos = new GAC_Bus_10_Logica();

                listbus = datos.getBuses_id(idbus);
                foreach(bus registro in listbus)
                {
                    borrarbus.id_bus = registro.id_bus;
                    borrarbus.id_tipos = registro.id_tipos;
                    borrarbus.id_rutas = registro.id_rutas;
                    borrarbus.id_operador = registro.id_operador;
                    borrarbus.id_ayudante = registro.id_ayudante;

                    borrarbus.marca = registro.marca;
                    borrarbus.unidad = registro.unidad;
                    borrarbus.color = registro.color;
                    borrarbus.añofabricacion = registro.añofabricacion;
                    borrarbus.id_boleto = registro.id_boleto;
                }
                datos.deleteBus(borrarbus);
            }
        }

    

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewBus.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}