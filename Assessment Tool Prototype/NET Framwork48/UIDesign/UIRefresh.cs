using NET_Framwork48.Models;
using System.Windows.Forms;

namespace NET_Framwork48.UIDesign
{
    internal class UIRefresh
    {
        // //update textBox_inputdata according to the input file
        // public void RefreshTextBoxInputDataByDataPath(DataHandle.JSONDataStruct.Root root, TextBox textBox)
        // {
        //     textBox.Clear();
        //     string new_line = GlobalData.GlobalData.globalData.newline;
        //     textBox.AppendText("文件路径：" + GlobalData.GlobalData.globalData.open_file_path + new_line);
        //     textBox.AppendText("projectName：" + root.projectName + new_line);
        //     textBox.AppendText("repositoryInfo个数：" + root.repositoryInfo.Count + new_line);
        //     textBox.AppendText("repository信息：" + new_line);
        //     int num = 0;
        //     foreach (var node in root.repositoryInfo)
        //         textBox.AppendText((num++) + "--repositoryURL：" + node.repositoryURL
        //                             + "--gitURL：" + node.gitURL
        //                             + "--version sha1hash：" + node.version.sha1hash
        //                             + "--version tag:" + node.version.tag
        //                             + new_line);
        //     textBox.AppendText("microservice个数：" + root.microservices.Count + new_line);
        //     num = 0;
        //     foreach (var node in root.microservices)
        //     {
        //         textBox.AppendText(num + "--serviceName：" + node.serviceName
        //                             + "--interface个数：" + node.interfaces.Count
        //                             + "--interface信息："
        //                             + new_line);
        //         foreach (var node2 in node.interfaces)
        //         {
        //             textBox.AppendText(num + "--" + "interfaceName:" + node2.interfaceName
        //                                 + num + "--" + "message个数："
        //                                 + "message信息："
        //                                 + new_line);
        //             foreach (var node3 in node2.messageName)
        //                 textBox.AppendText(num + "--" + "--" + "--" + node3 + new_line);
        //         }
        //         textBox.AppendText(num + "--call信息：" + new_line);
        //         foreach (var node2 in node.call)
        //         {
        //             textBox.AppendText(num + "--" + "serviceName：" + node2.serviceName
        //                                 + "callInterface个数：" + node2.callInterface.Count
        //                                 + new_line);
        //             int num3 = 0;
        //             foreach (var node3 in node2.callInterface)
        //                 textBox.AppendText(num + "--" + "--" + (num3++) + "--" + node3 + new_line);
        //         }
        //         num++;
        //     }
        //     num = 0;
        //     foreach (var node in root.messages)
        //     {
        //         textBox.AppendText(num + "--messageName：" + node.messageName
        //                             + "--parameterNumber：" + node.parameterNumber
        //                             + "--messageContent：" + node.messageContent
        //                             + new_line);
        //         num++;
        //     }
        // }

        // //根据评估结果显示相关信息
        // public void RefreshTextBoxAssessResult(TextBox textBox, Model model, DataHandle.JSONDataStruct.Root root)
        // {
        //     string new_line = GlobalData.GlobalData.globalData.newline;
        //     textBox.AppendText("第一层节点：" + new_line);
        //     foreach (var node1 in model.level1_nodes)
        //     {
        //         textBox.AppendText("节点名称：" + node1.NodeName + new_line
        //                             + "节点详细：" + node1.NodeName_Detail + new_line
        //                             + "节点层级：" + node1.NodeLevel + new_line
        //                             + "层级名称：" + node1.NodeLevelName + new_line
        //                             + "节点权值：" + node1.weight + new_line
        //                             + "是否增益：" + node1.gain_or_damage + new_line
        //                             + "值：" + node1.value + new_line);
        //     }
        //     textBox.AppendText(new_line + "第二层节点：" + new_line);
        //     foreach (var node2 in model.level2_nodes)
        //     {
        //         textBox.AppendText("节点名称：" + node2.NodeName + new_line
        //                             + "节点详细：" + node2.NodeName_Detail + new_line
        //                             + "节点层级：" + node2.NodeLevel + new_line
        //                             + "层级名称：" + node2.NodeLevelName + new_line
        //                             + "节点权值：" + node2.weight + new_line
        //                             + "是否增益：" + node2.gain_or_damage + new_line
        //                             + "值：" + node2.value + new_line);
        //     }
        //     textBox.AppendText(new_line + "第三层节点：" + new_line);
        //     foreach (var node3 in model.level3_nodes)
        //     {
        //         textBox.AppendText("节点名称：" + node3.NodeName + new_line
        //                             + "节点详细：" + node3.NodeName_Detail + new_line
        //                             + "节点层级：" + node3.NodeLevel + new_line
        //                             + "层级名称：" + node3.NodeLevelName + new_line
        //                             + "节点权值：" + node3.weight + new_line
        //                             + "是否增益：" + node3.gain_or_damage + new_line
        //                             + "值：" + node3.value + new_line);
        //     }
        //     textBox.AppendText(new_line + "第四层节点：" + new_line);
        //     foreach (var node4 in model.level4_nodes)
        //     {
        //         textBox.AppendText("节点名称：" + node4.NodeName + new_line
        //                             + "节点详细：" + node4.NodeName_Detail + new_line
        //                             + "节点层级：" + node4.NodeLevel + new_line
        //                             + "层级名称：" + node4.NodeLevelName + new_line
        //                             + "节点权值：" + node4.weight + new_line
        //                             + "是否增益：" + node4.gain_or_damage + new_line
        //                             + "值：" + node4.value + new_line);
        //     }

        //     // 输出每一个Metric的数值            
        //     textBox.AppendText(new_line + "DIC：" + new_line);
        //     foreach (var node in model.modelValue.Dic_NO_ServiceName)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     foreach (var node in model.modelValue.Dic_ServiceName_NO)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     foreach (var node in model.modelValue.Dic_NO_MessageName)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     foreach (var node in model.modelValue.Dic_MessageName_NO)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText(new_line + "Metric数值：" + new_line);
        //     textBox.AppendText("NS：" + model.modelValue.NS + new_line
        //                         + "NM：" + model.modelValue.NM + new_line);
        //     textBox.AppendText("NDCS：" + new_line);
        //     foreach (var node in model.modelValue.NDCS_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("NDCS总数：" + model.modelValue.NDCS_TOTAL + new_line + new_line);

        //     textBox.AppendText("NIS：" + new_line);
        //     foreach (var node in model.modelValue.NIS_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("NIS总数：" + model.modelValue.NIS_TOTAL + new_line + new_line);

        //     textBox.AppendText("NPI：" + new_line);
        //     foreach (var node in model.modelValue.NPI_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("NPI总数：" + model.modelValue.NPI_TOTAL + new_line + new_line);

        //     textBox.AppendText("NII：" + new_line);
        //     foreach (var node in model.modelValue.NII_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("NII总数：" + model.modelValue.NII_TOTAL + new_line + new_line);

        //     textBox.AppendText("NMP：" + new_line);
        //     foreach (var node in model.modelValue.NMP_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("NMP总数：" + model.modelValue.NMP_TOTAL + new_line + new_line);

        //     textBox.AppendText("WISL：" + new_line);
        //     foreach (var node in model.modelValue.WISL_NO_VALUE)
        //         textBox.AppendText(node.Key + "--" + node.Value + new_line);
        //     textBox.AppendText("WISL总数：" + model.modelValue.WISL_TOTAL + new_line + new_line);
        // }

        // refresh textBox of input file
        public void RefreshDataInputTextBox(DataHandle.JSONDataStruct.Root root, TextBox textBox)
        {
            // clear text box
            textBox.Clear();
            // output summary
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
                                    + "parameterNumber-" + (num++) + ": " + node.parameterNumber + newline);
            }
            // position the cursor
            textBox.Select(0, 0);
            textBox.ScrollToCaret();
        }

        // refresh comboBox options
        public void RefreshComboBox(ComboBox box, string text, object[] items)
        {
            box.Items.Clear();
            box.Text = text;
            box.Items.AddRange(items);
        }

        // refresh Model Weight Level3's Label and textBox
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

        // refresh Model Weight Level2's textBox
        public void RefreshModelWeightLevel2TextBox(Model model, TextBox box1, TextBox box2, TextBox box3, TextBox box4)
        {
            box1.Text = model.level2_nodes[0].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box2.Text = model.level2_nodes[1].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box3.Text = model.level2_nodes[2].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            box4.Text = model.level2_nodes[3].weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
        }

        // refresh Model Weight's Property-Analyzability
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

        // refresh Model Weight's Property-Changeability
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

        // refresh Model Weight's Property-Stability
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

        // refresh Model Weight's Property-Modularity
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

        // set Assessment Result ListView Column
        public void SetAssessmentResultListViewColumn(ListView lv)
        {
            lv.BeginUpdate();
            lv.Clear();
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN1_STRING, GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN1_WIDTH, HorizontalAlignment.Left);
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN2_STRING, GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN2_WIDTH, HorizontalAlignment.Left);
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN3_STRING, GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN3_WIDTH, HorizontalAlignment.Left);
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN4_STRING, GlobalData.GlobalData.LISTVIEW_ASSESSMENTRESULT_COLUMN4_WIDTH, HorizontalAlignment.Left);
            lv.EndUpdate();
        }

        // refresh Assessment Result ListView Data
        public void RefreshAssessmentResultListViewData(ListView lv, Model model, string levelname)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            switch (levelname)
            {
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE1:
                    for (int i = 0; i < ModelLink.LEVEL1_TOTAL_NUM; i++)
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = "" + (i + 1);
                        it.SubItems.Add("" + model.level1_nodes[i].NodeLevel);
                        it.SubItems.Add(model.level1_nodes[i].NodeName);
                        it.SubItems.Add(model.level1_nodes[i].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT));
                        lv.Items.Add(it);
                    }
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE2:
                    for (int i = 0; i < ModelLink.LEVEL2_TOTAL_NUM; i++)
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = "" + (i + 1);
                        it.SubItems.Add("" + model.level2_nodes[i].NodeLevel);
                        it.SubItems.Add(model.level2_nodes[i].NodeName);
                        it.SubItems.Add(model.level2_nodes[i].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT));
                        lv.Items.Add(it);
                    }
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE3:
                    for (int i = 0; i < ModelLink.LEVEL3_TOTAL_NUM; i++)
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = "" + (i + 1);
                        it.SubItems.Add("" + model.level3_nodes[i].NodeLevel);
                        it.SubItems.Add(model.level3_nodes[i].NodeName);
                        it.SubItems.Add(model.level3_nodes[i].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT));
                        lv.Items.Add(it);
                    }
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE4:
                    for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM; i++)
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = "" + (i + 1);
                        it.SubItems.Add("" + model.level4_nodes[i].NodeLevel);
                        it.SubItems.Add(model.level4_nodes[i].NodeName);
                        it.SubItems.Add(model.level4_nodes[i].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT));
                        lv.Items.Add(it);
                    }
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE:
                    break;
            }
            lv.EndUpdate();
        }

        // print node's detail info
        public void PrintNodeDetailInfo(TextBox box, ModelNode node)
        {
            string new_line = GlobalData.GlobalData.globalData.newline;
            box.AppendText("NodeName: " + node.NodeName + new_line);
            // print node's NodeName Detail
            box.AppendText("NodeName Detail: ");
            if (node.NodeName_Detail.Equals(""))
                box.AppendText("No Detail" + new_line);
            else
                box.AppendText(node.NodeName_Detail + new_line);
            box.AppendText("NodeLevel: " + node.NodeLevel + new_line
                            + "NextLevelNodes: ");
            // node's nextlevel nodes names
            bool if_print_first = true;
            foreach (var node2 in node.nextlevel)
            {
                if (if_print_first)
                {
                    box.AppendText(node2.NodeName);
                    if_print_first = false;
                }
                else
                    box.AppendText(", " + node2.NodeName);
            }
            // print node's fathernode's nodename
            if (node.prelevel == null)
                box.AppendText(new_line + "FatherNode: " + new_line);
            else
                box.AppendText(new_line + "FatherNode: " + node.prelevel.NodeName + new_line);
            // print node's weight
            box.AppendText("Weight: " + node.weight.ToString(GlobalData.GlobalData.DECIMAL_FORMAT) + new_line);
            // print node's value
            box.AppendText("Value: " + node.value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT) + new_line);
            // print node's gain_or_damage
            box.AppendText("Gain Or Damage: ");
            if (node.gain_or_damage == ModelWeight.NODE_AFFECT_GAIN)
                box.AppendText("Gain");
            else if (node.gain_or_damage == ModelWeight.NODE_AFFECT_DAMAGE)
                box.AppendText("Damage");
            else
                box.AppendText("Unknown");
            box.Select(0, 0);
            box.ScrollToCaret();
        }

        // refresh the Assessment Result textBox Content
        public void RefreshAssessmentResultTextBoxContent(TextBox box, Model model, string level, string choice)
        {
            // clear all the text in textBox
            box.Clear();
            int choice_num = int.Parse(choice) - 1;
            switch (level)
            {
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE1:
                    PrintNodeDetailInfo(box, model.level1_nodes[choice_num]);
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE2:
                    PrintNodeDetailInfo(box, model.level2_nodes[choice_num]);
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE3:
                    PrintNodeDetailInfo(box, model.level3_nodes[choice_num]);
                    break;
                case GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE4:
                    PrintNodeDetailInfo(box, model.level4_nodes[choice_num]);
                    break;
            }
        }

        // set Assessment Result ListView Column
        public void SetHistoryListViewColumn(ListView lv)
        {
            lv.BeginUpdate();
            lv.Clear();
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN1_STRING, GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN1_WIDTH, HorizontalAlignment.Left);
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN2_STRING, GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN2_WIDTH, HorizontalAlignment.Left);
            lv.Columns.Add(GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN3_STRING, GlobalData.GlobalData.LISTVIEW_HISTORY_COLUMN3_WIDTH, HorizontalAlignment.Left);
            lv.EndUpdate();
        }

        // refresh History ListView Data
        public void RefreshHistoryListViewData(ListView lv, DataHandle.JSONHistoryDataStruct.Root root)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            int no = 1;
            foreach (var node in root.HistoryData)
            {
                ListViewItem it = new ListViewItem();
                it.Text = "" + (no++);
                it.SubItems.Add(node.AssessTime);
                it.SubItems.Add(node.ResultValue);
                lv.Items.Add(it);
            }
            lv.EndUpdate();
        }
    }
}
