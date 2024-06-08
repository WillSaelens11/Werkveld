using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelDL_SQL.Exceptions;

namespace Werkveld.TabelBL.Model.DomeinModel
{
    public class TypeKolom
    {
        public TypeKolom(string naam, string dataType)
        {
            Naam = naam;
            DataType = dataType;
        }
        public string Naam  
        { 
            get { return _naam;} 
            set { if (string.IsNullOrEmpty(value)) { throw new KolomException("Naam mag niet leeg zijn."); } _naam = value; } 
        }
        public string DataType 
        { 
            get { return _dataType;} 
            set { if (string.IsNullOrEmpty(value)) { throw new KolomException("DataType mag niet leeg zijn."); } _dataType = value; } 
        }

        private string _naam;
        private string _dataType;

    }
}
