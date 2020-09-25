using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewBankWEB.Models
{
    public class Cuenta
    {
        public int cue_id { get; set; }
        public string cue_numero { get; set; }
        public Nullable<int> cli_id { get; set; }
        public Nullable<bool> cue_activa { get; set; }
        public Nullable<System.DateTime> cue_fechacreacion { get; set; }
        public string cue_usuariocreacion { get; set; }
        public Nullable<decimal> cue_saldoactual { get; set; }
    }
}