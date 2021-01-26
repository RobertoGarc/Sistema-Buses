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
    public partial class UpdateOperador : System.Web.UI.Page
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
                

                int idoperador = Convert.ToInt32(Session["id_operador"]);
                GAC_Operador_10_Logica datos6 = new GAC_Operador_10_Logica();
                operador registro_operador = new operador();
                registro_operador = datos6.getRegistroOperador(idoperador);

                txt_idOperador.Text = registro_operador.id_operador.ToString();
                txt_nombre.Text = registro_operador.nombres.ToString();
                txt_cedula.Text = registro_operador.cedula.ToString();
                txt_fechaNacimiento.Text = registro_operador.fechanac.ToString();
                txt_direccion.Text = registro_operador.direccion.ToString();
                txt_telefono.Text = registro_operador.telefono.ToString();
                ddl_bus.SelectedValue = registro_operador.id_bus.ToString();
                ddl_Sexo.SelectedValue = registro_operador.sexo.ToString();

            }

        }

        protected void cal_fechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txt_fechaNacimiento.Text = cal_fechaNacimiento.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            operador nuevoOperador = new operador();
            nuevoOperador.id_operador = Convert.ToInt32(txt_idOperador.Text);
            nuevoOperador.nombres = txt_nombre.Text;
            nuevoOperador.cedula = Convert.ToInt32(txt_cedula.Text);
            nuevoOperador.fechanac = Convert.ToDateTime(txt_fechaNacimiento.Text);
            nuevoOperador.direccion = txt_direccion.Text;
            nuevoOperador.telefono = Convert.ToInt32(txt_telefono.Text);
            nuevoOperador.id_bus = Convert.ToInt32(ddl_bus.SelectedValue);
            nuevoOperador.sexo = Convert.ToInt32(ddl_Sexo.SelectedValue);


            GAC_Operador_10_Logica datos = new GAC_Operador_10_Logica();
            datos.updateOperador(nuevoOperador);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchOperador.aspx");
        }
    }
}