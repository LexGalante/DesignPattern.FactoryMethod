using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public static class DbConnectionFactory
    {
        public static DbConnection GetConnection<T>() where T: class
        {
            if (typeof(T) == typeof(SqlServerConnection))
                return new SqlServerConnection();
            else
                return new OracleConnection();
        }
    }
}
