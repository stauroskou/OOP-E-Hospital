using Assigment.Database;
using System;

namespace Assigment.Services
{
    public class PrintsPer
    {
        public static void PatientsPerRoom()
        {
            MyDatabase a = MyDatabase.GetInstance();

            Console.WriteLine("------------------------------");
            foreach (var room in a.rooms)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(room.Title);
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                foreach (var item in room.Patients)
                {
                    Console.WriteLine("{0,-10}{1}", item.FirstName, item.LastName);
                    Console.WriteLine();

                }
                Console.WriteLine("------------------------------");
            }
        }
        public static void PatientsPerDoctor()
        {
            MyDatabase a = MyDatabase.GetInstance();

            Console.WriteLine("------------------------------");
            foreach (var doc in a.doctors)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}{1,-10}{2}", "Dr. ", doc.FirstΝame, doc.LastΝame);
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                foreach (var item in doc.Patients)
                {
                    Console.WriteLine("{0,-10}{1}", item.FirstName, item.LastName);
                    Console.WriteLine();

                }
                Console.WriteLine("------------------------------");
            }
        }
        public static void PatientsPerDisease()
        {
            MyDatabase a = MyDatabase.GetInstance();

            Console.WriteLine("------------------------------");
            foreach (var dis in a.diseases)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(dis.Title);
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                foreach (var item in dis.patients)
                {
                    Console.WriteLine("{0,-10}{1}", item.FirstName, item.LastName);
                    Console.WriteLine();

                }
                Console.WriteLine("------------------------------");
            }
        }
        public static void PatientsPerAdress()
        {
            MyDatabase a = MyDatabase.GetInstance();

            Console.WriteLine("------------------------------");
            foreach (var add in a.addresses)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(add.Name);
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                foreach (var item in add.Patients)
                {
                    Console.WriteLine("{0,-10}{1}", item.FirstName, item.LastName);
                    Console.WriteLine();

                }
                Console.WriteLine("------------------------------");
            }
        }
        public static void DoctorsPerAdress()
        {
            MyDatabase a = MyDatabase.GetInstance();

            Console.WriteLine("------------------------------");
            foreach (var add in a.addresses)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(add.Name);
                Console.ResetColor();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                foreach (var item in add.doctors)
                {
                    Console.WriteLine("{0,-10}{1}", item.FirstΝame, item.LastΝame);
                    Console.WriteLine();

                }
                Console.WriteLine("------------------------------");
            }
        }
        public static void AllAddressesPerPatients()
        {
            MyDatabase a = MyDatabase.GetInstance();
            Console.WriteLine("------------------------------");
            foreach (var item in a.patients)
            {
                Console.WriteLine("------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item.FirstName);
                Console.ResetColor();
                Console.WriteLine("------------------------------\n");
                Console.WriteLine(item.address.Name);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
