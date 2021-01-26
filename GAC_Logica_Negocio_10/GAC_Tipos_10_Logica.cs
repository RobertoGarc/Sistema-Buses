using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Tipos_10_Logica
    {
        public void newTipo(tipos nuevoTipo)
        {
            GAC_Tipos_10_Repository datos = new GAC_Tipos_10_Repository();
            datos.NewTipos(nuevoTipo);
        }

        public void updateTipo(tipos atcTipo)
        {
            GAC_Tipos_10_Repository datos = new GAC_Tipos_10_Repository();
            datos.UpdateTipos(atcTipo);
        }

        public void deleteTipo(tipos borrarTipo)
        {
            GAC_Tipos_10_Repository datos = new GAC_Tipos_10_Repository();
            datos.DeleteTipos(borrarTipo);
        }

        public List<tipos> getTipos()
        {
            List<tipos> listtipos = new List<tipos>();
            GAC_Tipos_10_Repository datos = new GAC_Tipos_10_Repository();
            listtipos = datos.getTipos();
            return listtipos;
        }

        public List<tipos> getTipos_id(int id_Tipo)
        {
            List<tipos> listtipos = new List<tipos>();
            GAC_Tipos_10_Repository datos = new GAC_Tipos_10_Repository();
            listtipos = datos.getTipos_id(id_Tipo);
            return listtipos;
        }
    }
}
