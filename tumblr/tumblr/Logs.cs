using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblr
{
    class Logs
    {
        public void ILogs(string text, string type)
        {
            using (FileStream fs = new FileStream("C:\\Social\\tumblr\\" + type + "\\Results.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(text);
            }
        }

        public void IErrors(string text, string type)
        {
            using (FileStream fs = new FileStream("C:\\Social\\tumblr\\" + type + "\\Errors.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(text);
            }
        }
    }
}
