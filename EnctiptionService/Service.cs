using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnctiptionService
{
    class Service
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public Service(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void Read()
        {
            Console.WriteLine(_reader.Read());
        }

        public void Write()
        {
            _writer.Write("message from service");
        }


    }
}
