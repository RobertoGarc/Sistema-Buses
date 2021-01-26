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
    public partial class SearchPasajero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }


        protected void lb_Buscar_Click(object sender, EventArgs e)
        {
            GAC_Pasajero_10_Logica datos = new GAC_Pasajero_10_Logica();
            List<pasajero> listpasajeros = new List<pasajero>();

            if (txt_Criterio.Text == string.Empty)
            {
                listpasajeros = datos.getPasajeros();
            }
            else
            {
                listpasajeros = datos.getPasajeros_id(Convert.ToInt32(txt_Criterio.Text));
            }

            gv_Pasajeros.DataSource = listpasajeros;
            gv_Pasajeros.DataBind();
        }

        protected void gv_Pasajeros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int idpasajero = Convert.ToInt32(gv_Pasajeros.Rows[indice].Cells[0].Text);

            if (e.CommandName == "Actualizar")
            {
                Session["id_pasajero"] = idpasajero;
                Response.Redirect("UpdatePasajero.aspx");
            }

            if (e.CommandName == "Eliminar")
            {
                pasajero borrarpasajero = new pasajero();
                List<pasajero> listpasajero = new List<pasajero>();
                GAC_Pasajero_10_Logica datos = new GAC_Pasajero_10_Logica();

                listpasajero = datos.getPasajeros_id(idpasajero);
                foreach (pasajero registro in listpasajero)
                {
                    borrarpasajero.id_pasajero = registro.id_pasajero;
                    

                    borrarpasajero.nombre = registro.nombre;
                    borrarpasajero.apellido = registro.apellido;
                    borrarpasajero.cedula = registro.cedula;
                    borrarpasajero.direccion = registro.direccion;
                    borrarpasajero.telefono = registro.telefono;
                    borrarpasajero.fechanacimiento = registro.fechanacimiento;
                }
                datos.deletePasajero(borrarpasajero);
            }
        }

        protected void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewPasajero.aspx");
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

    }
}