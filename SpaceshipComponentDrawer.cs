using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    internal class SpaceshipComponentDrawer
    {
        //need to add in designs for all weapons, hulls and engines, then add in to construictor
        public static string WeaponBuilder(string WeaponChoice)
        {
            string WeaponLayout;

            switch (WeaponChoice)
            {
                case "Laser":
                    WeaponLayout = "    []>   ";
                    break;
                case "Missile":
                    WeaponLayout = "   [][]=>   ";
                    break;
                case "Beam":
                    WeaponLayout = "   [][]==   ";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return WeaponLayout;
        }

        public static string HullBuilder(string hullChoice)
        {
            string hullLayout;

            switch (hullChoice)
            {
                case "Basic":
                    hullLayout = "   [][]>   ";
                    break;
                case "Reinforced":
                    hullLayout = "     |[][]|>   ";
                    break; 
                case "HeavilyArmoured":
                    hullLayout = "  |[]|[]|[]|>   ";
                    break;
                default:
                    throw new NotImplementedException();
            }
            return hullLayout;
        }

        public static string EngineBuilder(string engineChoice)
        {
            string engineLayout;

            switch (engineChoice)
            {
                case "Thrusters":
                    engineLayout = "   >X   ";
                    break;
                case "DoubleBoosters":
                    engineLayout = " >X[]>   ";
                    break;
                case "HyperDrive":
                    engineLayout = " >XOO)   ";
                    break;
                default:
                     throw new NotImplementedException();   
            }
            return engineLayout;
        }
    }
}
