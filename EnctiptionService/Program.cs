using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnctiptionService
{
    class Program
    {
        static void Main(string[] args)
        {
            //ByConstructor();

            ByMethod();

            //ByProperty();

            Console.ReadLine();
        }

        private static void ByProperty()
        {
            var reader = new FileReader();
            var writer = new ServiceWriter();
            Service3 service3 = new Service3();
            service3.Reader = reader;
            service3.Writer = writer;
            service3.Read();
            service3.Write();
        }

        private static void ByMethod()
        {
            var reader = new DBReader();
            var writer = new FileWriter();
            Service2 service2 = new Service2();
            service2.Read(reader);
            service2.Write(writer);
        }

        private static void ByConstructor()
        {
            var reader = new FileReader();
            var writer = new ServiceWriter();
            Service service = new Service(reader, writer);
            service.Read();
            service.Write();
        }
    }
}
