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
    using System;
    using System.Collections.Generic;
    
    public partial class Visita
    {
        public int IdVisita { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Comentarios { get; set; }
        public string Documento_Cliente { get; set; }
        public string Documento_Empleado { get; set; }
        public Nullable<int> Id_Inmueble { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Inmueble Inmueble { get; set; }
    }
}
