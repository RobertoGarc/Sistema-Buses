using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Rutas_10_Logica
    {
        public void newRuta(rutas nuevoRuta)
        {
            GAC_Rutas_10_Repository datos = new GAC_Rutas_10_Repository();
            datos.NewRuta(nuevoRuta);
        }

        public void updateRuta(rutas atcRuta)
        {
            GAC_Rutas_10_Repository datos = new GAC_Rutas_10_Repository();
            datos.UpdateRuta(atcRuta);
        }

        public void deleteRuta(rutas borrarRuta)
        {
            GAC_Rutas_10_Repository datos = new GAC_Rutas_10_Repository();
            datos.DeleteRuta(borrarRuta);
        }

        public List<rutas> getRutas()
        {
            List<rutas> listrutas = new List<rutas>();
            GAC_Rutas_10_Repository datos = new GAC_Rutas_10_Repository();
            listrutas = datos.getRutas();
            return listrutas;
        }

        public List<rutas> getRutas_id(int id_Ruta)
        {
            List<rutas> listrutas = new List<rutas>();
            GAC_Rutas_10_Repository datos = new GAC_Rutas_10_Repository();
            listrutas = datos.getRutas_id(id_Ruta);
            return listrutas;
        }
    }
}
