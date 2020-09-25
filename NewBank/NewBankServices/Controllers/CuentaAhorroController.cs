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
    public class CuentaAhorroController : ApiController
    {
        CuentaPRC ODACuenta = new CuentaPRC();

        [HttpGet]
        public IHttpActionResult CuentaAhorroGet(int Id)
        {
            List<Cuenta_List_Result> TCuenta = new List<Cuenta_List_Result>();

            try
            {
                TCuenta = ODACuenta.Cuenta_List(Id).ToList();

            }
            catch (Exception Ex)
            {
                return NotFound();
            }
            return Ok(TCuenta);
        }
    }
}
