using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewBankWEB.Models
{
    public class Movimientos
    {
        public int mov_id { get; set; }
        public Nullable<System.DateTime> mov_fecha { get; set; }
        public string mov_origen { get; set; }
        public Nullable<decimal> mov_valor { get; set; }
        public string mov_tipo { get; set; }
        public Nullable<int> cli_id { get; set; }
        public Nullable<int> cue_id { get; set; }

    }
}