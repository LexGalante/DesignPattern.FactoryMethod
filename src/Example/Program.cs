using System;

namespace Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sqlServerConnection = DbConnectionFactory.GetConnection<SqlServerConnection>();
            Console.WriteLine(sqlServerConnection);

            var oracleServerConnection = DbConnectionFactory.GetConnection<OracleConnection>();
            Console.WriteLine(oracleServerConnection);
        }
    }
}
