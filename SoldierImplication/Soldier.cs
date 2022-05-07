using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierImplication
{
    public abstract class Soldier
    {
        string Name { get; }
        int Damage { get; }
        int HP { get; }

        public const string StandartSoldier = "standart soldier";
        public const string EliteSoldier = "elite soldier";
        public const string ManInBlack = "main in black";

        public static Soldier Create(string input)
        {
            return input switch
            {
                StandartSoldier => new StandartSoldier(),
                EliteSoldier => new EliteSoldier(),
                ManInBlack => new ManInBlack(),
                _ => throw new Exception(), // or null
            };
        } 
    }
}
