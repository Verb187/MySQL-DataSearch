 
using MySql.Data.MySqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
namespace MySQL_DataSearch.DataAccess
{
    public static class DBcontext
    {
        static MySqlConnection connection = null;
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection("Server=127.0.0.1;Database=gestion.immo;Uid=root;");
            }

            return connection;
        }
        static QueryFactory db = null;
        public static QueryFactory Db()
        {
            if (db == null)
            {
                var compiler = new MySqlCompiler();
                db = new QueryFactory(GetConnection(), compiler);
            }
            return db;
        }


    }
}
