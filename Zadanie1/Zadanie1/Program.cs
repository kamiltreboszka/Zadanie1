using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Zadanie1
{
    class Program
    {
        public static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {        
            StreamReader stream = new StreamReader("plik.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            people = (List<Person>)serializer.Deserialize(stream);
            stream.Close();

            Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
            commands["add"] = new AddCommand();
            commands["edit"] = new EditCommand();
            commands["exit"] = new ExitCommand();
            commands["search"] = new SearchCommand();
            commands["check"] = new CheckCommand();
            commands["delete"] = new DeleteCommand();

            string currentCommand = "";
            while(currentCommand != "close")
            {
                Console.WriteLine("Commands:\n add - add a new person\n edit - edit person\n search - search a person\n check - check list of people\n delete - delete person from list\n exit - exit from app\n");
                Console.WriteLine("Give a command: ");
                currentCommand = Console.ReadLine();
                Console.Clear();
                commands[currentCommand].Execute();
            }

            Console.ReadKey();
        }
    }
}
