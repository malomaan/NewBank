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
    /// Create date: Sep 24 2020  7:02AM
    /// Procedimiento almacenado que genera Script de Clases PRC de la capa BD
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class ClientePRC
    {

        ClienteBD BDCliente = new ClienteBD();


        // ******************* = Costructor = ******************************
        // Declaración de variables
        int cli_id;
        string cli_identificacion;
        string cli_apellido1;
        string cli_apellido2;
        string cli_nombre1;
        string cli_nombre2;
        string cli_direccion;
        string cli_ciudad;
        string cli_celular;
        string cli_email;

        // Deficinción de propiedades
        public int Cli_id { get; set; }
        public string Cli_identificacion { get; set; }
        public string Cli_apellido1 { get; set; }
        public string Cli_apellido2 { get; set; }
        public string Cli_nombre1 { get; set; }
        public string Cli_nombre2 { get; set; }
        public string Cli_direccion { get; set; }
        public string Cli_ciudad { get; set; }
        public string Cli_celular { get; set; }
        public string Cli_email { get; set; }

        public ClientePRC()
        {
            cli_identificacion = "";
            cli_apellido1 = "";
            cli_apellido2 = "";
            cli_nombre1 = "";
            cli_nombre2 = "";
            cli_direccion = "";
            cli_ciudad = "";
            cli_celular = "";
            cli_email = "";
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:02AM
        /// Método que permite insertar en la tabla Cliente capa PRC
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Cliente_Insert(string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            try
            {
                BDCliente.Cliente_Insert(cli_identificacion, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_ciudad, cli_celular, cli_email);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:02AM
        /// Método que permite actualizar en la tabla Cliente capa PRC
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Cliente_Update(int cli_id, string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            try
            {
                BDCliente.Cliente_Update(cli_id, cli_identificacion, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_ciudad, cli_celular, cli_email);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:02AM
        /// Método que permite eliminar en la tabla Cliente capa PRC
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Cliente_Delete(int cli_id)
        {
            try
            {
                BDCliente.Cliente_Delete(cli_id);
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  7:02AM
        /// Método que permite listar de la tabla Cliente capa PRC
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Cliente_List_Result> Cliente_List(int? cli_id)
        {
            try
            {
                var Cliente = (from TCliente in BDCliente.Cliente_List(cli_id) select TCliente).ToList();
                return Cliente;
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
    }
    //FIN DE LA CLASE
}
