﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewBankBD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NewBankEntities : DbContext
    {
        public NewBankEntities()
            : base("name=NewBankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Movimientos> Movimientos { get; set; }
    
        public virtual int Cliente_Delete(Nullable<int> cli_id)
        {
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cliente_Delete", cli_idParameter);
        }
    
        public virtual int Cliente_Insert(string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            var cli_identificacionParameter = cli_identificacion != null ?
                new ObjectParameter("cli_identificacion", cli_identificacion) :
                new ObjectParameter("cli_identificacion", typeof(string));
    
            var cli_apellido1Parameter = cli_apellido1 != null ?
                new ObjectParameter("cli_apellido1", cli_apellido1) :
                new ObjectParameter("cli_apellido1", typeof(string));
    
            var cli_apellido2Parameter = cli_apellido2 != null ?
                new ObjectParameter("cli_apellido2", cli_apellido2) :
                new ObjectParameter("cli_apellido2", typeof(string));
    
            var cli_nombre1Parameter = cli_nombre1 != null ?
                new ObjectParameter("cli_nombre1", cli_nombre1) :
                new ObjectParameter("cli_nombre1", typeof(string));
    
            var cli_nombre2Parameter = cli_nombre2 != null ?
                new ObjectParameter("cli_nombre2", cli_nombre2) :
                new ObjectParameter("cli_nombre2", typeof(string));
    
            var cli_direccionParameter = cli_direccion != null ?
                new ObjectParameter("cli_direccion", cli_direccion) :
                new ObjectParameter("cli_direccion", typeof(string));
    
            var cli_ciudadParameter = cli_ciudad != null ?
                new ObjectParameter("cli_ciudad", cli_ciudad) :
                new ObjectParameter("cli_ciudad", typeof(string));
    
            var cli_celularParameter = cli_celular != null ?
                new ObjectParameter("cli_celular", cli_celular) :
                new ObjectParameter("cli_celular", typeof(string));
    
            var cli_emailParameter = cli_email != null ?
                new ObjectParameter("cli_email", cli_email) :
                new ObjectParameter("cli_email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cliente_Insert", cli_identificacionParameter, cli_apellido1Parameter, cli_apellido2Parameter, cli_nombre1Parameter, cli_nombre2Parameter, cli_direccionParameter, cli_ciudadParameter, cli_celularParameter, cli_emailParameter);
        }
    
        public virtual ObjectResult<Cliente_List_Result> Cliente_List(Nullable<int> cli_id)
        {
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cliente_List_Result>("Cliente_List", cli_idParameter);
        }
    
        public virtual int Cliente_Update(Nullable<int> cli_id, string cli_identificacion, string cli_apellido1, string cli_apellido2, string cli_nombre1, string cli_nombre2, string cli_direccion, string cli_ciudad, string cli_celular, string cli_email)
        {
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            var cli_identificacionParameter = cli_identificacion != null ?
                new ObjectParameter("cli_identificacion", cli_identificacion) :
                new ObjectParameter("cli_identificacion", typeof(string));
    
            var cli_apellido1Parameter = cli_apellido1 != null ?
                new ObjectParameter("cli_apellido1", cli_apellido1) :
                new ObjectParameter("cli_apellido1", typeof(string));
    
            var cli_apellido2Parameter = cli_apellido2 != null ?
                new ObjectParameter("cli_apellido2", cli_apellido2) :
                new ObjectParameter("cli_apellido2", typeof(string));
    
            var cli_nombre1Parameter = cli_nombre1 != null ?
                new ObjectParameter("cli_nombre1", cli_nombre1) :
                new ObjectParameter("cli_nombre1", typeof(string));
    
            var cli_nombre2Parameter = cli_nombre2 != null ?
                new ObjectParameter("cli_nombre2", cli_nombre2) :
                new ObjectParameter("cli_nombre2", typeof(string));
    
            var cli_direccionParameter = cli_direccion != null ?
                new ObjectParameter("cli_direccion", cli_direccion) :
                new ObjectParameter("cli_direccion", typeof(string));
    
            var cli_ciudadParameter = cli_ciudad != null ?
                new ObjectParameter("cli_ciudad", cli_ciudad) :
                new ObjectParameter("cli_ciudad", typeof(string));
    
            var cli_celularParameter = cli_celular != null ?
                new ObjectParameter("cli_celular", cli_celular) :
                new ObjectParameter("cli_celular", typeof(string));
    
            var cli_emailParameter = cli_email != null ?
                new ObjectParameter("cli_email", cli_email) :
                new ObjectParameter("cli_email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cliente_Update", cli_idParameter, cli_identificacionParameter, cli_apellido1Parameter, cli_apellido2Parameter, cli_nombre1Parameter, cli_nombre2Parameter, cli_direccionParameter, cli_ciudadParameter, cli_celularParameter, cli_emailParameter);
        }
    
        public virtual int Cuenta_Delete(Nullable<int> cue_id)
        {
            var cue_idParameter = cue_id.HasValue ?
                new ObjectParameter("cue_id", cue_id) :
                new ObjectParameter("cue_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cuenta_Delete", cue_idParameter);
        }
    
        public virtual int Cuenta_Insert(string cue_numero, Nullable<int> cli_id, Nullable<bool> cue_activa, Nullable<System.DateTime> cue_fechacreacion, string cue_usuariocreacion, Nullable<decimal> cue_saldoactual)
        {
            var cue_numeroParameter = cue_numero != null ?
                new ObjectParameter("cue_numero", cue_numero) :
                new ObjectParameter("cue_numero", typeof(string));
    
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            var cue_activaParameter = cue_activa.HasValue ?
                new ObjectParameter("cue_activa", cue_activa) :
                new ObjectParameter("cue_activa", typeof(bool));
    
            var cue_fechacreacionParameter = cue_fechacreacion.HasValue ?
                new ObjectParameter("cue_fechacreacion", cue_fechacreacion) :
                new ObjectParameter("cue_fechacreacion", typeof(System.DateTime));
    
            var cue_usuariocreacionParameter = cue_usuariocreacion != null ?
                new ObjectParameter("cue_usuariocreacion", cue_usuariocreacion) :
                new ObjectParameter("cue_usuariocreacion", typeof(string));
    
            var cue_saldoactualParameter = cue_saldoactual.HasValue ?
                new ObjectParameter("cue_saldoactual", cue_saldoactual) :
                new ObjectParameter("cue_saldoactual", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cuenta_Insert", cue_numeroParameter, cli_idParameter, cue_activaParameter, cue_fechacreacionParameter, cue_usuariocreacionParameter, cue_saldoactualParameter);
        }
    
        public virtual ObjectResult<Cuenta_List_Result> Cuenta_List(Nullable<int> cue_id)
        {
            var cue_idParameter = cue_id.HasValue ?
                new ObjectParameter("cue_id", cue_id) :
                new ObjectParameter("cue_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Cuenta_List_Result>("Cuenta_List", cue_idParameter);
        }
    
        public virtual int Cuenta_Update(Nullable<int> cue_id, string cue_numero, Nullable<int> cli_id, Nullable<bool> cue_activa, Nullable<System.DateTime> cue_fechacreacion, string cue_usuariocreacion, Nullable<decimal> cue_saldoactual)
        {
            var cue_idParameter = cue_id.HasValue ?
                new ObjectParameter("cue_id", cue_id) :
                new ObjectParameter("cue_id", typeof(int));
    
            var cue_numeroParameter = cue_numero != null ?
                new ObjectParameter("cue_numero", cue_numero) :
                new ObjectParameter("cue_numero", typeof(string));
    
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            var cue_activaParameter = cue_activa.HasValue ?
                new ObjectParameter("cue_activa", cue_activa) :
                new ObjectParameter("cue_activa", typeof(bool));
    
            var cue_fechacreacionParameter = cue_fechacreacion.HasValue ?
                new ObjectParameter("cue_fechacreacion", cue_fechacreacion) :
                new ObjectParameter("cue_fechacreacion", typeof(System.DateTime));
    
            var cue_usuariocreacionParameter = cue_usuariocreacion != null ?
                new ObjectParameter("cue_usuariocreacion", cue_usuariocreacion) :
                new ObjectParameter("cue_usuariocreacion", typeof(string));
    
            var cue_saldoactualParameter = cue_saldoactual.HasValue ?
                new ObjectParameter("cue_saldoactual", cue_saldoactual) :
                new ObjectParameter("cue_saldoactual", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cuenta_Update", cue_idParameter, cue_numeroParameter, cli_idParameter, cue_activaParameter, cue_fechacreacionParameter, cue_usuariocreacionParameter, cue_saldoactualParameter);
        }
    
        public virtual int Movimientos_Delete(Nullable<int> mov_id)
        {
            var mov_idParameter = mov_id.HasValue ?
                new ObjectParameter("mov_id", mov_id) :
                new ObjectParameter("mov_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Movimientos_Delete", mov_idParameter);
        }
    
        public virtual int Movimientos_Insert(Nullable<System.DateTime> mov_fecha, string mov_origen, Nullable<decimal> mov_valor, string mov_tipo, Nullable<int> cli_id, Nullable<int> cue_id)
        {
            var mov_fechaParameter = mov_fecha.HasValue ?
                new ObjectParameter("mov_fecha", mov_fecha) :
                new ObjectParameter("mov_fecha", typeof(System.DateTime));
    
            var mov_origenParameter = mov_origen != null ?
                new ObjectParameter("mov_origen", mov_origen) :
                new ObjectParameter("mov_origen", typeof(string));
    
            var mov_valorParameter = mov_valor.HasValue ?
                new ObjectParameter("mov_valor", mov_valor) :
                new ObjectParameter("mov_valor", typeof(decimal));
    
            var mov_tipoParameter = mov_tipo != null ?
                new ObjectParameter("mov_tipo", mov_tipo) :
                new ObjectParameter("mov_tipo", typeof(string));
    
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            var cue_idParameter = cue_id.HasValue ?
                new ObjectParameter("cue_id", cue_id) :
                new ObjectParameter("cue_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Movimientos_Insert", mov_fechaParameter, mov_origenParameter, mov_valorParameter, mov_tipoParameter, cli_idParameter, cue_idParameter);
        }
    
        public virtual ObjectResult<Movimientos_List_Result> Movimientos_List(Nullable<int> mov_id)
        {
            var mov_idParameter = mov_id.HasValue ?
                new ObjectParameter("mov_id", mov_id) :
                new ObjectParameter("mov_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Movimientos_List_Result>("Movimientos_List", mov_idParameter);
        }
    
        public virtual int Movimientos_Update(Nullable<int> mov_id, Nullable<System.DateTime> mov_fecha, string mov_origen, Nullable<decimal> mov_valor, string mov_tipo, Nullable<int> cli_id, Nullable<int> cue_id)
        {
            var mov_idParameter = mov_id.HasValue ?
                new ObjectParameter("mov_id", mov_id) :
                new ObjectParameter("mov_id", typeof(int));
    
            var mov_fechaParameter = mov_fecha.HasValue ?
                new ObjectParameter("mov_fecha", mov_fecha) :
                new ObjectParameter("mov_fecha", typeof(System.DateTime));
    
            var mov_origenParameter = mov_origen != null ?
                new ObjectParameter("mov_origen", mov_origen) :
                new ObjectParameter("mov_origen", typeof(string));
    
            var mov_valorParameter = mov_valor.HasValue ?
                new ObjectParameter("mov_valor", mov_valor) :
                new ObjectParameter("mov_valor", typeof(decimal));
    
            var mov_tipoParameter = mov_tipo != null ?
                new ObjectParameter("mov_tipo", mov_tipo) :
                new ObjectParameter("mov_tipo", typeof(string));
    
            var cli_idParameter = cli_id.HasValue ?
                new ObjectParameter("cli_id", cli_id) :
                new ObjectParameter("cli_id", typeof(int));
    
            var cue_idParameter = cue_id.HasValue ?
                new ObjectParameter("cue_id", cue_id) :
                new ObjectParameter("cue_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Movimientos_Update", mov_idParameter, mov_fechaParameter, mov_origenParameter, mov_valorParameter, mov_tipoParameter, cli_idParameter, cue_idParameter);
        }
    }
}