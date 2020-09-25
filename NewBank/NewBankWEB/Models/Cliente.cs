using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewBankWEB.Models
{
    public class Cliente
    {
        public int cli_id { get; set; }
        public string cli_identificacion { get; set; }
        public string cli_apellido1 { get; set; }
        public string cli_apellido2 { get; set; }
        public string cli_nombre1 { get; set; }
        public string cli_nombre2 { get; set; }
        public string cli_direccion { get; set; }
        public string cli_ciudad { get; set; }
        public string cli_celular { get; set; }
        public string cli_email { get; set; }

    }
}