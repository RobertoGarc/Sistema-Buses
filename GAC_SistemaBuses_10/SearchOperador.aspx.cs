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
    public partial class SearchOperador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Operador_10_Logica datos = new GAC_Operador_10_Logica();
            List<operador> listoperadores = new List<operador>();

            if (txt_Criterio.Text == string.Empty)
            {
                listoperadores = datos.getOperadores();
            }
            else
            {
                listoperadores = datos.getOperadores_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Operadores.DataSource = listoperadores;
            gv_Operadores.DataBind();
        }

        protected void gv_Operadores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idoperador = Convert.ToInt32(gv_Operadores.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_operador"] = idoperador;
                Response.Redirect("UpdateOperador.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                operador borraroperador = new operador();
                List<operador> listoperador = new List<operador>();
                GAC_Operador_10_Logica datos = new GAC_Operador_10_Logica();

                listoperador = datos.getOperadores_id(idoperador);
                foreach (operador registro in listoperador)
                {
                    borraroperador.id_operador = registro.id_operador;
                    borraroperador.nombres = registro.nombres;
                    borraroperador.cedula = registro.cedula;
                    borraroperador.fechanac = registro.fechanac;
                    borraroperador.direccion = registro.direccion;

                    borraroperador.telefono = registro.telefono;
                    borraroperador.id_bus = registro.id_bus;
                }
                datos.deleteOperador(borraroperador);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewOperador.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}