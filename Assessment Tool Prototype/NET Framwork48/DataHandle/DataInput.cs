using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle
{
    public class DataInput
    {
        Encoding FILE_ENCODING = Encoding.UTF8;
        public string InputDataFromFile(string path)
        {
            StreamReader sr = new StreamReader(path, FILE_ENCODING);
            string content = sr.ReadToEnd();
            sr.Close();
            return content;
        }
    }
}
