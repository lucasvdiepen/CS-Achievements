using System;
using System.Collections.Generic;
using System.Text;

namespace DogNamespace
{
    class Dog
    {
        private PawNamespace.Paw paw;

        public Dog()
        {
            paw = new PawNamespace.Paw();
        }

        public PawNamespace.Paw GetPaw()
        {
            return paw;
        }
    }
}
