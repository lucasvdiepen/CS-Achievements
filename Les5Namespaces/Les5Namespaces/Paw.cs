using System;
using System.Collections.Generic;
using System.Text;

namespace PawNamespace
{
    class Paw
    {
        private bool isClean = false;

        public void Clean()
        {
            isClean = true;
        }

        public bool IsClean()
        {
            return isClean;
        }
    }
}
