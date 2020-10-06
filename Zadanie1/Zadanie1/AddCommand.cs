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
    public class AddCommand: ICommand
    {
        public void Execute()
        {
            Person person = new Person();
            PropertyInfo[] propertyInfos = typeof(Person).GetProperties();
            foreach (var info in propertyInfos)
            {
                Console.WriteLine("Setting " + info.Name);
                string value = Console.ReadLine();
                info.SetValue(person, Convert.ChangeType(value, info.PropertyType));
            }

            Program.people.Add(person);
            foreach(var person1 in Program.people)
            {
                foreach(var info in propertyInfos)
                {
                    Console.WriteLine(info.Name + ": " + info.GetValue(person1));
                }
                Console.WriteLine();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            FileStream file = new FileStream(@".\plik.xml", FileMode.Truncate);
            serializer.Serialize(file, Program.people);
            file.Close();

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
