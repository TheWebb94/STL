using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// gameplay loop needs creating
// multiple enemy types with different stats, randomly fight one of 3/4


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
                {
                    case '1':
                        Scenario battleScene = new Scenario();
                        battleScene.LaunchScenario();
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