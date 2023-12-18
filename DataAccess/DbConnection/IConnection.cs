using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbConnection
{
    public interface IConnection <T> where T : class
    {
        T GetConnectionAccess();
    }
}
