using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelDL_SQL.Exceptions;


namespace Werkveld
{
    public class Tabel
    {
        public Tabel(TypeTabel typeTabel)
        {
            TypeTabel = typeTabel;
            Kolommen = new List<Kolom>();
            Rijen = new List<List<object>>();
        }

        public TypeTabel TypeTabel 
        { 
            get { return _typeTabel;} 
            set { if (value == null) { throw new TabelException("Type tabel mag niet leeg zijn.");} _typeTabel = value;}
        }
        public List<Kolom> Kolommen { get; set; }          // Of maak er een hashset van. 
        public List<List<object>> Rijen { get; set; }

        private TypeTabel _typeTabel;

        public void VoegkolomToe(Kolom kolom)
        {
            if (Kolommen.Any(c => c.Naam == kolom.Naam))
            {
                throw new TabelException("Een kolom met dezelfde naam bestaat al in de tabel.");
                // mogen er geen twee gelijke kolommen zijn?
            }

            Kolommen.Add(kolom);
        }
    }
}
