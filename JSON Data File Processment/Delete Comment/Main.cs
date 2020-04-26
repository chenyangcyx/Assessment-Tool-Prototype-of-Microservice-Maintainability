using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete_Comment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool if_empty_line(string line)
        {
            bool result = true;
            foreach (var ch in line)
                if ((!ch.Equals(' ')) && (!ch.Equals('\t')))
                    result = false;
            return result;
        }

        private int FindMaxValue(List<int> list)
        {
            int max = list[0];
            foreach (var num in list)
                if (num >= max)
                    max = num;
            return max;
        }

        private void button_inputdata_Click(object sender, EventArgs e)
        {
            textBox.Clear();

            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "Choose the JSON File";
            open_file.RestoreDirectory = false;
            open_file.Filter = "JSON File(*.json)|*.json";
            open_file.FilterIndex = 0;
            open_file.Multiselect = false;
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                string file_path = open_file.FileName;
                StreamReader sr = new StreamReader(file_path, Encoding.UTF8);
                FileInfo fi = new FileInfo(file_path);
                StreamWriter sw = new StreamWriter(fi.DirectoryName + "\\new_file.json", false, Encoding.UTF8);
                sw.AutoFlush = true;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("//"))
                    {
                        List<int> list = new List<int>();
                        list.Add(line.LastIndexOf(","));
                        list.Add(line.LastIndexOf("\""));
                        list.Add(line.LastIndexOf("["));
                        int max_pos = FindMaxValue(list);
                        int comment_pos = line.LastIndexOf("//");
                        if(comment_pos>max_pos)
                        {
                            textBox.AppendText("找到带评论的行：" + line + Environment.NewLine);
                            textBox.AppendText("更改后是否空行：");
                            string new_line = line.Substring(0, line.IndexOf(@"//"));
                            bool if_empty = if_empty_line(new_line);
                            textBox.AppendText(if_empty + Environment.NewLine);
                            textBox.AppendText("更改后内容：" + new_line + Environment.NewLine + Environment.NewLine);
                            if (!if_empty)
                                sw.WriteLine(new_line);
                        }
                        else
                            sw.WriteLine(line);
                    }
                    else
                    {
                        bool if_empty = if_empty_line(line);
                        if (!if_empty)
                            sw.WriteLine(line);
                    }
                }
                sr.Close();
                sw.Flush();
                sw.Close();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
