using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Framwork48.UIDesign
{
    class UIRefresh
    {
        //根据输入文件来更新textBox_inputdata
        public void RefreshTextBoxInputDataByDataPath(DataHandle.JSONDataStruct.Root root,TextBox textBox)
        {
            textBox.Clear();
            textBox.AppendText("文件路径：" + GlobalData.GlobalData.globalData.open_file_path + Environment.NewLine);
            textBox.AppendText("projectName：" + root.projectName + Environment.NewLine);
            textBox.AppendText("repositoryInfo个数：" + root.repositoryInfo.Count + Environment.NewLine);
            textBox.AppendText("repository信息：" + Environment.NewLine);
            int num = 0;
            foreach (var node in root.repositoryInfo)
                textBox.AppendText((num++) + "--repositoryURL：" + node.repositoryURL
                                    + "--gitURL：" + node.gitURL
                                    + "--version sha1hash：" + node.version.sha1hash
                                    + "--version tag:" + node.version.tag
                                    + Environment.NewLine);
            textBox.AppendText("microservice个数：" + root.microservices.Count + Environment.NewLine);
            num = 0;
            foreach (var node in root.microservices)
            {
                textBox.AppendText(num + "--serviceName：" + node.serviceName
                                    + "--interface个数：" + node.interfaces.Count
                                    + "--interface信息："
                                    + Environment.NewLine);
                foreach (var node2 in node.interfaces)
                {
                    textBox.AppendText(num + "--" + "interfaceName:" + node2.interfaceName
                                        + num + "--" + "message个数："
                                        + "message信息："
                                        + Environment.NewLine);
                    foreach (var node3 in node2.messageName)
                        textBox.AppendText(num + "--" + "--" + "--" + node3 + Environment.NewLine);
                }
                textBox.AppendText(num + "--call信息：" + Environment.NewLine);
                foreach(var node2 in node.call)
                {
                    textBox.AppendText(num + "--" +  "serviceName：" + node2.serviceName
                                        + "callInterface个数：" + node2.callInterface.Count
                                        + Environment.NewLine);
                    int num3 = 0;
                    foreach (var node3 in node2.callInterface)
                        textBox.AppendText(num + "--" +  "--" + (num3++) + "--" + node3 + Environment.NewLine);
                }
                num++;
            }
            num = 0;
            foreach(var node in root.messages)
            {
                textBox.AppendText(num + "--messageName：" + node.messageName
                                    + "--parameterNumber：" + node.parameterNumber
                                    + "--messageContent：" + node.messageContent
                                    + Environment.NewLine);
                num++;
            }
        }
    }
}
