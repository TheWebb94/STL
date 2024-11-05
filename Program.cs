using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Program
    {
        static void Main()
        {
            //Draw main menu 
            Draw.TitleScreen();

            Console.SetCursorPosition(3, 26);

            string menuChoice = Console.ReadLine();

            switch (menuChoice)

            {
                case "1":
                    Console.Clear();
                    Draw.Scenario();
                    break;
            }
            Console.ReadLine();
        }
    }
}