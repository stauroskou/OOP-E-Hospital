using Assigment.Services;
using System;

namespace Assigment.App
{
    public class MainApp
    {
        public MainApp()
        {
            Console.WriteLine("1.  List of Doctors");
            Console.WriteLine("2.  List of Adresses");
            Console.WriteLine("3.  List of Patients");
            Console.WriteLine("4.  List of Rooms");
            Console.WriteLine("5.  List of Diseases");
            Console.WriteLine("6.  Patients per room");
            Console.WriteLine("7.  Petients per Doctor");
            Console.WriteLine("8.  Petients per disease");
            Console.WriteLine("9.  Petients per address");
            Console.WriteLine("10. Doctors per address");
            Console.WriteLine("11. Addreses per patients");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWow you can actually search! just type 'Search'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Select from above: ");
            string c = Console.ReadLine();
            if (c.ToUpper()=="SEARCH")
            {
                c=c.ToUpper();
            }
            if (c.ToUpper() == "CREDITS")
            {
                c = c.ToUpper();
            }
            switch (c)
            {
                case "1":
                    Console.Clear();
                    PrintAll.PrintAllDocs();
                    Back();
                    break;
                case "2":
                    Console.Clear();
                    PrintAll.PrintAllAddresses();
                    Back();
                    break;
                case "3":
                    Console.Clear();
                    PrintAll.PrintAllPatients();
                    Back();
                    break;
                case "4":
                    Console.Clear();
                    PrintAll.PrintAllRooms();
                    Back();
                    break;
                case "5":
                    Console.Clear();
                    PrintAll.PrintAllDiseases();
                    Back();
                    break;
                case "6":
                    Console.Clear();
                    PrintsPer.PatientsPerRoom();
                    Back();
                    break;
                case "7":
                    Console.Clear();
                    PrintsPer.PatientsPerDoctor();
                    Back();
                    break;
                case "8":
                    Console.Clear();
                    PrintsPer.PatientsPerDisease();
                    Back();
                    break;
                case "9":
                    Console.Clear();
                    PrintsPer.PatientsPerAdress();
                    Back();
                    break;
                case "10":
                    Console.Clear();
                    PrintsPer.DoctorsPerAdress();
                    Back();
                    break;
                case "11":
                    Console.Clear();
                    PrintsPer.AllAddressesPerPatients();
                    Back();
                    break;
                case "SEARCH":
                    Console.Clear();
                    new search();
                    break;
                case "CREDITS":
                    Console.Clear();
                    new credits("STAUROS KOUTSOUKOS");
                    break;
                default:
                    Console.Clear();
                    new MainApp();
                    break;
            }
        }
        public void Back()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.Write("Back Y/y: ");
            Console.ResetColor();
            string b = Console.ReadLine();
            if (b == "Y" || b == "y")
            {
                Console.Clear();
                new MainApp();
            }
        }
    }
}
