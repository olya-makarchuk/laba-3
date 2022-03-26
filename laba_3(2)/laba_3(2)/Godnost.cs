using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba_3_2_
{
    public class Godnost : Price
    {
        public int date;
        public int month;
        public int year;
        public int term;
        public static int new_term;
        public DateTime time;
        public DateTime new_time;
        public Godnost(string name, int price, int date, int month, int year, int term) : base(name, price)
        {
            this.date = date;
            this.month = month;
            this.year = year;
            this.term = term;
        }

        public static int num1 = 0;
        public static int num2 = 0;
        public static int num3 = 0;

        public static int Write_Term()
        {
            Console.Write("Введiть термiн придатностi товару: ");
            new_term = Convert.ToInt32(Console.ReadLine());
            return new_term;
        }

        
        public void Term()
        {
            if (term == new_term)
            {
                num1++;
                Console.WriteLine($"\t{num1} {name}");
            }
        }

        public void BadTerm()
        {
            time = new DateTime(year, month, date);
            new_time = time.AddDays(term);
            int com = DateTime.Now.Date.CompareTo(new_time);
            if (com < 0)
            {
                num2++;
                if (num2 == 1)
                {
                    Console.WriteLine($"\nПростроченi товари:");
                }
                Console.WriteLine($"\t{num2} {name}");
            }
        }

        public void Jan()
        {
            if (time.Month == 1 && time.Year == 2020)
            {
                num3++;
                if (num3 == 1)
                {
                    Console.WriteLine("\nТвори виготовленi у сiчнi 2020:");
                }
                Console.WriteLine($"\t{num3} {name}");
            }
        }


    }
}
