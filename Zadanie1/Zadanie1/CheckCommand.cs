using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class CheckCommand: ICommand
    {
        public void Execute()
        {
            Person person = new Person();
            PropertyInfo[] propertyInfos = typeof(Person).GetProperties();
            foreach (var person1 in Program.people)
            {
                foreach (var info in propertyInfos)
                {
                    Console.WriteLine(info.Name + ": " + info.GetValue(person1));
                }
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine();
            }
            
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
