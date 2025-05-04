using System;
using System.Runtime.InteropServices;

namespace ComClass
{
    // Define an interface for COM
    [ComVisible(true), Guid("B2C3D4E5-F6A1-2345-6789-0ABCDE123456")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IHelloCom
    {
        string SayHello(string name);
    }


    // Make the class COM-visible
    [ComVisible(true), Guid("A1B2C3D4-E5F6-1234-5678-90ABCDEF1234")]
    internal class HelloCom : IHelloCom
    {
        public string SayHello(string name)
        {
            return $"Hello, {name} from COM!";
        }
    }
}
