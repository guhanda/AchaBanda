using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

using System.Linq;
using System.Web;
using AchaBandaApi.Core.Dominio;

namespace AchaBandaApi.Core.Infraestrutura
{
    public class Database : IDisposable
    {
        public IDbConnection connection { get; set; }

        public Database()
        {
            connection = DbInit();
        }

        public IDbConnection DbInit()
        {
            string myConnectionString;

            //myConnectionString = "Data Source = SQL5033.SmarterASP.NET; Initial Catalog = DB_A16841_achabanda; User Id = DB_A16841_achabanda_admin; Password = YOUR_DB_PASSWORD; ";

            myConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=achabanda;Integrated Security=True";
            var conn = new SqlConnection(myConnectionString);

            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);

            conn.Open();

            return conn;
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}