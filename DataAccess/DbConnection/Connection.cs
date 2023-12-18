using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbConnection
{
    public class Connection<T> : IConnection<T> where T : class
    {
        private readonly T _connection;
        public Connection(T connection)
        {
            _connection = connection;
        }
        public T GetConnectionAccess()
        {
            return _connection;
        }
    }
}
