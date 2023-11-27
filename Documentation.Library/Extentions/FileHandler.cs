using System.Diagnostics;
using System.IO;

namespace Documentation.Library.Extentions
{
    public class FileHandler
    {
        public void StartFile(string filename)
        {
			try
			{
                var mainPath=Directory.GetParent("index.html").ToString() ;
                var myFile = Path.GetFullPath(Path.Combine(mainPath, @"..\..\..\"));
                var targetFile = $"{myFile}Client\\Index.html";
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(targetFile)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
			catch (Exception)
			{
				throw ;
			}
        }
    }
}
