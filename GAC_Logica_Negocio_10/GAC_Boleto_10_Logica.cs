using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Boleto_10_Logica
    {
        public void newBoleto(boleto nuevoBoleto)
        {
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            datos.NewBoleto(nuevoBoleto);
        }

        public void updateBoleto(boleto atcBoleto)
        {
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            datos.UpdateBoleto(atcBoleto);
        }

        public void deleteBoleto(boleto borrarBoleto)
        {
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            datos.DeleteBoleto(borrarBoleto);
        }

        public List<boleto> getBoletos()
        {
            List<boleto> listboletos = new List<boleto>();
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            listboletos = datos.getBoletos();
            return listboletos;
        }

        public List<boleto> getBoletos_id(int id_Boleto)
        {
            List<boleto> listboletos = new List<boleto>();
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            listboletos = datos.getBoletos_id(id_Boleto);
            return listboletos;
        }

        public boleto getRegistroBoleto(int Registro_id)
        {
            boleto listaregistros = new boleto();
            GAC_Boleto_10_Repository datos = new GAC_Boleto_10_Repository();
            listaregistros = datos.getRegistroBoleto(Registro_id);
            return listaregistros;
        }
    }
}
