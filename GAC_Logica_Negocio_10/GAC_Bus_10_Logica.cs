using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Bus_10_Logica
    {
        public void newBus(bus nuevoBus)
        {
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            datos.NewBus(nuevoBus);
        }

        public void updateBus(bus atcBus)
        {
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            datos.UpdateBus(atcBus);
        }

        public void deleteBus(bus borrarBus)
        {
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            datos.DeleteBus(borrarBus);
        }

        public List<bus> getBuses()
        {
            List<bus> listbuses = new List<bus>();
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            listbuses = datos.getBuses();
            return listbuses;
        }

        public List<bus> getBuses_id(int id_Bus)
        {
            List<bus> listbuses = new List<bus>();
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            listbuses = datos.getBuses_id(id_Bus);
            return listbuses;
        }

        public bus getRegistroBus(int Registro_id)
        {
            bus listaregistros = new bus();
            GAC_Bus_10_Repository datos = new GAC_Bus_10_Repository();
            listaregistros = datos.getRegistroBus(Registro_id);
            return listaregistros;
        }

    }
}
