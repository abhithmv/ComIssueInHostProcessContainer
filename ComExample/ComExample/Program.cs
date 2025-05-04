using ComClass;
using System;

namespace ComExample
{
    class Program
    {
        private const string ComInterfaceGuid = "A1B2C3D4-E5F6-1234-5678-90ABCDEF1234";

        static void Main(string[] args)
        {
            var type = Type.GetTypeFromCLSID(Guid.Parse(ComInterfaceGuid));
            // Create an instance of the COM object 
            var comObject = Activator.CreateInstance(type) as IHelloCom;
            Console.WriteLine(comObject.SayHello("World"));
        }
    }
}
