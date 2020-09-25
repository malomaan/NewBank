using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewBankBD;
using NewBankPRC;


namespace NewBankServices.Controllers
{
    public class FabricaController : ApiController
    {
        ClientePRC ODACliente = new ClientePRC();
        CuentaPRC ODACuenta = new CuentaPRC();
        MovimientosPRC ODAMovimiento = new MovimientosPRC();

        
        /// <summary>
        /// Metodo que permite listar los clientes de la bases de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult FabricaGet(string Email)
        {
            List<Cliente_Email_List_Result> Tcliente = new List<Cliente_Email_List_Result>();

            try
            {
                Tcliente = ODACliente.Cliente_Email_List(Email).ToList();

            }
            catch (Exception Ex)
            {
                return NotFound();
            }
            return Ok(Tcliente);
        }


        /// <summary>
        /// Metodo que permite registrar un cliente y una cuenta nueva
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult FabricaPost(Cliente cliente)
        {
            var TCliente = ODACliente.Cliente_Email_List(null).ToList();
            try
            {

                ODACliente.Cliente_Insert(cliente.cli_identificacion, cliente.cli_apellido1, cliente.cli_apellido2, cliente.cli_nombre1, cliente.cli_nombre2, cliente.cli_direccion, cliente.cli_ciudad, cliente.cli_celular, cliente.cli_email);


                TCliente = ODACliente.Cliente_Email_List(cliente.cli_email).ToList();
                ODACuenta.Cuenta_Insert(TCliente.FirstOrDefault().cli_id.ToString()+'-'+cliente.cli_identificacion, TCliente.FirstOrDefault().cli_id, true, DateTime.Now, cliente.cli_identificacion, 0);
            }
            catch (Exception Ex)
            {
                return NotFound();
            }
            return Ok(TCliente);
        }

    }
}
