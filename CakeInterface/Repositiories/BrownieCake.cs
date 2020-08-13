using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeInterface.Repositiories
{
    public class BrownieCake : ICake
    {
        public int Eggs => throw new NotImplementedException();

        public int Milk => throw new NotImplementedException();

        public int Butter => throw new NotImplementedException();

        public int Flour => throw new NotImplementedException();

        public int BakingSoda => throw new NotImplementedException();

        public int Salt => throw new NotImplementedException();

        public int VanillaEssence => throw new NotImplementedException();

        public string GetCake()
        {
            string ChocCake = "Chocolate Cake";
            return ChocCake;
        }

        private bool BakeCake()
        {
            return true;
        }

        private bool LetCakeRest()
        {
            return true;
        }
    }
}
