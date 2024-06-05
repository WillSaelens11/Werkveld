using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelBL.Interfaces;

namespace TabelBL.Model
{
    public class FunctionGlossary // 2 kol, rij variable
    {
        public string Naam { get; set; }
        public string DataType { get; set; }
        public int AantalKolommen { get; set; }
        public int AantalRijen { get; set; }
    }
}
