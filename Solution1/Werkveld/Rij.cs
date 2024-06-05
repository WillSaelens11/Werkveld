using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelDL_SQL
{
    public class Rij
    {
        public int Id { get; set; }
        public List<object> Values { get; set; }

        public Rij()
        {
            Values = new List<object>();
        }

        public void AddValue(object value)
        {
            Values.Add(value);
        }

        public void RemoveValue(object value)
        {
            Values.Remove(value);
        }

        public bool ContainsValue(object value)
        {
            return Values.Contains(value);
        }
    }
}
