using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_Acceso_Datos_10;
using GAC_Entidades_10;
namespace GAC_Logica_Negocio_10
{
    public class GAC_Operador_10_Logica
    {
        public void newOperador(operador nuevoOperador)
        {
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            datos.NewOperador(nuevoOperador);
        }

        public void updateOperador(operador atcOperador)
        {
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            datos.UpdateOperador(atcOperador);
        }

        public void deleteOperador(operador borrarOperador)
        {
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            datos.DeleteOperador(borrarOperador);
        }

        public List<operador> getOperadores()
        {
            List<operador> listoperadores = new List<operador>();
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            listoperadores = datos.getOperadores();
            return listoperadores;
        }

        public List<operador> getOperadores_id(int id_Operador)
        {
            List<operador> listoperadores = new List<operador>();
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            listoperadores = datos.getOperadores_id(id_Operador);
            return listoperadores;
        }

        public operador getRegistroOperador(int Registro_id)
        {
            operador listaregistros = new operador();
            GAC_Operador_10_Repository datos = new GAC_Operador_10_Repository();
            listaregistros = datos.getRegistroOperador(Registro_id);
            return listaregistros;
        }
    }
}
