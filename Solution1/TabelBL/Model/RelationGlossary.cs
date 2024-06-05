using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelBL.Model
{
    public class RelationGlossary // 1 kol, rij variable
    {
        public string Naam { get; set; }
        public string DataType { get; set; }
        public int AantalKolommen { get; set; }
        public int AantalRijen { get; set; }
    }
}
