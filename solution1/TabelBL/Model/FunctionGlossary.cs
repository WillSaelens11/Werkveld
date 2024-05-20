using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelBL.Inferfaces;

namespace TabelBL.Model
{
    public class FunctionGlossary
    {
        public string Naam { get; set; }
        public string DataType { get; set; }
        public int AantalKolommen { get; set; }
        public int AantalRijen { get; set; }
    }
}
