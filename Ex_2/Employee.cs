using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Employee : IPrinteble
    {
        string nameOfposition = "Employee";
        public string PrintName()
        {
            return nameOfposition;
        }
    }
}
