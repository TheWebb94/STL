using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*to be done:
    enemy ship spawns in a random location
    move level loaders into own classes
*/
namespace STL___Slower_Than_Light
{
    internal class Program
    {
        static void Main()
        {
            
            DrawUI.TitleScreen();

            string menuChoice = GetPlayerChoice.PlayerEntry();

            switch (menuChoice)
                //while loop for remaining in combat so main menu can be returned to, same for hangar
            {
                case "1":
                    Scenario.LaunchScenario();
                    break;
                case "2":
                    Hangar.LaunchHangar();


                    break;
            }
            Console.ReadLine();
        }
    }
}