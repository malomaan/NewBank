//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewBankBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimientos
    {
        public int mov_id { get; set; }
        public Nullable<System.DateTime> mov_fecha { get; set; }
        public string mov_origen { get; set; }
        public Nullable<decimal> mov_valor { get; set; }
        public string mov_tipo { get; set; }
        public Nullable<int> cli_id { get; set; }
        public Nullable<int> cue_id { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Cuenta Cuenta { get; set; }
    }
}
