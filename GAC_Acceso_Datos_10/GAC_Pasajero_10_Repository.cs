using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Pasajero_10_Repository
    {

        public void NewPasajero (pasajero nuevoPasajero)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.pasajero.Add(nuevoPasajero);
                context.SaveChanges();
            }
        }

        public void UpdatePasajero(pasajero atcPasajero)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.pasajero.Attach(atcPasajero);
                context.Entry(atcPasajero).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletePasajero(pasajero borrarPasajero)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.pasajero.Attach(borrarPasajero);
                context.Entry(borrarPasajero).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<pasajero> getPasajeros()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listpasajeros = from listpasajero in context.pasajero 
                                select listpasajero;
                return listpasajeros.ToList();
            }
        }

        public List<pasajero> getPasajeros_id(int id_Pasajero)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listpasajeros = from listpasajero in context.pasajero 
                                where listpasajero.id_pasajero==id_Pasajero 
                                select listpasajero;
                return listpasajeros.ToList();
            }
        }

        public pasajero getRegistroPasajero(int registro_id)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var registros = from registro in context.pasajero
                                where registro.id_pasajero == registro_id
                                select registro;
                return registros.First<pasajero>();
            }
        }

    }
}
