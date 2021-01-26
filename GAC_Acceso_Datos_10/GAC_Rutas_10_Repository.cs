using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Rutas_10_Repository
    {

        public void NewRuta(rutas nuevaRuta)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.rutas.Add(nuevaRuta);
                context.SaveChanges();
            }
        }

        public void UpdateRuta(rutas atcRuta)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.rutas.Attach(atcRuta);
                context.Entry(atcRuta).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteRuta(rutas borrarRuta)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.rutas.Attach(borrarRuta);
                context.Entry(borrarRuta).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<rutas> getRutas()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listrutas = from listruta in context.rutas 
                                select listruta;
                return listrutas.ToList();
            }
        }

        public List<rutas> getRutas_id(int id_Ruta)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listrutas = from listruta in context.rutas 
                                where listruta.id_rutas==id_Ruta 
                                select listruta;
                return listrutas.ToList();
            }
        }


    }
}
