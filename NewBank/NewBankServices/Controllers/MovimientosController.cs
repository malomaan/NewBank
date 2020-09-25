using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewBankBD;
using NewBankPRC;
using NewBankServices.Models;



namespace NewBankServices.Controllers
{
    public class MovimientosController : ApiController
    {
        MovimientosPRC ODAMovimiento = new MovimientosPRC();
        CuentaPRC ODACuenta = new CuentaPRC();



        /// <summary>
        /// Metodo que permite realizar un movimiento en la cuenta
        /// </summary>
        /// <param name="movimiento"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult MovimientosPost(Transaccion transaccion)
        {
            var TCuenta = ODACuenta.Cuenta_Cliente_List(transaccion.cli_id).ToList();

            try
            {
                int? cue_id = transaccion.cue_id;
                var DCuenta = ODACuenta.Cuenta_List(cue_id).ToList();
                //Validar si la cuenta está activa
                if (TCuenta.FirstOrDefault().cue_activa == true)
                {
                    if (transaccion.mov_tipo == "D" && transaccion.mov_valor >TCuenta.FirstOrDefault().cue_saldoactual)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ODAMovimiento.Movimientos_Insert(DateTime.Now, transaccion.mov_origen, transaccion.mov_valor, transaccion.mov_tipo, transaccion.cli_id, transaccion.cue_id);
                        ODACuenta.Cuenta_ControlSaldo(transaccion.cue_id, transaccion.mov_valor, transaccion.mov_tipo);
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception Ex)
            {
                return NotFound();
            }
            TCuenta = ODACuenta.Cuenta_Cliente_List(transaccion.cli_id).ToList();
            return Ok(TCuenta);
        }
    }
}
