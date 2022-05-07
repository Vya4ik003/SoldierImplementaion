using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierImplication
{
    class EliteSoldier : Soldier
    {
        public string Name { get;  }

        public int Damage { get; }

        public int HP { get; }

        public string Railgun { get; }

        public string Shield { get; }
    }
}
