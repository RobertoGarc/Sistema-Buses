using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Vendedor_10_Logica
    {
        public void newVendedor (vendedor nuevoVendedor)
        {
            GAC_Vendedor_10_Repository datos = new GAC_Vendedor_10_Repository();
            datos.NewVendedor (nuevoVendedor);
        }

        public void updateVendedor (vendedor atcVendedor)
        {
            GAC_Vendedor_10_Repository datos = new GAC_Vendedor_10_Repository();
            datos.UpdateVendedor (atcVendedor);
        }

        public void deleteVendedor(vendedor borrarVendedor)
        {
            GAC_Vendedor_10_Repository datos = new GAC_Vendedor_10_Repository();
            datos.DeleteVendedor(borrarVendedor);
        }

        public List<vendedor> getVendedores()
        {
            List<vendedor> listvendedores = new List<vendedor>();
            GAC_Vendedor_10_Repository datos = new GAC_Vendedor_10_Repository();
            listvendedores = datos.getVendedores();
            return listvendedores;
        }

        public List<vendedor> getVendedores_id(int id_Vendedor)
        {
            List<vendedor> listvendedores = new List<vendedor>();
            GAC_Vendedor_10_Repository datos = new GAC_Vendedor_10_Repository();
            listvendedores = datos.getVendedores_id(id_Vendedor);
            return listvendedores;
        }
    }
}
