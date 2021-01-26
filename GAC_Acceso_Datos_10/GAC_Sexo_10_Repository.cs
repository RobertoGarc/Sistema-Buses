using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Sexo_10_Repository
    {

        public void NewSexo (sexo nuevoSexo)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.sexo.Add(nuevoSexo);
                context.SaveChanges();
            }
        }

        public void UpdateSexo(sexo atcSexo)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.sexo.Attach(atcSexo);
                context.Entry(atcSexo).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteSexo(sexo borrarSexo)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.sexo.Attach(borrarSexo);
                context.Entry(borrarSexo).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<sexo> getSexos()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listsexos = from listsexo in context.sexo 
                                select listsexo;
                return listsexos.ToList();
            }
        }

        public List<sexo> getSexos_id(int id_Sexo)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listsexos = from listsexo in context.sexo 
                                where listsexo.id_sexo==id_Sexo 
                                select listsexo;
                return listsexos.ToList();
            }
        }


    }
}
