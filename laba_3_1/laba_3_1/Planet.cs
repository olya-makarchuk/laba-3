using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_1
{
    public class Planet
    {
        public List<string> list;
        public Planet(List<string> list)
        {
            this.list = list;
        }
        public override string ToString()
        {
            return $"Кiлькiсть планет в зорянiй системi: {list.Count}";
        }

        public void Plus_planet()
        {
            string temp = Convert.ToString(Console.ReadLine());
            list.Add(temp);
            Console.WriteLine(ToString());
        }

        public string GetHashCode(string list)
        {
            return $"{list.GetHashCode()}";
        }
        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($" {list[i]} {GetHashCode(list[i])}");
            }
        }

    }
}