using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelDL_SQL.Exceptions
{
    public class TabelException : Exception
    {
        public TabelException( string message)
        {
            Message = message;
        }

        private string Message { get;}
    }
}
