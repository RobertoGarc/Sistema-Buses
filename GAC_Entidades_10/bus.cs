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
    
    public partial class bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bus()
        {
            this.ayudante = new HashSet<ayudante>();
            this.boleto = new HashSet<boleto>();
            this.operador1 = new HashSet<operador>();
            this.pasajero = new HashSet<pasajero>();
        }
    
        public int id_bus { get; set; }
        public Nullable<int> id_tipos { get; set; }
        public Nullable<int> id_rutas { get; set; }
        public Nullable<int> id_operador { get; set; }
        public Nullable<int> id_ayudante { get; set; }
        public string unidad { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public Nullable<System.DateTime> añofabricacion { get; set; }
        public Nullable<int> id_boleto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ayudante> ayudante { get; set; }
        public virtual ayudante ayudante1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<boleto> boleto { get; set; }
        public virtual boleto boleto1 { get; set; }
        public virtual rutas rutas { get; set; }
        public virtual tipos tipos { get; set; }
        public virtual operador operador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operador> operador1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pasajero> pasajero { get; set; }
    }
}
