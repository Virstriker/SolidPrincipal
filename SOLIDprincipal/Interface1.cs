using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincipal
{
    public interface DataBase
    {
        public void ReadDatabaseContent();
        public void WriteDatabaseContent();

    }
    public interface Delete
    {
        public void DeleteDataByName();
    }
}
