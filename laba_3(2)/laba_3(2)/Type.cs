using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba_3_2_
{
    public class Type: Godnost
    {
        public string type;
        public Type(string type, string name, int price, int date, int month, int year, int term) 
            : base(name, price, date, month, year, term)
        {
            this.type = type;
        }

        public string path_cer = "Фрукти.txt";
        public string path_br = "C:Хлібобулочне.txt";
        public string path_milk = "Молочне.txt";
        public string path_wot = "Овочі.txt";
        public string path_ot = "Інше.txt";

        public void Clear_Type()
        {
            File.WriteAllText(path_cer, string.Empty);
            File.WriteAllText(path_br, string.Empty);
            File.WriteAllText(path_milk, string.Empty);
            File.WriteAllText(path_wot, string.Empty);
            File.WriteAllText(path_ot, string.Empty);
        }
        public static int cer = 0;
        public static int br = 0;
        public static int milk = 0;
        public static int wot = 0;
        public static int ot = 0;
        public void File_Type()
        {
            if(type == "Крупа")
            {
                File.AppendAllText(path_cer, $"{name} - {price}грн\n Вiд {time.ToString("d")}  до {new_time.ToString("d")}\n\n");
            }
            if (type == "Вода")
            { 
                File.AppendAllText(path_wot, $"{name} - {price}грн\n Вiд {time.ToString("d")}  до {new_time.ToString("d")}\n\n");
            }
            if (type == "Хлiбнi")
            {
                File.AppendAllText(path_br, $"{name} - {price}грн\n Вiд {time.ToString("d")}  до {new_time.ToString("d")}\n\n");
            }
            if (type == "Молочне")
            {
                File.AppendAllText(path_milk, $"{name} - {price}грн\n Вiд {time.ToString("d")}  до {new_time.ToString("d")}\n\n");
            }
            if(type == "Iнше")
            {
                File.AppendAllText(path_ot, $"{name} - {price}грн\n Вiд {time.ToString("d")}  до {new_time.ToString("d")}\n\n");
            }
        }
        public void Prind_Type()
        {
            Console.WriteLine("\n\t\tЗАГАЛЬНА IНФОРМАЦIЯ");
            if (File.Exists(path_cer))
            {
                cer++;
                if (cer == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tКрупа\n");
                }
                StreamReader reader1 = new StreamReader(path_cer);
                Console.WriteLine(reader1.ReadToEnd());
            }
            if (File.Exists(path_wot))
            {
                wot++;
                if (wot == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tВода\n");
                }
                StreamReader reader2 = new StreamReader(path_wot);
                Console.WriteLine(reader2.ReadToEnd());
            }
            if (File.Exists(path_br))
            {
                br++;
                if (br == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tХлiбнi\n");
                }
                StreamReader reader3 = new StreamReader(path_br);
                Console.WriteLine(reader3.ReadToEnd());
            }
            if (File.Exists(path_milk))
            {
                milk++;
                if (milk == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tМолочне\n");
                }
                StreamReader reader4 = new StreamReader(path_milk);
                Console.WriteLine(reader4.ReadToEnd());
            }
            if (File.Exists(path_ot))
            {
                ot++;
                if (ot == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tIнше\n");
                }
                StreamReader reader5 = new StreamReader(path_ot);
                Console.WriteLine(reader5.ReadToEnd());
            }
        }
    }
}
