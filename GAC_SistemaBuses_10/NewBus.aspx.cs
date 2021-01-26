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
    public partial class NewBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<tipos> listtipos = new List<tipos>();
                GAC_Tipos_10_Logica datos0 = new GAC_Tipos_10_Logica();
                listtipos = datos0.getTipos();
                ddl_TipoBus.DataSource = listtipos;
                ddl_TipoBus.DataTextField = "tipo";
                ddl_TipoBus.DataValueField = "id_tipos";
                ddl_TipoBus.DataBind();

                List<operador> listoperadores = new List<operador>();
                GAC_Operador_10_Logica datos2 = new GAC_Operador_10_Logica();
                listoperadores = datos2.getOperadores();
                ddl_Operador.DataSource = listoperadores;
                ddl_Operador.DataTextField = "nombres";
                ddl_Operador.DataValueField = "id_operador";
                ddl_Operador.DataBind();

                List<ayudante> listayudantes = new List<ayudante>();
                GAC_Ayudante_10_Logica datos3 = new GAC_Ayudante_10_Logica();
                listayudantes = datos3.getAyudantes();
                ddl_Ayudante.DataSource = listayudantes;
                ddl_Ayudante.DataTextField = "nombres";
                ddl_Ayudante.DataValueField = "id_ayudante";
                ddl_Ayudante.DataBind();

            }

        }

        protected void cal_FechaCreacion_SelectionChanged(object sender, EventArgs e)
        {
            txt_FechaFabricacion.Text = cal_FechaFabricacion.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            bus nuevoBus = new bus();
            nuevoBus.id_tipos = Convert.ToInt32(ddl_TipoBus.SelectedValue);
            nuevoBus.id_operador = Convert.ToInt32(ddl_Operador.SelectedValue);
            nuevoBus.id_ayudante = Convert.ToInt32(ddl_Ayudante.SelectedValue);
            nuevoBus.unidad = txt_Unidad.Text;
            nuevoBus.marca = txt_Marca.Text;
            nuevoBus.color = txt_Color.Text;
            nuevoBus.añofabricacion = Convert.ToDateTime(txt_FechaFabricacion.Text);
           

            GAC_Bus_10_Logica datos = new GAC_Bus_10_Logica();
            datos.newBus(nuevoBus);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBus.aspx");
        }
    }
}