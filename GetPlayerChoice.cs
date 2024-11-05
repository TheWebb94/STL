using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class GetPlayerChoice
    {
        public static string PlayerEntry()
        {
            MenuOptions.SetCursorLocationTitleMenu();
            string userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                MenuOptions.SetCursorLocationTitleMenu();
                Console.WriteLine("                  ");
                return PlayerEntry();
            }
            else
            {
                return userInput;
            }
        }
    }
}
