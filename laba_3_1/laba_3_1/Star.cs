using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_1
{
    public class Star
    {
        public string Name { get; set; } = "";
        public override string ToString()
        {
            return $"Назва зiрки: {Name}";
        }

    }
}
