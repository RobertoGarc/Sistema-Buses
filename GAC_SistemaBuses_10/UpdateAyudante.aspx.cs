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
    public partial class UpdateAyudante : System.Web.UI.Page
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

                int idayudante = Convert.ToInt32(Session["id_ayudante"]);
                GAC_Ayudante_10_Logica datos6 = new GAC_Ayudante_10_Logica();
                ayudante registro_ayudante = new ayudante();
                registro_ayudante = datos6.getRegistroAyudante(idayudante);

                txt_id.Text = registro_ayudante.id_ayudante.ToString();

                txt_nombres.Text = registro_ayudante.nombres.ToString();
                txt_cedula.Text = registro_ayudante.cedula.ToString();
                txt_fechanacimiento.Text = registro_ayudante.fechanac.ToString();
                txt_direccion.Text = registro_ayudante.direccion.ToString();
                txt_telefono.Text = registro_ayudante.telefono.ToString();
                
                ddl_sexo.SelectedValue = registro_ayudante.sexo.ToString();

            }
        }

        protected void cal_FechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txt_fechanacimiento.Text = cal_fechanacimiento.SelectedDate.Date.ToShortDateString();
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ayudante nuevoAyudante = new ayudante();
            nuevoAyudante.id_ayudante = Convert.ToInt32(txt_id.Text);
            nuevoAyudante.nombres = txt_nombres.Text;
            nuevoAyudante.cedula = Convert.ToInt32(txt_cedula.Text);
            nuevoAyudante.fechanac = Convert.ToDateTime(txt_fechanacimiento.Text);
            nuevoAyudante.direccion = txt_direccion.Text;
            nuevoAyudante.telefono = Convert.ToInt32(txt_telefono.Text);
            nuevoAyudante.sexo = Convert.ToInt32(ddl_sexo.SelectedValue);

            GAC_Ayudante_10_Logica datos = new GAC_Ayudante_10_Logica();
            datos.updateAyudante(nuevoAyudante);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchAyudante.aspx");
        }

    }
}