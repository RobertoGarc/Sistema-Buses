using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Pasajero_10_Logica
    {
        public void newPasajero (pasajero nuevoPasajero)
        {
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            datos.NewPasajero (nuevoPasajero);
        }

        public void updatePasajero (pasajero atcPasajero)
        {
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            datos.UpdatePasajero (atcPasajero);
        }

        public void deletePasajero (pasajero borrarPasajero)
        {
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            datos.DeletePasajero(borrarPasajero);
        }

        public List<pasajero> getPasajeros()
        {
            List<pasajero> listpasajeros = new List<pasajero>();
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            listpasajeros = datos.getPasajeros();
            return listpasajeros;
        }

        public List<pasajero> getPasajeros_id(int id_Pasajero)
        {
            List<pasajero> listpasajeros = new List<pasajero>();
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            listpasajeros = datos.getPasajeros_id(id_Pasajero);
            return listpasajeros;
        }

        public pasajero getRegistroPasajero(int Registro_id)
        {
            pasajero listaregistros = new pasajero();
            GAC_Pasajero_10_Repository datos = new GAC_Pasajero_10_Repository();
            listaregistros = datos.getRegistroPasajero(Registro_id);
            return listaregistros;
        }
    }
}
