using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1ClassLibrary
{
    public class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }
        public byte Edad { get; set; }

        public int CompareTo(Persona other)
        {
            if (this.Edad > other.Edad) return -1;

            if (this.Edad < other.Edad) return 1;

            return string.Compare(this.Nombre, other.Nombre, comparisonType: StringComparison.CurrentCultureIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Persona other = (Persona)obj;

            return this.Nombre == other.Nombre && this.Edad == other.Edad;
        }
    }
}
