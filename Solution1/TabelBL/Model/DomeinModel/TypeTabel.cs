using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelBL.Model.DomeinModel;
using TabelDL_SQL.Exceptions;

namespace Werkveld.TabelBL.Model.DomeinModel
{
    public class TypeTabel
    {
        public TypeTabel(int typeID, string naam, EnumTypeTabel typeTabellen, int? aantalKolommen, int? minKolommen)
        {
            TypeID = typeID;    // wordt dit aangemaakt door databank?
            Naam = naam;
            TypeTabellen = typeTabellen;
            AantalKolommen = aantalKolommen;
            MinKolommen = minKolommen;
            MogelijkeKolommen = new List<TypeKolom>();
        }

        public int TypeID { get; set; } // wordt dit aangemaakt door databank?
        public string Naam 
        { 
            get { return _naam;} 
            set { if (string.IsNullOrWhiteSpace(value)) { throw new TabelException("Naam mag niet leeg zijn.");} _naam = value;}
        }
        public EnumTypeTabel TypeTabellen 
        { 
            get { return _typeTabellen;}
            set
            {
                if (value != EnumTypeTabel.Vast && value != EnumTypeTabel.Variabel)
                {
                   _typeTabellen = value;
                }
                else { throw new TabelException("Type tabel moet vast of variabel zijn.");}
            }
 
        }
        public int? AantalKolommen { get; set; } 
        public List<TypeKolom> MogelijkeKolommen { get; set; }
       
        public int? MaxKolommen { get; set; }
        public int? MinKolommen { get; set; }
       /* public int? MaxRijen { get; set; }
        public int? MinRijen { get; set; }*/

        private string _naam;
        private EnumTypeTabel _typeTabellen;

    }
}
