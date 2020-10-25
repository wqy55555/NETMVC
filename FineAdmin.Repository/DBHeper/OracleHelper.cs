using MySql.Data.MySqlClient;

namespace FineAdmin.Repository
{
    public class OracleHelper
    {
        public static string oracleconnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mysqlconn"].ConnectionString;

        public static System.Data.IDbConnection GetConnection()
        {
            var connection = new MySqlConnection(oracleconnectionString);
            connection.Open();
            return connection;
        }
    }
}
