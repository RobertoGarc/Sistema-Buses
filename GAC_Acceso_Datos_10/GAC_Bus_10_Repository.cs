using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Bus_10_Repository
    {

        public void NewBus(bus nuevoBus)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.bus.Add(nuevoBus);
                context.SaveChanges();
            }
        }

        public void UpdateBus(bus atcBus)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.bus.Attach(atcBus);
                context.Entry(atcBus).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBus(bus borrarBus)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.bus.Attach(borrarBus);
                context.Entry(borrarBus).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<bus> getBuses()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listbuses = from listbus in context.bus
                                select listbus;
                return listbuses.ToList();
            }
        }

        public List<bus> getBuses_id(int id_Bus)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listbuses = from listbus in context.bus
                                where listbus.id_bus == id_Bus
                                select listbus;
                return listbuses.ToList();
            }
        }

        public bus getRegistroBus(int registro_id)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var registros = from registro in context.bus
                                where registro.id_bus == registro_id
                                select registro;
                return registros.First<bus>();
            }
        }
    }
}

