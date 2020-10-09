using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assigment.Database;
using Assignment.Entities;


namespace Assigment.Services
{
    public class PrintAll
    {
        
        public static void PrintAllDocs()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-10}{1,-15}{2,-18}{3,-20}", "FirstΝame", "LastΝame", "Age", "Salary(Euro)");
            Console.ResetColor();
            foreach (var item in a.doctors)
            {
                Console.WriteLine("{0,-10}{1,-15}{2,-18}{3,-20}", item.FirstΝame,item.LastΝame,item.Age,item.Salary);
            }
        }
        public static void PrintAllDocs(string id="", string name = "", string lastname = "", string age = "", string salary = "")
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-10}{1,-15}{2,-18}{3,-20}", "FirstΝame", "LastΝame", "Age", "Salary(Euro)");
            Console.ResetColor();
            foreach (var item in a.doctors)
            {
                if (item.FirstΝame == name || item.Id.ToString() == id || item.LastΝame == lastname || item.Salary.ToString() == salary || item.Age.ToString()==age)
                {
                    Console.WriteLine("{0,-10}{1,-15}{2,-18}{3,-20}", item.FirstΝame, item.LastΝame, item.Age, item.Salary);
                }
                
            }
        }
        public static void PrintAllAddresses()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-30}{1,-10}{2,-15}{3}","Street","Country","City","PostalCode");
            Console.ResetColor();
            foreach (var item in a.addresses)
            {
                
                Console.WriteLine("{0,-30}{1,-10}{2,-19}{3}",item.Name,item.Country,item.City,item.PostalCode);
            }
        }
        public static void PrintAllAddresses(string id= "", string name = "", string lastname = "", string age = "", string salary = "")
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-30}{1,-10}{2,-15}{3}", "Street", "Country", "City", "PostalCode");
            Console.ResetColor();
            foreach (var item in a.addresses)
            {
                if (item.Name == name || item.Id.ToString() == id || item.Country == lastname || item.PostalCode.ToString() == salary || item.City.ToString() == age)
                {
                    Console.WriteLine("{0,-30}{1,-10}{2,-19}{3}", item.Name, item.Country, item.City, item.PostalCode);
                }
            }
        }
        public static void PrintAllPatients()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-12}{1,-12}{2,-5}{3,-25}{4}", "FirstName", "LastName", "Age", "EntryDate", "ExitDate");
            Console.ResetColor();
            foreach (var item in a.patients)
            {

                Console.WriteLine("{0,-12}{1,-12}{2,-5}{3,-25}{4}",item.FirstName,item.LastName,item.Age,item.EntryDate,item.ExitDate);
            }
        }
        public static void PrintAllRooms()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0}","Title");
            Console.ResetColor();
            foreach (var item in a.rooms)
            {

                Console.WriteLine("{0}",item.Title);
            }
        }
        public static void PrintAllDiseases()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0,-30}{1}", "Disease","Duration");
            Console.ResetColor();
            foreach (var item in a.diseases)
            {

                Console.WriteLine("{0,-30}{1}", item.Title,item.Duration);
            }
        }
    }
}
