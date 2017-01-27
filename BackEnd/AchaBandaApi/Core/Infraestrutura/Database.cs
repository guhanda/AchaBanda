using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MiniProfiler.Integrations;
using System.IO;
using System.Reflection;

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
            //var conn = new SqlConnection(myConnectionString);

            var factory = new SqlServerDbConnectionFactory(myConnectionString);
            var conn = DbConnectionFactoryHelper.New(factory, CustomDbProfiler.Current);
            
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);

            //conn.Open();

            return conn;
        }

        public void Dispose()
        {
            var aa = CustomDbProfiler.Current.ProfilerContext.GetCommands();

            var path = @"D:\GitPessoal\achaBanda\AchaBanda\BackEnd";

            File.WriteAllText(path+"\\Log.txt", aa);

            connection.Close();
        }
    }
}