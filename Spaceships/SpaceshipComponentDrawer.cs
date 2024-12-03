using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STL___Slower_Than_Light
{
    /// <summary>
    /// Class that stores the drawings for each component of the customisable ship 
    /// </summary>
    internal class SpaceshipComponentDrawer
    {
       
        //all weapon options
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

        //all hull options
        public static string HullBuilder(string hullChoice)
        {
            string hullLayout;

            switch (hullChoice)
            {
                case "Basic":
                    hullLayout = "   [][]>        ";
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

        //all engine options
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
