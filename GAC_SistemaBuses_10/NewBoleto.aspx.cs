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
    public partial class NewBoleto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<pasajero> listpasajeros = new List<pasajero>();
                GAC_Pasajero_10_Logica datos0 = new GAC_Pasajero_10_Logica();
                listpasajeros = datos0.getPasajeros();
                ddl_pasajero.DataSource = listpasajeros;
                ddl_pasajero.DataTextField = "cedula";
                ddl_pasajero.DataValueField = "id_pasajero";
                ddl_pasajero.DataBind();

                List<bus> listbuses = new List<bus>();
                GAC_Bus_10_Logica datos1 = new GAC_Bus_10_Logica();
                listbuses = datos1.getBuses();
                ddl_bus.DataSource = listbuses;
                ddl_bus.DataTextField = "unidad";
                ddl_bus.DataValueField = "id_bus";
                ddl_bus.DataBind();

                List<rutas> listrutas = new List<rutas>();
                GAC_Rutas_10_Logica datos2 = new GAC_Rutas_10_Logica();
                listrutas = datos2.getRutas();
                ddl_ruta.DataSource = listrutas;
                ddl_ruta.DataTextField = "rutas1";
                ddl_ruta.DataValueField = "id_rutas";
                ddl_ruta.DataBind();

                List<vendedor> listvendedores = new List<vendedor>();
                GAC_Vendedor_10_Logica datos3 = new GAC_Vendedor_10_Logica();
                listvendedores = datos3.getVendedores();
                ddl_vendedor.DataSource = listvendedores;
                ddl_vendedor.DataTextField = "nombres";
                ddl_vendedor.DataValueField = "id_vendedor";
                ddl_vendedor.DataBind();

            }
        }

        /*protected void cal_HoraSalida_SelectionChanged(object sender, EventArgs e)
        {
            txt_horasalida.Text = Convert.ToString(Cal_horasalida.SelectedDate.Date.ToLocalTime();
        }*/

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            boleto nuevoBoleto = new boleto();
            nuevoBoleto.id_pasajero = Convert.ToInt32(ddl_pasajero.SelectedValue);
            nuevoBoleto.id_bus = Convert.ToInt32(ddl_bus.SelectedValue);
            nuevoBoleto.id_ruta = Convert.ToInt32(ddl_ruta.SelectedValue);
            nuevoBoleto.horasalida = Convert.ToDateTime(txt_horasalida.Text);
            nuevoBoleto.fechasalida = Convert.ToDateTime(txt_salida.Text);
            nuevoBoleto.asientos = txt_asientos.Text;
            nuevoBoleto.precio = Convert.ToInt32(txt_precio.Text);
            nuevoBoleto.id_vendedor = Convert.ToInt32(ddl_vendedor.Text);
            

            GAC_Boleto_10_Logica datos = new GAC_Boleto_10_Logica();
            datos.newBoleto(nuevoBoleto);
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBoleto.aspx");
        }

        protected void cal_FechaSalida_SelectionChanged(object sender, EventArgs e)
        {
            txt_salida.Text = cal_FechaSalida.SelectedDate.Date.ToShortDateString();
        }
    }
}