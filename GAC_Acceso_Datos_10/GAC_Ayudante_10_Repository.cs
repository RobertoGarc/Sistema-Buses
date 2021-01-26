using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Ayudante_10_Repository
    {

        public void NewAyudante(ayudante nuevoAyudante)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.ayudante.Add(nuevoAyudante);
                context.SaveChanges();
            }
        }

        public void UpdateAyudante(ayudante atcAyudante)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.ayudante.Attach(atcAyudante);
                context.Entry(atcAyudante).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteAyudante(ayudante borrarAyudante)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.ayudante.Attach(borrarAyudante);
                context.Entry(borrarAyudante).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<ayudante> getAyudantes()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listayudantes = from listayudante in context.ayudante 
                                select listayudante;
                return listayudantes.ToList();
            }
        }

        public List<ayudante> getAyudantes_id(int id_Ayudante)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listayudantes = from listayudante in context.ayudante 
                                where listayudante.id_ayudante==id_Ayudante 
                                select listayudante;
                return listayudantes.ToList();
            }
        }

        public ayudante getRegistroAyudante(int registro_id)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var registros = from registro in context.ayudante
                                where registro.id_ayudante == registro_id
                                select registro;
                return registros.First<ayudante>();
            }
        }


    }
}
