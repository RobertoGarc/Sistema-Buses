using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GAC_Logica_Negocio_10;
using GAC_Entidades_10;

namespace GAC_SistemaBuses_10
{
    public partial class NewPasajero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<sexo> listsexos = new List<sexo>();
                GAC_Sexo_10_Logica datos0 = new GAC_Sexo_10_Logica();
                listsexos = datos0.getSexos();
                ddl_sexo.DataSource = listsexos;
                ddl_sexo.DataTextField = "sexo1";
                ddl_sexo.DataValueField = "id_sexo";
                ddl_sexo.DataBind();

            }

        }

        protected void cal_FechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txt_FechaNacimiento.Text = cal_FechaNacimiento.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            pasajero nuevoPasajero = new pasajero();
            
            nuevoPasajero.nombre = txt_nombre.Text;
            nuevoPasajero.apellido = txt_apellido.Text;
            nuevoPasajero.cedula = Convert.ToInt32(txt_cedula.Text);
            nuevoPasajero.direccion = txt_direccion.Text;
            nuevoPasajero.telefono = txt_telefono.Text;
            nuevoPasajero.fechanacimiento = Convert.ToDateTime(txt_FechaNacimiento.Text);
            nuevoPasajero.sexo = Convert.ToInt32(ddl_sexo.SelectedValue);

            GAC_Pasajero_10_Logica datos = new GAC_Pasajero_10_Logica();
            datos.newPasajero(nuevoPasajero);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchPasajero.aspx");
        }
    }
}