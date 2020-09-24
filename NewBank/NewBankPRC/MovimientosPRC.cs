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
    /// Create date: Sep 24 2020  7:08AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class MovimientosPRC
    {

        MovimientosBD BDMovimientos = new MovimientosBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int mov_id;
        DateTime mov_fecha;
        string mov_origen;
        decimal mov_valor;
        string mov_tipo;
        int cli_id;
        int cue_id;

        // Deficinción de propiedades
        public int Mov_id { get; set; }
        public DateTime Mov_fecha { get; set; }
        public string Mov_origen { get; set; }
        public decimal Mov_valor { get; set; }
        public string Mov_tipo { get; set; }
        public int Cli_id { get; set; }
        public int Cue_id { get; set; }

        public MovimientosPRC()
        {
            mov_fecha = DateTime.Now;
            mov_origen = "";
            mov_valor = 0;
            mov_tipo = "";
            cli_id = 0;
            cue_id = 0;
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:08AM
        /// Método que permite insertar en la tabla Movimientos capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Movimientos_Insert(DateTime mov_fecha, string mov_origen, decimal mov_valor, string mov_tipo, int cli_id, int cue_id)
        {
            try
            {
                BDMovimientos.Movimientos_Insert(mov_fecha, mov_origen, mov_valor, mov_tipo, cli_id, cue_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:08AM
        /// Método que permite actualizar en la tabla Movimientos capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Movimientos_Update(int mov_id, DateTime mov_fecha, string mov_origen, decimal mov_valor, string mov_tipo, int cli_id, int cue_id)
        {
            try
            {
                BDMovimientos.Movimientos_Update(mov_id, mov_fecha, mov_origen, mov_valor, mov_tipo, cli_id, cue_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:08AM
        /// Método que permite eliminar en la tabla Movimientos capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Movimientos_Delete(int mov_id)
        {
            try
            {
                BDMovimientos.Movimientos_Delete(mov_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:08AM
        /// Método que permite listar de la tabla Movimientos capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Movimientos_List_Result> Movimientos_List(int mov_id)
        {
            try
            {
                var Movimientos = (from TMovimientos in BDMovimientos.Movimientos_List(mov_id) select TMovimientos).ToList();
                return Movimientos;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
