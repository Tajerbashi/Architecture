using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation.Library.Extentions
{
    public class FileHandler
    {
        public void StartFile(string name)
        {
            var path = "/Client";
            var root = Path.GetTempFileName();
            //System.Diagnostics.Process.Start(path);
            Console.WriteLine($@"Path : {path}");
            Console.WriteLine($@"root : {root}");
        }
    }
}
