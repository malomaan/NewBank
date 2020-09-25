using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBankBD;

namespace NewBankPRC
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Sep 24 2020  7:07AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class CuentaPRC
    {

        CuentaBD BDCuenta = new CuentaBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int cue_id;
        string cue_numero;
        int cli_id;
        bool cue_activa;
        DateTime cue_fechacreacion;
        string cue_usuariocreacion;
        decimal cue_saldoactual;

        // Deficinción de propiedades
        public int Cue_id { get; set; }
        public string Cue_numero { get; set; }
        public int Cli_id { get; set; }
        public bool Cue_activa { get; set; }
        public DateTime Cue_fechacreacion { get; set; }
        public string Cue_usuariocreacion { get; set; }
        public decimal Cue_saldoactual { get; set; }

        public CuentaPRC()
        {
            cue_numero = "";
            cli_id = 0;
            cue_activa = true;
            cue_fechacreacion = DateTime.Now;
            cue_usuariocreacion = "";
            cue_saldoactual = 0;
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:07AM
        /// Método que permite insertar en la tabla Cuenta capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Cuenta_Insert(string cue_numero, int cli_id, bool cue_activa, DateTime cue_fechacreacion, string cue_usuariocreacion, decimal cue_saldoactual)
        {
            try
            {
                BDCuenta.Cuenta_Insert(cue_numero, cli_id, cue_activa, cue_fechacreacion, cue_usuariocreacion, cue_saldoactual);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:07AM
        /// Método que permite actualizar en la tabla Cuenta capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Cuenta_Update(int cue_id, string cue_numero, int cli_id, bool cue_activa, DateTime cue_fechacreacion, string cue_usuariocreacion, decimal cue_saldoactual)
        {
            try
            {
                BDCuenta.Cuenta_Update(cue_id, cue_numero, cli_id, cue_activa, cue_fechacreacion, cue_usuariocreacion, cue_saldoactual);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:07AM
        /// Método que permite eliminar en la tabla Cuenta capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Cuenta_Delete(int cue_id)
        {
            try
            {
                BDCuenta.Cuenta_Delete(cue_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:07AM
        /// Método que permite listar de la tabla Cuenta capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Cuenta_List_Result> Cuenta_List(int? cue_id)
        {
            try
            {
                var Cuenta = (from TCuenta in BDCuenta.Cuenta_List(cue_id) select TCuenta).ToList();
                return Cuenta;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  6:57AM
        /// Método que permite actualizar Saldos en la tabla Cuenta capa BD
        /// </summary>
        // ******************* = Método Cuenta_ControlSaldo = ******************************
        public void Cuenta_ControlSaldo(int? cue_id, decimal? cue_valor, string mov_tipo)
        {
            try
            {
                BDCuenta.Cuenta_ControlSaldo(cue_id, cue_valor, mov_tipo);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }



        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  6:57AM
        /// Método que permite listar de la tabla Cuenta capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Cuenta_Cliente_List_Result> Cuenta_Cliente_List(int? cli_id)
        {
            try
            {
                var Cuenta = (from TCuenta in BDCuenta.Cuenta_Cliente_List(cli_id) select TCuenta).ToList();
                return Cuenta;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE

}
