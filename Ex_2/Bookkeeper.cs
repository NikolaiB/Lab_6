using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Bookkeeper : IPrinteble
    {
        string nameOfposition = "Bookkeeper";
        public string PrintName()
        {
            return nameOfposition;
        }
    }
}
