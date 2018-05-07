using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            List<Predok> list = new List<Predok>();

            Cource Obj = new Cource(Organization: "Epam Рязань", Level: "Внутренние курсы", Name: "Автоматизированное тестирование ПО");
            list.Add(Obj);

            Cource O = new Cource(Organization: "Epam Рязань", Level: "Внешние курсы", Name: "Автоматизированное тестирование ПО");
            list.Add(O);

            foreach (Cource c in list)
                c.InfoPr();

            list.Sort(Level);

            Console.WriteLine("Отсортированно: ");
            foreach (Cource c in list)
                c.InfoPr();

            Console.ReadKey();

        }

        private static int Level(Predok x, Predok y)
        {
            return x.Level.CompareTo(y.Level);
        }
    }
}
