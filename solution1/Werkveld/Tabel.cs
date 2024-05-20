using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Werkveld
{
    public class Tabel
    {
        public TypeTabel TypeTabel { get; set; }
        public List<Kolom> Kolommen { get; set; }          // Of maak er een hashset van. 
        public List<List<object>> Rijen { get; set; }

        public void VoegkolomToe(Kolom kolom)
        {
            if (Kolommen.Any(c => c.Naam == kolom.Naam))
            {
                throw new DomeinException("Een kolom met dezelfde naam bestaat al in de tabel.");
            }

            Kolommen.Add(kolom);
        }
    }
}
