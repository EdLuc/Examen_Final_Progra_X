using Autofac;
using Interfaces.Interfaces;
using Servicios.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final_Progra_X__1804002020
{
    public class DIModule : Autofac.Module
    {
        string connectionString = @"Server=localhost;Initial Catalog=FinalPrograX;Trusted_Connection=true";

        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Caja
            builder.RegisterType<CajaService>().As<ICaja>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Gastos
            builder.RegisterType<GastoService>().As<IGastos>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Impuestos
            builder.RegisterType<ImpuestoService>().As<IImpuesto>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Publicidad
            builder.RegisterType<PublicidadService>().As<IPublicidad>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}
