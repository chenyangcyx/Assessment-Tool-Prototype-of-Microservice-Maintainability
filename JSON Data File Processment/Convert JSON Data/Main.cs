using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Convert_JSON_Data
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private long CalculateParameterNum(string str)
        {
            if (str.Contains("\":"))
            {
                string temp = str.Replace("\":", "");
                return (str.Length - temp.Length) / ("\":".Length);
            }
            return 0;
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

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！"+Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("郭其鑫_108879"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "郭其鑫_108879" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_guoqixin_108879.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_guoqixin_108879.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    //mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("焦坤_108862"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "焦坤_108862" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_jiaokun_108862.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_jiaokun_108862.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("王洪凯_108867"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "王洪凯_108867" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_wanghongkai_108867.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_wanghongkai_108867.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    //mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version1") && file_path.Contains("张耀威_108850"))
                {
                    textBox.AppendText("文件版本：Version1" + Environment.NewLine
                                        + "文件名：" + "张耀威_108850" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version1_zhangyaowei_108850.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version1_zhangyaowei_108850.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                //Version 2
                if (file_path.Contains("Version2") && file_path.Contains("顾雪珊_108875"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "顾雪珊_108875" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_guxueshan_108875.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_guxueshan_108875.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("郭其鑫_109256"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "郭其鑫_109256" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_guoqixin_108879.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_guoqixin_108879.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    //mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("贾如举_109281"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "贾如举_109281" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_jiaruju_109281.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_jiaruju_109281.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("焦坤_109248"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "焦坤_109248" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_jiaokun_108862.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_jiaokun_108862.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("王洪凯_109282"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "王洪凯_109282" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_wanghongkai_108867.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_wanghongkai_108867.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    //mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("王悦_109261"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "王悦_109261" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_wangyue_109261.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_wangyue_109261.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    //mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
                if (file_path.Contains("Version2") && file_path.Contains("张耀威_109258"))
                {
                    textBox.AppendText("文件版本：Version2" + Environment.NewLine
                                        + "文件名：" + "张耀威_109258" + Environment.NewLine);

                    sr = new StreamReader(file_path, Encoding.UTF8);
                    JSONDataStruct.Version2_zhangyaowei_108850.Rootobject rootobject = JsonConvert.DeserializeObject<JSONDataStruct.Version2_zhangyaowei_108850.Rootobject>(sr.ReadToEnd());
                    textBox.AppendText("json data info: " + rootobject.projectName + Environment.NewLine + "repository count: " + rootobject.repositories.Length + Environment.NewLine);

                    JSONDataStruct.MyNode.Rootobject mynode = new JSONDataStruct.MyNode.Rootobject();
                    // projectName
                    mynode.projectName = rootobject.projectName;
                    // repositoryInfo
                    mynode.repositoryInfo = new JSONDataStruct.MyNode.Repositoryinfo[rootobject.repositories.Length];
                    mynode.repositoryInfo[0] = new JSONDataStruct.MyNode.Repositoryinfo();
                    // repositoryURL
                    mynode.repositoryInfo[0].repositoryURL = rootobject.repositories[0].gitUrl.Replace(".git", "");
                    // gitURL
                    mynode.repositoryInfo[0].gitURL = rootobject.repositories[0].gitUrl;
                    // sha1hash
                    mynode.repositoryInfo[0].version = new JSONDataStruct.MyNode.Version();
                    mynode.repositoryInfo[0].version.sha1hash = rootobject.repositories[0].arcs[0].version.sha;
                    // tag
                    mynode.repositoryInfo[0].version.tag = rootobject.repositories[0].arcs[0].version.tag;
                    // message
                    List<JSONDataStruct.MyNode.Message> message_list = new List<JSONDataStruct.MyNode.Message>();
                    // microservice
                    mynode.microservices = new JSONDataStruct.MyNode.Microservice[rootobject.repositories[0].arcs[0].microservices.Length];
                    for (int microservice_no = 0; rootobject.repositories[0].arcs[0].microservices != null && microservice_no < rootobject.repositories[0].arcs[0].microservices.Length; microservice_no++)
                    {
                        mynode.microservices[microservice_no] = new JSONDataStruct.MyNode.Microservice();
                        // serviceName
                        mynode.microservices[microservice_no].serviceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].name;
                        // interface
                        mynode.microservices[microservice_no].interfaces = new JSONDataStruct.MyNode.Interface[rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length];
                        for (int interface_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces != null && interface_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces.Length; interface_no++)
                        {
                            mynode.microservices[microservice_no].interfaces[interface_no] = new JSONDataStruct.MyNode.Interface();
                            // interfaceName
                            mynode.microservices[microservice_no].interfaces[interface_no].interfaceName = rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // messageName
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName = new string[1];
                            mynode.microservices[microservice_no].interfaces[interface_no].messageName[0] = "message - " + rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].name;
                            // add message info to message list
                            JSONDataStruct.MyNode.Message mess_temp = new JSONDataStruct.MyNode.Message();
                            mess_temp.messageName = mynode.microservices[microservice_no].interfaces[interface_no].messageName[0];
                            mess_temp.messageContent = JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].inputParamStruct)
                                                        + JsonConvert.SerializeObject(rootobject.repositories[0].arcs[0].microservices[microservice_no].interfaces[interface_no].outputParamStruct);
                            // parameterNumber
                            mess_temp.parameterNumber = "" + CalculateParameterNum(mess_temp.messageContent);
                            message_list.Add(mess_temp);
                        }
                        // calculate microservice's call
                        Dictionary<string, List<string>> dic_servicename_interfacename = new Dictionary<string, List<string>>();
                        for (int call_no = 0; rootobject.repositories[0].arcs[0].microservices[microservice_no].call != null && call_no < rootobject.repositories[0].arcs[0].microservices[microservice_no].call.Length; call_no++)
                        {
                            if (!dic_servicename_interfacename.ContainsKey(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices))
                                dic_servicename_interfacename.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices,
                                                                    new List<string>());
                            List<string> list_temp;
                            dic_servicename_interfacename.TryGetValue(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].targetMicroservices, out list_temp);
                            list_temp.Add(rootobject.repositories[0].arcs[0].microservices[microservice_no].call[call_no].interfaceName);
                        }
                        // write call json data
                        mynode.microservices[microservice_no].call = new JSONDataStruct.MyNode.Call[dic_servicename_interfacename.Count];
                        int call_no2 = 0;
                        foreach (var node in dic_servicename_interfacename)
                        {
                            mynode.microservices[microservice_no].call[call_no2] = new JSONDataStruct.MyNode.Call();
                            mynode.microservices[microservice_no].call[call_no2].serviceName = node.Key;
                            mynode.microservices[microservice_no].call[call_no2].callInterface = new string[node.Value.Count];
                            for (int call_interface_no = 0; call_interface_no < node.Value.Count; call_interface_no++)
                                mynode.microservices[microservice_no].call[call_no2].callInterface[call_interface_no] = node.Value[call_interface_no];
                            call_no2++;
                        }
                    }
                    // message
                    // message remove duplicates
                    Dictionary<string, bool> dic_message_list = new Dictionary<string, bool>();
                    for (int i = 0; i < message_list.Count; i++)
                        if (dic_message_list.ContainsKey(message_list[i].messageName))
                            message_list.Remove(message_list[i]);
                        else
                            dic_message_list.Add(message_list[i].messageName, true);
                    mynode.messages = new JSONDataStruct.MyNode.Message[message_list.Count];
                    for (int message_no = 0; message_no < message_list.Count; message_no++)
                        mynode.messages[message_no] = message_list[message_no];

                    //output
                    textBox.AppendText("转换完毕！" + Environment.NewLine);
                    FileInfo fi = new FileInfo(file_path);
                    string out_path = fi.DirectoryName + "\\" + fi.Name.Replace(fi.Extension, "") + "_format" + fi.Extension;
                    StreamWriter sw = new StreamWriter(out_path, false, Encoding.UTF8);
                    sw.Write(JsonConvert.SerializeObject(mynode, Formatting.Indented));
                    sw.Flush();
                    sr.Close();
                    sw.Close();
                    textBox.AppendText("写入文件：" + out_path + Environment.NewLine);
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
