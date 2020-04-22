using NET_Framwork48.GlobalData;
using NET_Framwork48.Models;
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
        ////根据输入文件来更新textBox_inputdata
        //public void RefreshTextBoxInputDataByDataPath(DataHandle.JSONDataStruct.Root root,TextBox textBox)
        //{
        //    textBox.Clear();
        //    textBox.AppendText("文件路径：" + GlobalData.GlobalData.globalData.open_file_path + Environment.NewLine);
        //    textBox.AppendText("projectName：" + root.projectName + Environment.NewLine);
        //    textBox.AppendText("repositoryInfo个数：" + root.repositoryInfo.Count + Environment.NewLine);
        //    textBox.AppendText("repository信息：" + Environment.NewLine);
        //    int num = 0;
        //    foreach (var node in root.repositoryInfo)
        //        textBox.AppendText((num++) + "--repositoryURL：" + node.repositoryURL
        //                            + "--gitURL：" + node.gitURL
        //                            + "--version sha1hash：" + node.version.sha1hash
        //                            + "--version tag:" + node.version.tag
        //                            + Environment.NewLine);
        //    textBox.AppendText("microservice个数：" + root.microservices.Count + Environment.NewLine);
        //    num = 0;
        //    foreach (var node in root.microservices)
        //    {
        //        textBox.AppendText(num + "--serviceName：" + node.serviceName
        //                            + "--interface个数：" + node.interfaces.Count
        //                            + "--interface信息："
        //                            + Environment.NewLine);
        //        foreach (var node2 in node.interfaces)
        //        {
        //            textBox.AppendText(num + "--" + "interfaceName:" + node2.interfaceName
        //                                + num + "--" + "message个数："
        //                                + "message信息："
        //                                + Environment.NewLine);
        //            foreach (var node3 in node2.messageName)
        //                textBox.AppendText(num + "--" + "--" + "--" + node3 + Environment.NewLine);
        //        }
        //        textBox.AppendText(num + "--call信息：" + Environment.NewLine);
        //        foreach(var node2 in node.call)
        //        {
        //            textBox.AppendText(num + "--" +  "serviceName：" + node2.serviceName
        //                                + "callInterface个数：" + node2.callInterface.Count
        //                                + Environment.NewLine);
        //            int num3 = 0;
        //            foreach (var node3 in node2.callInterface)
        //                textBox.AppendText(num + "--" +  "--" + (num3++) + "--" + node3 + Environment.NewLine);
        //        }
        //        num++;
        //    }
        //    num = 0;
        //    foreach(var node in root.messages)
        //    {
        //        textBox.AppendText(num + "--messageName：" + node.messageName
        //                            + "--parameterNumber：" + node.parameterNumber
        //                            + "--messageContent：" + node.messageContent
        //                            + Environment.NewLine);
        //        num++;
        //    }
        //}

        ////根据评估结果显示相关信息
        //public void RefreshTextBoxAssessResult(TextBox textBox,Model model,DataHandle.JSONDataStruct.Root root)
        //{
        //    textBox.AppendText("第一层节点：" + Environment.NewLine);
        //    foreach(var node1 in model.level1_nodes)
        //    {
        //        textBox.AppendText("节点名称：" + node1.NodeName + Environment.NewLine
        //                            + "节点详细：" + node1.NodeName_Detail + Environment.NewLine
        //                            + "节点层级：" + node1.NodeLevel + Environment.NewLine
        //                            + "层级名称：" + node1.NodeLevelName + Environment.NewLine
        //                            + "节点权值：" + node1.weight + Environment.NewLine
        //                            + "是否增益：" + node1.gain_or_damage + Environment.NewLine
        //                            + "值：" + node1.value + Environment.NewLine);
        //    }
        //    textBox.AppendText(Environment.NewLine + "第二层节点：" + Environment.NewLine);
        //    foreach (var node2 in model.level2_nodes)
        //    {
        //        textBox.AppendText("节点名称：" + node2.NodeName + Environment.NewLine
        //                            + "节点详细：" + node2.NodeName_Detail + Environment.NewLine
        //                            + "节点层级：" + node2.NodeLevel + Environment.NewLine
        //                            + "层级名称：" + node2.NodeLevelName + Environment.NewLine
        //                            + "节点权值：" + node2.weight + Environment.NewLine
        //                            + "是否增益：" + node2.gain_or_damage + Environment.NewLine
        //                            + "值：" + node2.value + Environment.NewLine);
        //    }
        //    textBox.AppendText(Environment.NewLine + "第三层节点：" + Environment.NewLine);
        //    foreach (var node3 in model.level3_nodes)
        //    {
        //        textBox.AppendText("节点名称：" + node3.NodeName + Environment.NewLine
        //                            + "节点详细：" + node3.NodeName_Detail + Environment.NewLine
        //                            + "节点层级：" + node3.NodeLevel + Environment.NewLine
        //                            + "层级名称：" + node3.NodeLevelName + Environment.NewLine
        //                            + "节点权值：" + node3.weight + Environment.NewLine
        //                            + "是否增益：" + node3.gain_or_damage + Environment.NewLine
        //                            + "值：" + node3.value + Environment.NewLine);
        //    }
        //    textBox.AppendText(Environment.NewLine + "第四层节点：" + Environment.NewLine);
        //    foreach (var node4 in model.level4_nodes)
        //    {
        //        textBox.AppendText("节点名称：" + node4.NodeName + Environment.NewLine
        //                            + "节点详细：" + node4.NodeName_Detail + Environment.NewLine
        //                            + "节点层级：" + node4.NodeLevel + Environment.NewLine
        //                            + "层级名称：" + node4.NodeLevelName + Environment.NewLine
        //                            + "节点权值：" + node4.weight + Environment.NewLine
        //                            + "是否增益：" + node4.gain_or_damage + Environment.NewLine
        //                            + "值：" + node4.value + Environment.NewLine);
        //    }

        //    //输出每一个Metric的数值            
        //    textBox.AppendText(Environment.NewLine + "DIC：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.Dic_NO_ServiceName)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    foreach (var node in model.modelValue.Dic_ServiceName_NO)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    foreach (var node in model.modelValue.Dic_NO_MessageName)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    foreach (var node in model.modelValue.Dic_MessageName_NO)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText(Environment.NewLine + "Metric数值：" + Environment.NewLine);
        //    textBox.AppendText("NS：" + model.modelValue.NS + Environment.NewLine
        //                        + "NM：" + model.modelValue.NM + Environment.NewLine);
        //    textBox.AppendText("NDCS：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.NDCS_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("NDCS总数：" + model.modelValue.NDCS_TOTAL + Environment.NewLine + Environment.NewLine);

        //    textBox.AppendText("NIS：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.NIS_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("NIS总数：" + model.modelValue.NIS_TOTAL + Environment.NewLine + Environment.NewLine);

        //    textBox.AppendText("NPI：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.NPI_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("NPI总数：" + model.modelValue.NPI_TOTAL + Environment.NewLine + Environment.NewLine);

        //    textBox.AppendText("NII：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.NII_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("NII总数：" + model.modelValue.NII_TOTAL + Environment.NewLine + Environment.NewLine);

        //    textBox.AppendText("NMP：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.NMP_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("NMP总数：" + model.modelValue.NMP_TOTAL + Environment.NewLine + Environment.NewLine);

        //    textBox.AppendText("WISL：" + Environment.NewLine);
        //    foreach (var node in model.modelValue.WISL_NO_VALUE)
        //        textBox.AppendText(node.Key + "--" + node.Value + Environment.NewLine);
        //    textBox.AppendText("WISL总数：" + model.modelValue.WISL_TOTAL + Environment.NewLine + Environment.NewLine);
        //}
        //Set Label Value
        public void SetLabelValue(Label label,string str)
        {
            label.Text = str;
        }

        //更新输入文件的textBox
        public void RefreshDataInputTextBox(DataHandle.JSONDataStruct.Root root, TextBox textBox)
        {
            //清空文本框
            textBox.Clear();
            //输出概要
            string newline = GlobalData.GlobalData.globalData.newline;
            textBox.AppendText("File Path: " + GlobalData.GlobalData.globalData.open_file_path + newline);
            textBox.AppendText("projectName: " + root.projectName + newline);
            textBox.AppendText("repositoryInfo Number: " + root.repositoryInfo.Count + newline);
            textBox.AppendText("------------repository Info------------" + newline);
            int num = 0;
            foreach (var node in root.repositoryInfo)
                textBox.AppendText("repositoryURL-" + num + ": " + node.repositoryURL + newline
                                    + "gitURL-" + (num++) + ": " + node.gitURL + newline);

            textBox.AppendText("------------microservice Info------------" + newline);
            textBox.AppendText("microservice Number: " + root.microservices.Count + newline);
            num = 0;
            foreach (var node in root.microservices)
            {
                textBox.AppendText("serviceName-" + num + ": " + node.serviceName + newline
                                    + "interface Number-" + num + ": " + node.interfaces.Count + newline
                                    + "call Number-" + (num++) + ": " + node.call.Count + newline);
            }
            num = 0;
            textBox.AppendText("------------message Info------------" + newline);
            textBox.AppendText("message Number: " + root.messages.Count + newline);
            foreach (var node in root.messages)
            {
                textBox.AppendText("messageName-" + num + ": " + node.messageName + newline
                                    + "parameterNumber-" + (num++) + ": " + node.parameterNumber);
            }
            //定位光标
            textBox.Select(0, 0);
            textBox.ScrollToCaret();
        }

        //更新comboBox选项
        public void RefreshComboBox(ComboBox box, string text, object[] items)
        {
            box.Items.Clear();
            box.Text = text;
            box.Items.AddRange(items);
        }

        //更新Model Weight Level3的Label和textBox
        public void RefreshModelWeightLevel3LabelAndTextBox(Label label1, Label label2, Label label3, Label label4, Label label5,
                                                            TextBox box1, TextBox box2, TextBox box3, TextBox box4, TextBox box5)
        {
            label1.Visible = true;
            box1.Visible = true;
            label2.Visible = true;
            box2.Visible = true;
            label3.Visible = true;
            box3.Visible = true;
            label4.Visible = true;
            box4.Visible = true;
            label5.Visible = true;
            box5.Visible = true;
            label1.Text = GlobalData.GlobalData.LABEL_MODELWEIGHT_LEVEL3_PROPERTY1;
            label2.Text = GlobalData.GlobalData.LABEL_MODELWEIGHT_LEVEL3_PROPERTY2;
            label3.Text = GlobalData.GlobalData.LABEL_MODELWEIGHT_LEVEL3_PROPERTY3;
            label4.Text = GlobalData.GlobalData.LABEL_MODELWEIGHT_LEVEL3_PROPERTY4;
            label5.Text = GlobalData.GlobalData.LABEL_MODELWEIGHT_LEVEL3_PROPERTY5;
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
        }

        //更新Model Weight的Level2 textBox
        public void RefreshModelWeightLevel2TextBox(Model model,TextBox box1, TextBox box2, TextBox box3, TextBox box4)
        {
            box1.Text = model.level2_nodes[0].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level2_nodes[1].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box3.Text = model.level2_nodes[2].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box4.Text = model.level2_nodes[3].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }

        //Refresh Model Weight's Property-Analyzability
        public void RefreshModelWeightPropertyAnalyzability(Model model, Label label1, Label label2, Label label3, Label label4, Label label5,
                                                            TextBox box1, TextBox box2, TextBox box3, TextBox box4, TextBox box5)
        {
            label1.Visible = true;
            box1.Visible = true;
            label2.Visible = true;
            box2.Visible = true;
            label3.Visible = true;
            box3.Visible = true;
            label4.Visible = true;
            box4.Visible = true;
            label5.Visible = false;
            box5.Visible = false;
            label1.Text = model.modelLink.LEVEL2_LINK_3_UNITS[0][0];
            label2.Text = model.modelLink.LEVEL2_LINK_3_UNITS[0][1];
            label3.Text = model.modelLink.LEVEL2_LINK_3_UNITS[0][2];
            label4.Text = model.modelLink.LEVEL2_LINK_3_UNITS[0][3];
            box1.Text = model.level3_nodes[0].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level3_nodes[1].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box3.Text = model.level3_nodes[2].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box4.Text = model.level3_nodes[3].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }

        //Refresh Model Weight's Property-Changeability
        public void RefreshModelWeightPropertyChangeability(Model model, Label label1, Label label2, Label label3, Label label4, Label label5,
                                                            TextBox box1, TextBox box2, TextBox box3, TextBox box4, TextBox box5)
        {
            label1.Visible = true;
            box1.Visible = true;
            label2.Visible = true;
            box2.Visible = true;
            label3.Visible = true;
            box3.Visible = true;
            label4.Visible = true;
            box4.Visible = true;
            label5.Visible = true;
            box5.Visible = true;
            label1.Text = model.modelLink.LEVEL2_LINK_3_UNITS[1][0];
            label2.Text = model.modelLink.LEVEL2_LINK_3_UNITS[1][1];
            label3.Text = model.modelLink.LEVEL2_LINK_3_UNITS[1][2];
            label4.Text = model.modelLink.LEVEL2_LINK_3_UNITS[1][3];
            label5.Text = model.modelLink.LEVEL2_LINK_3_UNITS[1][4];
            box1.Text = model.level3_nodes[4].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level3_nodes[5].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box3.Text = model.level3_nodes[6].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box4.Text = model.level3_nodes[7].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box5.Text = model.level3_nodes[8].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }

        //Refresh Model Weight's Property-Stability
        public void RefreshModelWeightPropertyStability(Model model, Label label1, Label label2, Label label3, Label label4, Label label5,
                                                            TextBox box1, TextBox box2, TextBox box3, TextBox box4, TextBox box5)
        {
            label1.Visible = true;
            box1.Visible = true;
            label2.Visible = true;
            box2.Visible = true;
            label3.Visible = false;
            box3.Visible = false;
            label4.Visible = false;
            box4.Visible = false;
            label5.Visible = false;
            box5.Visible = false;
            label1.Text = model.modelLink.LEVEL2_LINK_3_UNITS[2][0];
            label2.Text = model.modelLink.LEVEL2_LINK_3_UNITS[2][1];
            box1.Text = model.level3_nodes[9].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level3_nodes[10].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }

        //Refresh Model Weight's Property-Modularity
        public void RefreshModelWeightPropertyModularity(Model model, Label label1, Label label2, Label label3, Label label4, Label label5,
                                                            TextBox box1, TextBox box2, TextBox box3, TextBox box4, TextBox box5)
        {
            label1.Visible = true;
            box1.Visible = true;
            label2.Visible = true;
            box2.Visible = true;
            label3.Visible = false;
            box3.Visible = false;
            label4.Visible = false;
            box4.Visible = false;
            label5.Visible = false;
            box5.Visible = false;
            label1.Text = model.modelLink.LEVEL2_LINK_3_UNITS[3][0];
            label2.Text = model.modelLink.LEVEL2_LINK_3_UNITS[3][1];
            box1.Text = model.level3_nodes[11].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level3_nodes[12].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }
    }
}
