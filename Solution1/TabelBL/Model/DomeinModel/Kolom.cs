using System.Data.Common;
using TabelDL_SQL.Exceptions;

namespace Werkveld.TabelBL.Model.DomeinModel
{
    public class Kolom
    {
        public Kolom(string naam, TypeKolom typeKolommen)
        {
            Naam = naam;
            TypeKolommen = typeKolommen;
        }
        public string Naam  
        { 
            get { return _naam;} 
            set { if (string.IsNullOrEmpty(value)) { throw new KolomException("Naam mag niet leeg zijn."); } _naam = value; } 
        }
        public TypeKolom TypeKolommen 
        { 
            get { return _typeKolommen;} 
            set { if (value == null) { throw new KolomException("TypeKolom mag niet leeg zijn."); } _typeKolommen = value; } 
        }

        private string _naam;
        private TypeKolom _typeKolommen;

    }
}
