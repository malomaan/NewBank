
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankBD
{
    // ===========================================================================
    /// <summary>
    /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
    /// Create date: Sep 24 2020  6:55AM
    /// Procedimiento almacenado que genera Script de Clases BD de Tablas
    /// CLASE CONSTRUCTOR, INSERT, UPDATE, DELETE Y SELECT de tablas de Bases de Datos
    /// </summary>

    public class ClienteBD
    {

        NewBankEntities BD = new NewBankEntities();


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

        public ClienteBD()
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
        /// Create date: Sep 24 2020  6:55AM
        /// Método que permite insertar en la tabla Cliente capa BD
        /// </summary>
        // ******************* = Método Insert = ******************************
        public void Cliente_Insert(string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            try
            {
                BD.Cliente_Insert(cli_identificacion, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_ciudad, cli_celular, cli_email);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  6:55AM
        /// Método que permite actualizar en la tabla Cliente capa BD
        /// </summary>
        // ******************* = Método Update = ******************************
        public void Cliente_Update(int cli_id, string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            try
            {
                BD.Cliente_Update(cli_id, cli_identificacion, cli_apellido1, cli_apellido2, cli_nombre1, cli_nombre2, cli_direccion, cli_ciudad, cli_celular, cli_email);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  6:55AM
        /// Método que permite eliminar en la tabla Cliente capa BD
        /// </summary>
        // ******************* = Método Delete = ******************************
        public void Cliente_Delete(int cli_id)
        {
            try
            {
                BD.Cliente_Delete(cli_id);
                BD.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        // ===========================================================================
        /// <summary>
        /// Author     : MARCO ANTONIO MARTINEZ LOPEZ
        /// Create date: Sep 24 2020  6:55AM
        /// Método que permite listar de la tabla Cliente capa BD
        /// </summary>
        // ******************* = Método List = ******************************
        public List<Cliente_List_Result> Cliente_List(int? cli_id)
        {
            try
            {
                var Cliente = (from TCliente in BD.Cliente_List(cli_id) select TCliente).ToList();
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
