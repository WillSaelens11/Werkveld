using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TabelDL_SQL
{
    public class Repo 
    {
        private string _connectionString;

        public Repo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }

}
