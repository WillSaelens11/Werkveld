using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkveld
{
    public class TabelManager
    {
        public List<Tabel> Tabellen { get; private set; } = new List<Tabel>();

        public void VoegTabelToe(Tabel tabel)
        {
            Tabellen.Add(tabel);
        }

        public HashSet<Kolom> AlleKolommen()
        {
            var alleKolommen = new HashSet<Kolom>();

            foreach (var tabel in Tabellen)
            {
                foreach (var kolom in tabel.Kolommen)
                {
                    alleKolommen.Add(kolom);
                }
            }

            return alleKolommen;
        }
    }
}
