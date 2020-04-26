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
using Convert_JSON_Data.JSONDataStruct.Version1_guxueshan_108875;
using Convert_JSON_Data.JSONDataStruct.Version1_guoqixin_108879;
using Convert_JSON_Data.JSONDataStruct.Version1_jiaokun_108862;
using Convert_JSON_Data.JSONDataStruct.Version1_wanghongkai_108867;
using Convert_JSON_Data.JSONDataStruct.Version1_zhangyaowei_108850;
using Convert_JSON_Data.JSONDataStruct.Version2_guxueshan_108875;
using Convert_JSON_Data.JSONDataStruct.Version2_guoqixin_108879;
using Convert_JSON_Data.JSONDataStruct.Version2_jiaruju_109281;
using Convert_JSON_Data.JSONDataStruct.Version2_jiaokun_108862;
using Convert_JSON_Data.JSONDataStruct.Version2_wanghongkai_108867;
using Convert_JSON_Data.JSONDataStruct.Version2_wangyue_109261;
using Convert_JSON_Data.JSONDataStruct.Version2_zhangyaowei_108850;
using Newtonsoft.Json;

namespace Convert_JSON_Data
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
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
                textBox.AppendText("File Path: " + file_path + Environment.NewLine);
                StreamReader sr = null;
                //Version 1
                if (file_path.Contains("Version1") && file_path.Contains("顾雪珊_108875"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "顾雪珊_108875" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_guxueshan_108875.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_guxueshan_108875.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                }
                if (file_path.Contains("Version1") && file_path.Contains("郭其鑫_108879"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "郭其鑫_108879" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_guoqixin_108879.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_guoqixin_108879.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("焦坤_108862"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "焦坤_108862" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_jiaokun_108862.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_jiaokun_108862.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("王洪凯_108867"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "王洪凯_108867" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_wanghongkai_108867.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_wanghongkai_108867.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("张耀威_108850"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "张耀威_108850" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_zhangyaowei_108850.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_zhangyaowei_108850.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                //Version 2
                if (file_path.Contains("Version2") && file_path.Contains("顾雪珊_108875"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "顾雪珊_108875" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_guxueshan_108875.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_guxueshan_108875.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("郭其鑫_109256"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "郭其鑫_109256" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_guoqixin_108879.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_guoqixin_108879.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("贾如举_109281"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "贾如举_109281" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_jiaruju_109281.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_jiaruju_109281.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("焦坤_109248"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "焦坤_109248" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_jiaokun_108862.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_jiaokun_108862.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("王洪凯_109282"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "王洪凯_109282" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_wanghongkai_108867.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_wanghongkai_108867.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("王悦_109261"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "王悦_109261" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_wangyue_109261.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_wangyue_109261.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("张耀威_109258"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "张耀威_109258" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_zhangyaowei_108850.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_zhangyaowei_108850.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);
                }

                sr.Close();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
