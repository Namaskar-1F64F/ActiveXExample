using System.Runtime.InteropServices;
using System.IO;
using System;

namespace ActiveXExample
{
    [ComVisible(true)]
    [ProgId("ActiveXExample")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class FileSaver : IObjectSafetyImpl
    {
        [ComVisible(true)]
        public bool Exists(string path)
        {
            try
            {
                return Directory.Exists(path); //
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error thrown on lookup of path {path}\n{e.Message}\n{e.StackTrace}");
                return false;
            }
        }
    }
}
