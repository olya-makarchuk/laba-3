using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_3_2_
{
    public class Price
    {
        public string name;
        public int price;
        public Price(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string path_1 = "файл_1.txt";
        public string path_2 = "файл_2.txt";
        public string path_3 = "файл_3.txt";

        public static int num_1 = 0;
        public static int num_2 = 0;
        public static int num_3 = 0;

        public void Clear_Price()
        {
            File.WriteAllText(path_1, string.Empty);
            File.WriteAllText(path_2, string.Empty);
            File.WriteAllText(path_3, string.Empty);
        }
        public void File_Price()
        {
            if (price <= 50)
            {
                num_1++;
                File.AppendAllText(path_1,$"\t{num_1}. {name} - {price}\n");
            }

            if (price > 50 && price<=200)
            {
                num_2++;
                File.AppendAllText(path_2, $"\t{num_2}. {name} - {price}\n");
            }

            if (price > 200)
            {
                num_3++;
                File.AppendAllText(path_3, $"\t{num_3}. {name} - {price}\n");
            }
        }
        public void Print_Price()
        {
            StreamReader reader1 = new StreamReader(path_1);
            StreamReader reader2 = new StreamReader(path_2);
            StreamReader reader3 = new StreamReader(path_3);

            if (File.Exists(path_1))
            {
                Console.WriteLine($"\nТовари дешевше 50 грн: ");
                Console.WriteLine($"{reader1.ReadToEnd()}");
            }
            if (File.Exists(path_2))
            {
                Console.WriteLine($"\nТовари дорожче 50 грн i дешевше 200 грн: ");
                Console.WriteLine($"{reader2.ReadToEnd()}");
            }
            if (File.Exists(path_3))
            {
                Console.WriteLine($"\nТовари дорожче 200 грн: ");
                Console.WriteLine($"{reader3.ReadToEnd()}");
            }
        }
    }
}
