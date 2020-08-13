using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeInterface.Repositiories
{
    public interface ICake
    {
        public int Eggs { get;}
        public int Milk { get;}
               
        public int Butter { get;}
        public int Flour { get;}
        public int  BakingSoda { get;}
        public int Salt { get;}
        public int VanillaEssence { get;}

        public string GetCake();
    }
}
/*Q1) An interface is a form of "contract" that forms the basis of a set of predefined properties and classes that can be used throughout your solution
  Q2) An interface contains properties and functions
  Q3) Creating an interface is done by adding a new item to the solution
  Q4) Yes
  Q5) Public and or protected internal
  Q6) Yes, public as it needs to be accessable throughout the solution*/