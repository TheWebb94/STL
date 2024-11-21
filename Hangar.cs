using STL___Slower_Than_Light.Spaceships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class Hangar
    {
        public static void LaunchHangar()
        {
            bool inHangar = true;

            Console.Clear();
            DrawUI.Hangar();
            PlayerShipManager.playerSpaceship.DrawShip();
            MenuOptions.HangerMenuOptions();


            while (inHangar)
            {
                char menuChoice = MenuOptions.PlayerEntry(MenuNames.Hangar, new List<char> { '1', '2', '3', '4'});

                switch (menuChoice)
                {
                    case '1':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.EngineOptions();
                        UpgradeEngine();
                        break;

                    case '2':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.HullOptions();
                        UpgradeHull();
                        break;

                    case '3':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.WeaponOptions();
                        UpgradeWeapons();
                        break;
                    case '4':
                        inHangar = false;
                        break;

                    default:
                        break;
                }
            }
            Console.Clear();
        }

        private static void UpgradeWeapons()
        {
            bool choosingWeapon = true;
            while (choosingWeapon)
            {
                char weaponChoice = MenuOptions.PlayerEntry(MenuNames.Hangar, new List<char> { '1', '2', '3', '4' });

                switch (weaponChoice)
                {
                    case '1':
                        if (PlayerShipManager.playerSpaceship.Weapon == ShipWeapons.Laser)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("weapon is already a laser.                 ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Weapon = ShipWeapons.Laser;
                            Console.WriteLine("weapon set to laser!                   ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '2':
                        if (PlayerShipManager.playerSpaceship.Weapon == ShipWeapons.Missile)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Weapon is already at missile.          ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Weapon = ShipWeapons.Missile;
                            Console.WriteLine("Weapon set to missille!              ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '3':
                        if (PlayerShipManager.playerSpaceship.Weapon == ShipWeapons.Beam)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Weapon is already at Beam.            ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Weapon = ShipWeapons.Beam;
                            Console.WriteLine("Weapon set to Beam!                ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '4':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.HangerMenuOptions();
                        choosingWeapon = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }


                if (choosingWeapon)
                {
                    DrawUI.Hangar();
                    PlayerShipManager.playerSpaceship.DrawShip();
                    MenuOptions.EngineOptions();
                }
            }
        }

        private static void UpgradeEngine()
        {
            bool choosingEngine = true;
            while (choosingEngine)
            {
                char engineChoice = MenuOptions.PlayerEntry(MenuNames.Hangar, new List<char> { '1', '2', '3', '4' });

                switch (engineChoice)
                {
                    case '1':
                        if (PlayerShipManager.playerSpaceship.Engine == ShipEngineLevel.Thrusters)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Engine is already a thruster.                 ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Engine = ShipEngineLevel.Thrusters;
                            Console.WriteLine("Engine set to Thrusters!                   ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '2': 
                        if (PlayerShipManager.playerSpaceship.Engine == ShipEngineLevel.DoubleBoosters)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Engine is already at Double Boosters.          ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Engine = ShipEngineLevel.DoubleBoosters;
                            Console.WriteLine("Engine set to Double Boosters!              ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '3':
                        if (PlayerShipManager.playerSpaceship.Engine == ShipEngineLevel.HyperDrive)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Engine is already at HyperDrive.            ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Engine = ShipEngineLevel.HyperDrive;
                            Console.WriteLine("Engine set to HyperDrive!                ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '4':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.HangerMenuOptions();
                        choosingEngine = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

               
                if (choosingEngine)
                {
                    DrawUI.Hangar();
                    PlayerShipManager.playerSpaceship.DrawShip();
                    MenuOptions.EngineOptions();
                }
            }

        }
        private static void UpgradeHull()
        {
            bool choosingHull = true;
            while (choosingHull)
            {
                char hullChoice = MenuOptions.PlayerEntry(MenuNames.Hangar, new List<char> { '1', '2', '3', '4' });

                switch (hullChoice)
                {
                    case '1':
                        if (PlayerShipManager.playerSpaceship.Hull == ShipHullLevel.Basic)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Hull is already a basic hull.                 ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Hull = ShipHullLevel.Basic;
                            Console.WriteLine("Engine set to Thrusters!                   ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '2':
                        if (PlayerShipManager.playerSpaceship.Hull == ShipHullLevel.Reinforced)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Hull is already reinforced.          ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Hull = ShipHullLevel.Reinforced;
                            Console.WriteLine("Hull set to reinforced!              ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '3':
                        if (PlayerShipManager.playerSpaceship.Hull == ShipHullLevel.HeavilyArmoured)
                        {
                            MenuOptions.ResetCursorPosition(MenuNames.Hangar);
                            Console.WriteLine("Hull is already at Heavily armoured.            ");
                        }
                        else
                        {
                            PlayerShipManager.playerSpaceship.Hull = ShipHullLevel.HeavilyArmoured;
                            Console.WriteLine("Hull set to heavily armoured!                ");
                            PlayerShipManager.playerSpaceship.DrawShip();
                        }
                        break;

                    case '4':
                        Console.Clear();
                        DrawUI.Hangar();
                        PlayerShipManager.playerSpaceship.DrawShip();
                        MenuOptions.HangerMenuOptions();
                        choosingHull = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }


                if (choosingHull)
                {
                    DrawUI.Hangar();
                    PlayerShipManager.playerSpaceship.DrawShip();
                    MenuOptions.EngineOptions();
                }
            }
        }

    }

}
