using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Predok
    {
        const string ADDR = "https://www.epam-group.ru/about/company/epam-russia/ryazan";
        public string Organization;
        public string Level;
        public string Name;
        public string Year = "2018";

        public void InfoPr()
        {
            Console.WriteLine("Сайт: {0}\nОрганизация: {1}\nКурсы: {2}\nНазвание: {3}\nГод: {4}", ADDR, Organization, Level, Name, Year);
        }
    }
}
