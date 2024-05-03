using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkveld
{
    public class TypeTabel
    {
        public int TypeID { get; set; }
        public string Naam { get; set; }
        public EnumTypeTabel TypeTabellen { get; set; }
        public int? AantalKolommen { get; set; } 
        public List<TypeKolom> MogelijkeKolommen { get; set; }
        public int? MinKolommen{ get; set; }
    }
}
