using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory();

            directory.AddEmployee("Oscar", 20000, 36);
            directory.AddEmployee("Anna", 22000, 38);
            directory.AddEmployee("Göran", 18000, 42);

            Console.WriteLine("Tryck [enter] istf namn för att avsluta");

            var askForEmployee = true;
            while (askForEmployee)
            {
                // hämta anställdes namn
                string name = AskForString("Namn: ");

                if (string.IsNullOrWhiteSpace(name)) break;
                  
                // hämta anställdes lön
                int salary = AskForInt("Lön: ", "Lönen får bara innehålla siffror.");

                // hämta anställdes ålder
                int age = AskForInt("Ålder: ", "Lönen får bara innehålla siffror, ange 0 om du inte vet");

                // lägg till anställd
                directory.AddEmployee(name, salary, age);                
            }
            directory.ListEmployees();
        }

        private static int AskForInt(string question, string errorMessage)
        {
            int value;
            bool askAgain;
            do
            {
                askAgain = false; // vi utgår från att det gick bra
                var input = AskForString(question);
                if (!int.TryParse(input, out value))
                {
                    // felhantera
                    askAgain = true; // det gick inte bra, så vi måste fråga igen
                    Console.WriteLine(errorMessage);
                }
            } while (askAgain);
            return value;
        }

        private static string AskForString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
