using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class SearchCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Podaj szukany fragment: ");
            var text = Console.ReadLine();

            var query = from person in Program.people
                        where person.Name.Contains(text)
                        select person;
            query.ToList();

            PropertyInfo[] propertyInfos = typeof(Person).GetProperties();
            foreach (var person in query)
            {
                foreach (var info in propertyInfos)
                {
                    Console.WriteLine(info.Name + ": " + info.GetValue(person));
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
