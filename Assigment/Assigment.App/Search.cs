using Assigment.Database;
using System;



namespace Assigment.Services
{

    public class search
    {
        MyDatabase myDatabase = MyDatabase.GetInstance();
        string ts = "";
        string ts2 = "";
        string symbol;
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tSEARCH");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Search doctors");
            Console.WriteLine("2. Search addresses");
            Console.WriteLine("3. Search rooms");
            Console.WriteLine("4. Search diseases");
            Console.WriteLine("5. Search patients");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nBack Y/y");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void patientsOutput(string a, MyDatabase db)
        {
            if (ts2 == "1" || ts2 == "4")
            {
                Console.Write("Select symbol(<,>,=): ");
                symbol = Console.ReadLine();
            }
            Console.Clear();
            foreach (var item in db.patients)
            {
                switch (ts2)
                {
                    default:
                        break;
                    case "1":
                        if (symbol == "=")
                        {
                            if (item.Id == int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");

                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Id > int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");

                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Id < int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");

                            }
                        }
                        else
                        {
                            patientsOutput(a, db);
                        }

                        break;
                    case "2":
                        if (item.FirstName.ToString() == a)
                        {

                            Console.WriteLine($"Selected FirstName: {a}");
                            Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");

                        }
                        break;
                    case "3":
                        if (item.LastName.ToString() == a)
                        {

                            Console.WriteLine($"Selected LastName: {a}");
                            Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");

                        }
                        break;
                    case "4":
                        if (symbol == "=")
                        {
                            if (item.Age == int.Parse(a))
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");
                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Age > int.Parse(a))
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");
                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Age < int.Parse(a))
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstName}\nLastName: {item.LastName}\nAge: {item.Age}\nEntryDate: {item.EntryDate}\nExitDate: {item.ExitDate}\n{"---------"}");
                            }
                        }
                        break;
                }

            }
            back();
        }
        public void DiseasesOutput(string a, MyDatabase db)
        {
            if (ts2 == "1")
            {
                Console.Write("Select symbol(<,>,=): ");
                symbol = Console.ReadLine();
            }
            Console.Clear();
            foreach (var item in db.diseases)
            {
                switch (ts2)
                {
                    default:
                        break;
                    case "1":
                        if (symbol == "=")
                        {
                            if (item.Id == int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Id > int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Id < int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }

                        break;
                    case "2":
                        if (item.Title.ToString() == a)
                        {

                            Console.WriteLine($"Selected Title: {a}");
                            Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                        }
                        break;
                }
            }
            back();
        }
        public void roomsOutput(string a, MyDatabase db)
        {
            if (ts2 == "1")
            {
                Console.Write("Select symbol(<,>,=): ");
                symbol = Console.ReadLine();
            }
            Console.Clear();
            foreach (var item in db.rooms)
            {
                switch (ts2)
                {
                    default:
                        break;
                    case "1":
                        if (symbol == "=")
                        {
                            if (item.Id == int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Id > int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Id < int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                            }
                        }
                        break;
                    case "2":
                        if (item.Title.ToString() == a)
                        {

                            Console.WriteLine($"Selected Title: {a}");
                            Console.WriteLine($"ID: {item.Id}\nTitle: {item.Title}\n{"---------"}");

                        }
                        break;
                }
            }
            back();
        }
        public void doctorsOutput(string a, MyDatabase db)
        {
            
            if (ts2 == "5" || ts2 == "1" || ts2 == "4")
            {
                Console.Write("Select symbol(<,>,=): ");
                symbol = Console.ReadLine();
            }
            Console.Clear();
            foreach (var item in db.doctors)
            {
                switch (ts2)
                {
                    default:
                        break;
                    case "1":
                        if (symbol=="=")
                        {
                            if (item.Id == int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Id > int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Id < int.Parse(a))
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }

                        else if (symbol == ">")
                        {
                            if (item.Id.ToString() == a)
                            {

                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");


                            }
                        }
                       
                        break;
                    case "2":
                        if (item.FirstΝame.ToString() == a)
                        {

                            Console.WriteLine($"Selected FirstName: {a}");
                            Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");


                        }
                        break;
                    case "3":
                        if (item.LastΝame.ToString() == a)
                        {

                            Console.WriteLine($"Selected LastName: {a}");
                            Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");

                        }
                        break;
                    case "4":
                        if (symbol == "=")
                        {
                            if (item.Age.ToString() == a)
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Age < int.Parse(a))
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Age > int.Parse(a))
                            {
                                Console.WriteLine($"Selected Age: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        break;
                    case "5":
                        if (symbol == "=")
                        {
                            if (item.Salary == int.Parse(a))
                            {

                                Console.WriteLine($"Selected Salary: {a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");

                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Salary > int.Parse(a))
                            {

                                Console.WriteLine($"Selected Salary: better than -->{a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");

                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Salary < int.Parse(a))
                            {

                                Console.WriteLine($"Selected Salary: less than-->{a}");
                                Console.WriteLine($"ID: {item.Id}\nFirstName: {item.FirstΝame}\nLastName: {item.LastΝame}\nAge: {item.Age}\nSalary: {item.Salary} EURO\n{"---------"}");
                            }
                        }
                        break;
                }
            }
            back();
        }
        public void addressesOutput(string a, MyDatabase db)
        {
            if (ts2 == "1")
            {
                Console.Write("Select symbol(<,>,=): ");
                symbol = Console.ReadLine();
            }
            Console.Clear();
            foreach (var item in db.addresses)
            {
                switch (ts2)
                {
                    default:
                        break;
                    case "1":
                        if (symbol == "=")
                        {
                            if (item.Id == int.Parse(a))
                            {
                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");
                            }
                        }
                        else if (symbol == "<")
                        {
                            if (item.Id < int.Parse(a))
                            {
                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");
                            }
                        }
                        else if (symbol == ">")
                        {
                            if (item.Id > int.Parse(a))
                            {
                                Console.WriteLine($"Selected ID: {a}");
                                Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");
                            }
                        }

                        break;
                    case "2":
                        if (item.Name.ToString() == a)
                        {

                            Console.WriteLine($"Selected Street: {a}");
                            Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");

                        }
                        break;
                    case "3":
                        if (item.Country.ToString() == a)
                        {

                            Console.WriteLine($"Selected Country: {a}");
                            Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");

                        }
                        break;
                    case "4":
                        if (item.City.ToString() == a)
                        {

                            Console.WriteLine($"Selected City: {a}");
                            Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");

                        }
                        break;
                    case "5":
                        if (item.PostalCode.ToString() == a)
                        {

                            Console.WriteLine($"Selected PostalCode: {a}");
                            Console.WriteLine($"ID: {item.Id}\nCountry: {item.Country}\nCity: {item.City}\nStreet: {item.Name}\nPostalCode: {item.PostalCode}\n{"---------"}");

                        }
                        break;
                }

            }
            back();
        }
        public void test(string ts)
        {
            Console.WriteLine();
            Console.Write("Select from above: ");
            ts2 = Console.ReadLine();
            Console.Clear();
            if (ts2.ToUpper() == "Y")
            {
                ts2 = ts2.ToUpper();
            }
            string a = "";
            if (ts == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are searching doctors");
                Console.ForegroundColor = ConsoleColor.White;

                switch (ts2)
                {
                    default:
                        Console.Clear();
                        new search();
                        break;
                    case "1":
                        Console.Write("Select ID: ");
                        a = Console.ReadLine();
                        doctorsOutput(a, myDatabase);
                        break;
                    case "2":
                        Console.Write("Select FirstName: ");
                        a = Console.ReadLine();
                        doctorsOutput(a, myDatabase);
                        break;
                    case "3":
                        Console.Write("Select LastName: ");
                        a = Console.ReadLine();
                        doctorsOutput(a, myDatabase);
                        break;
                    case "4":
                        Console.Write("Select Age: ");
                        a = Console.ReadLine();
                        doctorsOutput(a, myDatabase);
                        break;
                    case "5":
                        Console.Write("Select Salary: ");
                        a = Console.ReadLine();
                        doctorsOutput(a, myDatabase);
                        break;
                    case "Y":
                        back(ts2);
                        break;
                }
            }
            else if (ts == "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are searching addresses");
                Console.ForegroundColor = ConsoleColor.White;
                switch (ts2)
                {
                    case "1":
                        Console.Write("Select ID: ");
                        a = Console.ReadLine();
                        addressesOutput(a, myDatabase);
                        break;
                    case "2":
                        Console.Write("Select Street: ");
                        a = Console.ReadLine();
                        addressesOutput(a, myDatabase);
                        break;
                    case "3":
                        Console.Write("Select Country: ");
                        a = Console.ReadLine();
                        addressesOutput(a, myDatabase);
                        break;
                    case "4":

                        Console.Write("Select City: ");
                        a = Console.ReadLine();
                        addressesOutput(a, myDatabase);
                        break;
                    case "5":
                        Console.Write("Select PostalCode: ");
                        a = Console.ReadLine();
                        addressesOutput(a, myDatabase);
                        break;
                    case "Y":
                        back(ts2);
                        break;
                    default:
                        Console.Clear();
                        new search();
                        break;
                }
            }
            else if (ts == "3")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are searching rooms");
                Console.ForegroundColor = ConsoleColor.White;
                switch (ts2)
                {
                    default:
                        Console.Clear();
                        new search();
                        break;
                    case "1":
                        Console.Write("Select ID: ");
                        a = Console.ReadLine();
                        roomsOutput(a, myDatabase);
                        break;
                    case "2":
                        Console.Write("Select Title: ");
                        a = Console.ReadLine();
                        roomsOutput(a, myDatabase);
                        break;
                    case "Y":
                        back(ts2);
                        break;
                }
            }
            else if (ts == "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are searching diseases");
                Console.ForegroundColor = ConsoleColor.White;
                switch (ts2)
                {
                    default:
                        Console.Clear();
                        new search();
                        break;
                    case "1":
                        Console.Write("Select ID: ");
                        a = Console.ReadLine();
                        DiseasesOutput(a, myDatabase);
                        break;
                    case "2":
                        Console.Write("Select Title: ");
                        a = Console.ReadLine();
                        DiseasesOutput(a, myDatabase);
                        break;
                    case "Y":
                        back(ts2);
                        break;
                }
            }
            else if (ts == "5")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are searching patients");
                Console.ForegroundColor = ConsoleColor.White;
                switch (ts2)
                {
                    default:
                        Console.Clear();
                        new search();
                        break;
                    case "1":
                        Console.Write("Select ID: ");
                        a = Console.ReadLine();
                        patientsOutput(a, myDatabase);
                        break;
                    case "2":
                        Console.Write("Select FirstName: ");
                        a = Console.ReadLine();
                        patientsOutput(a, myDatabase);
                        break;
                    case "3":
                        Console.Write("Select LastName: ");
                        a = Console.ReadLine();
                        patientsOutput(a, myDatabase);
                        break;
                    case "4":
                        Console.Write("Select Age: ");
                        a = Console.ReadLine();
                        patientsOutput(a, myDatabase);
                        break;
                    case "Y":
                        back(ts2);
                        break;
                }
            }
        }
        public void SubMenu()
        {
            Console.WriteLine();
            Console.Write("Select from above: ");
            ts = Console.ReadLine();
            if (ts.ToUpper() == "Y")
            {
                ts = ts.ToUpper();
            }
            Mainmenu(ts);
            switch (ts)
            {
                case "1":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are searching doctors");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. By id");
                    Console.WriteLine("2. By firstname");
                    Console.WriteLine("3. By lastname");
                    Console.WriteLine("4. By age");
                    Console.WriteLine("5. By salary");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nY. Back");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are searching addresses");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. By id");
                    Console.WriteLine("2. By street");
                    Console.WriteLine("3. By country");
                    Console.WriteLine("4. By city");
                    Console.WriteLine("5. By postalcode");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nY. Back");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are searching rooms");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. By id");
                    Console.WriteLine("2. By title");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nY. Back");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are searching diseases");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. By id");
                    Console.WriteLine("2. By title");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nY. Back");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are searching patients");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. By id");
                    Console.WriteLine("2. By firstname");
                    Console.WriteLine("3. By lastname");
                    Console.WriteLine("4. By age");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nY. Back");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.Clear();
                    new search();
                    break;
            }
        }
        public void back()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\nBack Y/y: ");
            Console.ForegroundColor = ConsoleColor.White;
            string str = Console.ReadLine();
            if (str.ToUpper() == "Y")
            {
                Console.Clear();
                new search();
            }
        }
        public void back(string str)
        {
            if (str.ToUpper() == "Y")
            {
                Console.Clear();
                new search();
            }
        }
        public void Mainmenu(string str)
        {

            if (str.ToUpper() == "Y")
            {
                Console.Clear();
                new App.MainApp();
            }
        }
        public search()
        {

            Menu();
            SubMenu();
            test(ts);

        }
    }
}
