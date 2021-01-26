using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Tipos_10_Repository
    {

        public void NewTipos(tipos nuevoTipos)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.tipos.Add(nuevoTipos);
                context.SaveChanges();
            }
        }

        public void UpdateTipos(tipos atcTipos)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.tipos.Attach(atcTipos);
                context.Entry(atcTipos).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteTipos(tipos borrarTipos)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.tipos.Attach(borrarTipos);
                context.Entry(borrarTipos).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<tipos> getTipos()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listtipos = from listtipo in context.tipos 
                                select listtipo;
                return listtipos.ToList();
            }
        }

        public List<tipos> getTipos_id(int id_Tipos)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listtipos = from listtipo in context.tipos 
                                where listtipo.id_tipos==id_Tipos 
                                select listtipo;
                return listtipos.ToList();
            }
        }


    }
}
