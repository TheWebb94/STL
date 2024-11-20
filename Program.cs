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

            bool inGame = true;

            while (inGame == true)
            {
                DrawUI.TitleScreen();
                char menuChoice = GetPlayerChoice.PlayerEntry();

                switch (menuChoice)
                //while loop for remaining in combat so main menu can be returned to, same for hangar
                {
                    case '1':
                        bool inFight = true;
                        Scenario battleScene = new Scenario();
                        battleScene.LaunchScenario();
                        FightStats stats = new FightStats(battleScene);
                        stats.Draw();
                        while (inFight == true)
                        {
                            inFight = false; //replace this with gameplay loop
                        }
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