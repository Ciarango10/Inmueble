//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Inmueble
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inmueble()
        {
            this.Arriendoes = new HashSet<Arriendo>();
            this.Contratoes = new HashSet<Contrato>();
            this.DetalleFacturas = new HashSet<DetalleFactura>();
            this.Ventas = new HashSet<Venta>();
            this.Visitas = new HashSet<Visita>();
        }
    
        public int IdInmueble { get; set; }
        public string Direccion { get; set; }
        public double Precio { get; set; }
        public double Area { get; set; }
        public int NroHabitaciones { get; set; }
        public int NroBaños { get; set; }
        public string Estado { get; set; }
        public string Caracteristicas { get; set; }
        public Nullable<System.DateTime> FechaPublicacion { get; set; }
        public Nullable<int> Id_Ciudad { get; set; }
        public Nullable<int> Id_TipoInmueble { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arriendo> Arriendoes { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contratoes { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual TipoInmueble TipoInmueble { get; set; }
    }
}
