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
    public class CuentaController : ApiController
    {
        CuentaPRC ODACuenta = new CuentaPRC();

        /// <summary>
        /// Metodo que permite listar las cuentas de un clientes de la bases de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult CuentaGet(int Id)
        {
            List<Cuenta_Cliente_List_Result> TCuenta = new List<Cuenta_Cliente_List_Result>();
            
            try
            {
                TCuenta = ODACuenta.Cuenta_Cliente_List(Id).ToList();
            }
            catch (Exception Ex)
            {
                return NotFound();
            }
            return Ok(TCuenta);
        }
    }
}
