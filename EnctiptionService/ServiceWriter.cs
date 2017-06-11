using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnctiptionService
{
    class ServiceWriter : IWriter
    {
        public void Write(string something)
        {
            Console.WriteLine(something + " Service writer");
        }
    }
}
