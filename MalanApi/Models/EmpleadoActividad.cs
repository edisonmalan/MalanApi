//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MalanApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoActividad
    {
        public int idEmpActivid { get; set; }
        public Nullable<int> idempleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string actividad { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
        public Nullable<int> estado { get; set; }
    }
}
