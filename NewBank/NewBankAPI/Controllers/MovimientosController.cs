using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using NewBankBD;

namespace NewBankAPI.Controllers
{
    public class MovimientosController : ApiController
    {
        private NewBankEntities db = new NewBankEntities();

        // GET: api/Movimientos
        public IQueryable<Movimientos> GetMovimientos()
        {
            return db.Movimientos;
        }

        // GET: api/Movimientos/5
        [ResponseType(typeof(Movimientos))]
        public IHttpActionResult GetMovimientos(int id)
        {
            Movimientos movimientos = db.Movimientos.Find(id);
            if (movimientos == null)
            {
                return NotFound();
            }

            return Ok(movimientos);
        }

        // PUT: api/Movimientos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMovimientos(int id, Movimientos movimientos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movimientos.mov_id)
            {
                return BadRequest();
            }

            db.Entry(movimientos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimientosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Movimientos
        [ResponseType(typeof(Movimientos))]
        public IHttpActionResult PostMovimientos(Movimientos movimientos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movimientos.Add(movimientos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = movimientos.mov_id }, movimientos);
        }

        // DELETE: api/Movimientos/5
        [ResponseType(typeof(Movimientos))]
        public IHttpActionResult DeleteMovimientos(int id)
        {
            Movimientos movimientos = db.Movimientos.Find(id);
            if (movimientos == null)
            {
                return NotFound();
            }

            db.Movimientos.Remove(movimientos);
            db.SaveChanges();

            return Ok(movimientos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovimientosExists(int id)
        {
            return db.Movimientos.Count(e => e.mov_id == id) > 0;
        }
    }
}