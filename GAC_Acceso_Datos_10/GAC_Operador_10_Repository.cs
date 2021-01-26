using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Operador_10_Repository
    {

        public void NewOperador(operador nuevoOperador)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.operador.Add(nuevoOperador);
                context.SaveChanges();
            }
        }

        public void UpdateOperador(operador atcOperador)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.operador.Attach(atcOperador);
                context.Entry(atcOperador).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteOperador(operador borrarOperador)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.operador.Attach(borrarOperador);
                context.Entry(borrarOperador).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<operador> getOperadores()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listoperadores = from listoperador in context.operador 
                                select listoperador;
                return listoperadores.ToList();
            }
        }

        public List<operador> getOperadores_id(int id_Operador)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listoperadores = from listoperador in context.operador 
                                where listoperador.id_operador==id_Operador 
                                select listoperador;
                return listoperadores.ToList();
            }
        }

        public operador getRegistroOperador(int registro_id)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var registros = from registro in context.operador
                                where registro.id_operador == registro_id
                                select registro;
                return registros.First<operador>();
            }
        }


    }
}
