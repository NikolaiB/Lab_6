using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    public class Contract : IDocumenteble
    {
        public uint NumDoc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataDoc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
