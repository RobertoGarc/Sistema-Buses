//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAC_Entidades_10
{
    using System;
    using System.Collections.Generic;
    
    public partial class pasajero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pasajero()
        {
            this.boleto = new HashSet<boleto>();
        }
    
        public int id_pasajero { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> cedula { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechanacimiento { get; set; }
        public Nullable<int> sexo { get; set; }
        public Nullable<int> id_bus { get; set; }
        public Nullable<int> id_ruta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boleto> boleto { get; set; }
        public virtual bus bus { get; set; }
        public virtual rutas rutas { get; set; }
        public virtual sexo sexo1 { get; set; }
    }
}