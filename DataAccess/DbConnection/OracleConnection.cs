using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbConnection
{
    public class OracleConnection : Connection<OracleConnection>
    {
        public OracleConnection(OracleConnection connection) : base(connection)
        {
        }
    }
}
