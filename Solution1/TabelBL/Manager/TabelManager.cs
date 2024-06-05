using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TabelDL_SQL;

namespace Werkveld
{
    public class TabelManager
    {
        public List<Tabel> Tabellen { get; private set; } = new List<Tabel>();

        public void VoegTabelToe(Tabel tabel)
        {
            Tabellen.Add(tabel);
        }
        public void VerwijderTabel(Tabel tabel)
        {
            if (BestaatTabel(tabel))
            {
                Tabellen.Remove(tabel);
            }
            else { throw new DomeinException("De tabel bestaat niet."); }
        }

        public void VoegKolomToe(Tabel tabel, Kolom kolom)
        {
            if (tabel.Kolommen.count <= tabel.TypeTabel.MaxKolommen) // als het aantal kolommen in de tabel kleiner is dan het maximum aantal kolommen voor dat tabeltype
            {
                tabel.VoegkolomToe(kolom);
            }
            else { throw new DomeinException("Het maximum aantal kolommen is bereikt."); }
        }
        public void VerwijderKolom(Tabel tabel, Kolom kolom)
        {
            if (BestaatTabel(tabel) && BestaatKolom(kolom))
            {
                if (tabel.Kolommen.count >= tabel.TypeTabel.Minkolommen) // als het aantal kolommen in de tabel meer of gelijk is aan het minimum aantal kolommen voor dat tabeltype
                {
                    tabel.Kolommen.Remove(kolom);
                }
                else { throw new DomeinException("Het minimum aantal kolommen is bereikt."); }
            }
            else { throw new DomeinException("De tabel of kolom bestaat niet."); }
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

        public bool BestaatTabel(Tabel tabel)
        {
            return Tabellen.Contains(tabel);
        }

        public bool BestaatKolom(Tabel tabel, Kolom kolom)
        {
            return tabel.Kolommen.Contains(kolom);
        }

        /*public void VoegRijToe(Tabel tabel)
        {
            if (tabel.Rijen.Count < tabel.TypeTabel.MaxRijen)
            {
                tabel.VoegRijToe(new Rij());
            }
            else { throw new DomeinException("Het maximum aantal rijen is bereikt."); }
        }

        public void VerwijderRij(Tabel tabel, Rij rij)
        {
            if (BestaatTabel(tabel) && BestaatRij(tabel, rij))
            {
                if (tabel.Rijen.Count > tabel.TypeTabel.MinRijen)
                {
                    tabel.Rijen.Remove(rij);
                }
                else { throw new DomeinException("Het minimum aantal rijen is bereikt."); }
            }
            else { throw new DomeinException("De tabel of rij bestaat niet."); }
        }

        public bool BestaatRij(Tabel tabel, Rij rij)
        {
            return tabel.Rijen.Contains(rij);
        }*/



    }
}
