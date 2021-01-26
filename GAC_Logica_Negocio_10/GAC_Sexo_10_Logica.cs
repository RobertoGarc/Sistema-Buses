using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Sexo_10_Logica
    {
        public void newSexo (sexo nuevoSexo)
        {
            GAC_Sexo_10_Repository datos = new GAC_Sexo_10_Repository();
            datos.NewSexo (nuevoSexo);
        }

        public void updateSexo (sexo atcSexo)
        {
            GAC_Sexo_10_Repository datos = new GAC_Sexo_10_Repository();
            datos.UpdateSexo (atcSexo);
        }

        public void deleteSexo (sexo borrarSexo)
        {
            GAC_Sexo_10_Repository datos = new GAC_Sexo_10_Repository();
            datos.DeleteSexo(borrarSexo);
        }

        public List<sexo> getSexos()
        {
            List<sexo> listsexos = new List<sexo>();
            GAC_Sexo_10_Repository datos = new GAC_Sexo_10_Repository();
            listsexos = datos.getSexos();
            return listsexos;
        }

        public List<sexo> getSexos_id(int id_Sexo)
        {
            List<sexo> listsexos = new List<sexo>();
            GAC_Sexo_10_Repository datos = new GAC_Sexo_10_Repository();
            listsexos = datos.getSexos_id(id_Sexo);
            return listsexos;
        }
    }
}
