using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelBL.Interfaces;

namespace TabelDL_SQL
{
    public class Repo : IRepo
    {
        private string _connectionString;

        public Repo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }

}
