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
    public partial class NewAyudante : System.Web.UI.Page
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
            txt_fechanacimiento.Text = cal_fechanacimiento.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            ayudante nuevoAyudante = new ayudante();
           
            nuevoAyudante.nombres = txt_nombres.Text;
            nuevoAyudante.cedula = Convert.ToInt32(txt_cedula.Text);
            nuevoAyudante.fechanac = Convert.ToDateTime(txt_fechanacimiento.Text);
            nuevoAyudante.direccion = txt_direccion.Text;
            nuevoAyudante.telefono = Convert.ToInt32(txt_telefono.Text);
            nuevoAyudante.sexo = Convert.ToInt32(ddl_sexo.SelectedValue);

            GAC_Ayudante_10_Logica datos = new GAC_Ayudante_10_Logica();
            datos.newAyudante(nuevoAyudante);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchAyudante.aspx");
        }
    }
}