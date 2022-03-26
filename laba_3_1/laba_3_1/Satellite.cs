using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_1
{
    public class Satellite
    {
        public string Name { get; set; } = "";
        public override string ToString()
        {
            return $"Назва супутника Землi: {Name}";
        }
        public override bool Equals(object obj)
        {

            if (obj == null || !(obj is Satellite))
                return false;
            else
                return Name == ((Satellite)obj).Name;
        }
    }
}
