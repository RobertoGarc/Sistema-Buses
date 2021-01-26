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
    public partial class NewOperador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<bus> listbuses = new List<bus>();
                GAC_Bus_10_Logica datos0 = new GAC_Bus_10_Logica();
                listbuses = datos0.getBuses();
                ddl_bus.DataSource = listbuses;
                ddl_bus.DataTextField = "unidad";
                ddl_bus.DataValueField = "id_bus";
                ddl_bus.DataBind();

                List<sexo> listsexo = new List<sexo>();
                GAC_Sexo_10_Logica datos1 = new GAC_Sexo_10_Logica();
                listsexo = datos1.getSexos();
                ddl_Sexo.DataSource = listsexo;
                ddl_Sexo.DataTextField = "sexo1";
                ddl_Sexo.DataValueField = "id_sexo";
                ddl_Sexo.DataBind();
                
               
            }
        }

        protected void cal_fechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txt_fechaNacimiento.Text = cal_fechaNacimiento.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            operador nuevoOperador = new operador();
         
            nuevoOperador.nombres = txt_nombre.Text;
            nuevoOperador.cedula = Convert.ToInt32(txt_cedula.Text);
            nuevoOperador.fechanac = Convert.ToDateTime(txt_fechaNacimiento.Text);
            nuevoOperador.direccion = txt_direccion.Text;
            nuevoOperador.telefono = Convert.ToInt32(txt_telefono.Text);
            nuevoOperador.id_bus = Convert.ToInt32(ddl_bus.SelectedValue);
            nuevoOperador.sexo = Convert.ToInt32(ddl_Sexo.SelectedValue);


            GAC_Operador_10_Logica datos = new GAC_Operador_10_Logica();
            datos.newOperador(nuevoOperador);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchOperador.aspx");
        }
    }
}