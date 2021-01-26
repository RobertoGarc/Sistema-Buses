using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Entidades_10;

namespace GAC_Acceso_Datos_10
{
    public class GAC_Vendedor_10_Repository
    {

        public void NewVendedor (vendedor nuevoVendedor)
        {
            using(BusesEntities context = new BusesEntities())
            {
                context.vendedor.Add(nuevoVendedor);
                context.SaveChanges();
            }
        }

        public void UpdateVendedor (vendedor atcVendedor)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.vendedor.Attach(atcVendedor);
                context.Entry(atcVendedor).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteVendedor(vendedor borrarVendedor)
        {
            using (BusesEntities context = new BusesEntities())
            {
                context.vendedor.Attach(borrarVendedor);
                context.Entry(borrarVendedor).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<vendedor> getVendedores()
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listvendedores = from listvendedor in context.vendedor 
                                select listvendedor;
                return listvendedores.ToList();
            }
        }

        public List<vendedor> getVendedores_id(int id_Vendedor)
        {
            using (BusesEntities context = new BusesEntities())
            {
                var listvendedores = from listvendedor in context.vendedor 
                                where listvendedor.id_vendedor==id_Vendedor 
                                select listvendedor;
                return listvendedores.ToList();
            }
        }


    }
}
