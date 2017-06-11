using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnctiptionService
{
    class Service2
    {
        public void Read(IReader read)
        {
            Console.WriteLine(read.Read());
        }

        public void Write(IWriter write)
        {
            write.Write("message from service 2");
        }
    }
}
