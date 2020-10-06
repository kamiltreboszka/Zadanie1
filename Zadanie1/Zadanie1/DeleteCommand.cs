using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Zadanie1
{
    public class DeleteCommand: ICommand
    {
        public void Execute()
        {
            int number; int ID = 1;
            Person person = new Person();
            PropertyInfo[] propertyInfos = typeof(Person).GetProperties();
            foreach (var person1 in Program.people)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID: " + ID);
                Console.ResetColor();
                foreach (var info in propertyInfos)
                {
                    Console.WriteLine(info.Name + " " + info.GetValue(person1));
                }
                ID++;
                Console.WriteLine();
            }
            Console.WriteLine("Give ID to delete: | Enter 0 to exit");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                goto Start;
            }
            else
                number = (number - 1);

            person = Program.people[number];
            Program.people.Remove(person);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            FileStream file = new FileStream(@".\plik.xml", FileMode.Truncate);
            serializer.Serialize(file, Program.people);
            file.Close();

            Start:
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
