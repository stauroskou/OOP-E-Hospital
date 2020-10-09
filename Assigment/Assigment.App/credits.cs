using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.App
{
    class credits
    {
        public credits(string text)
        {
            Console.WriteLine("ASSESSMENT 2020\n\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\nBACK Y/y: ");
            string c = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (c.ToUpper() == "Y")
            {
                Console.Clear();
                new MainApp();
            }
            
        }
    }
}
