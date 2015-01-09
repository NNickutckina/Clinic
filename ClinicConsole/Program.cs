using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class Program
    {
        public static void Main()
        {
            string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(path, "Databases"));
            new ConsoleUI().Run();
        }
    }
}
