using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeInterface.Repositiories
{
    public class ChocolateCake : ICake
    {
        public int Eggs { get; private set; }
        public int Milk { get; private set; }
        public int Butter { get; private set; }
        public int Flour { get; private set; }
        public int BakingSoda { get; private set; }
        public int Salt { get; private set; }
        public int VanillaEssence { get; private set; }

        public int CocoaPowder { get; private set; }

        public string GetCake()
        {
            string ChocCake = "Chocolate Cake";
            return ChocCake;
        }
    }
}
