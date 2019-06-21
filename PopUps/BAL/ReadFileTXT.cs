using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopUps.BAL
{
    public static class ReadFileTXT
    {
        public static List<string> ReadlineText(string path)
        {
            List<string> listQuestion = new List<string>();
            var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listQuestion.Add(line);
                }
            }
            return listQuestion;
        }

    }
}
