using System.IO;
using System.Text;

namespace NET_Framwork48.DataHandle
{
    public class DataInputOutput
    {
        private Encoding FILE_ENCODING = Encoding.UTF8;
        public string InputDataFromFile(string path)
        {
            StreamReader sr = new StreamReader(path, FILE_ENCODING);
            string content = sr.ReadToEnd();
            sr.Close();
            return content;
        }

        public void OutputDataToFile(string path, string content)
        {
            StreamWriter sw = new StreamWriter(path, false, FILE_ENCODING);
            sw.Write(content);
            sw.Flush();
            sw.Close();
        }
    }
}
