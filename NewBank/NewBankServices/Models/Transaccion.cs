using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewBankServices.Models
{
    public class Transaccion
    {
        public string mov_origen { get; set; }
        public decimal mov_valor { get; set; }
        public string mov_tipo { get; set; }
        public int cli_id { get; set; }
        public int cue_id { get; set; }

    }
}