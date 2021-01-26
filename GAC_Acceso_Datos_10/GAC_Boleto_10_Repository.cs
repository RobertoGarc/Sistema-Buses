using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Boleto_10_Repository
    {

        public void NewBoleto(boleto nuevoBoleto)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.boleto.Add(nuevoBoleto);
                context.SaveChanges();
            }
        }

        public void UpdateBoleto(boleto atcBoleto)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.boleto.Attach(atcBoleto);
                context.Entry(atcBoleto).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBoleto(boleto borrarBoleto)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.boleto.Attach(borrarBoleto);
                context.Entry(borrarBoleto).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<boleto> getBoletos()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listboletos = from listboleto in context.boleto 
                                select listboleto;
                return listboletos.ToList();
            }
        }

        public List<boleto> getBoletos_id(int id_Boleto)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listboletos = from listboleto in context.boleto 
                                where listboleto.id_boleto==id_Boleto 
                                select listboleto;
                return listboletos.ToList();
            }
        }

        public boleto getRegistroBoleto(int registro_id)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var registros = from registro in context.boleto
                                where registro.id_boleto == registro_id
                                select registro;
                return registros.First<boleto>();
            }
        }


    }
}
