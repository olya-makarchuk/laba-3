using System;
using System.Collections.Generic;

namespace laba_3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Type cereals = new Type("Крупа","Рис", 201, 6, 8, 2020, 300);
            Type cereals1 = new Type("Крупа","Гречка", 201, 21, 1, 2020, 400);
            Type water = new Type("Вода", "Газована вода", 20, 6, 5, 2020, 200);
            Type water1 = new Type("Вода", "Coca-Cola", 40, 1, 1, 2020, 100);
            Type bread = new Type("Хлiбнi","Хлiб", 10, 30, 1, 2020, 15);
            Type bread1 = new Type("Хлiбнi", "Печиво", 60, 5, 3, 2022, 10);
            Type milk = new Type("Молочне","Молоко", 100, 11, 2, 2022, 30);
            Type milk1 = new Type("Молочне","Сир", 40, 27, 5, 2019, 20);
            Type other = new Type("Iнше", "Кава", 300, 10, 11, 2015, 400);


            List<Type> list = new List<Type>();
            list.Add(cereals);
            list.Add(cereals1);
            list.Add(milk);
            list.Add(milk1);
            list.Add(bread);
            list.Add(bread1);
            list.Add(water);
            list.Add(water1);
            list.Add(other);

            bread.Clear_Price();
            foreach(Type i in list)
            {
                i.File_Price();
            }
            bread.Print_Price();

            Type.Write_Term();
            foreach (Type i in list)
            {
                i.Term();
            }
            foreach (Type i in list)
            {
                i.BadTerm();
            }
            foreach (Type i in list)
            {
                i.Jan();
            }

            bread.Clear_Type();
            foreach (Type i in list)
            {
                i.File_Type();
            }
            milk.Prind_Type();
        }
    }
}
