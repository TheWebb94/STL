using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// playerspaceship needs to be customisable in hangar then usable in scenario
// gameplay loop needs creating
// stats for different engine,wep,hull pieces need creating and adding to player ship type
// multiple enemy types with different stats, randomly fight one of 3/4
//player and enemy health, damage etc need adding and drawing in stats panel in scneario


namespace STL___Slower_Than_Light
{
    internal class Program
    {
        static void Main()
        {
            bool inGame = true;

            while (inGame == true)
            {
                DrawUI.TitleScreen();
                char menuChoice = MenuOptions.PlayerEntry(MenuNames.Title, new List<char> { '1', '2', '3'});

                switch (menuChoice)
                //while loop for remaining in combat so main menu can be returned to, same for hangar
                {
                    case '1':
                        Scenario battleScene = new Scenario();
                        battleScene.LaunchScenario();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Hangar.LaunchHangar();
                        break;
                    case '3':
                        inGame = false;
                        break;
                }
            }
        }
    }
}