using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium
{
    class TextFileUtility
    {
        public static IEnumerable<string> GetAllTextFromFile(string fileName)
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            var text = File.ReadAllText(path);

            var data = text?.Split('|');

            if (data.Any())
                return data;

            return null;
        }
    }
}
