using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Director : IPrinteble
    {
        string nameOfposition = "Director";
        public string PrintName()
        {
            return nameOfposition;
        }
    }
}

