using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Ayudante_10_Logica
    {
        public void newAyudante(ayudante nuevoAyudante)
        {
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            datos.NewAyudante(nuevoAyudante);
        }

        public void updateAyudante(ayudante atcAyudante)
        {
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            datos.UpdateAyudante(atcAyudante);
        }

        public void deleteAyudante(ayudante borrarAyudante)
        {
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            datos.DeleteAyudante(borrarAyudante);
        }

        public List<ayudante> getAyudantes()
        {
            List<ayudante> listayudantes = new List<ayudante>();
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            listayudantes = datos.getAyudantes();
            return listayudantes;
        }

        public List<ayudante> getAyudante_id(int id_Ayudante)
        {
            List<ayudante> listayudantes = new List<ayudante>();
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            listayudantes = datos.getAyudantes_id(id_Ayudante);
            return listayudantes;
        }

        public ayudante getRegistroAyudante(int Registro_id)
        {
            ayudante listaregistros = new ayudante();
            GAC_Ayudante_10_Repository datos = new GAC_Ayudante_10_Repository();
            listaregistros = datos.getRegistroAyudante(Registro_id);
            return listaregistros;
        }
    }
}
