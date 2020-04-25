using Microsoft.Win32.SafeHandles;
using NET_Framwork48.DataHandle;
using NET_Framwork48.GlobalData;
using NET_Framwork48.Models;
using NET_Framwork48.UIDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_Framwork48
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitAllUI();
        }

        //init all the component in UI Design System
        private void InitAllUI()
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            UIRefresh refresh = new UIRefresh();
            refresh.SetLabelValue(label_DataInput_InfoText, GlobalData.GlobalData.LABEL_DATAINPUT_INFOTEXT);
            global.open_file_path = "";

            //comboBox Init
            refresh.RefreshComboBox(comboBox_ModelWeight_Level3_AttributeChoose,
                                    GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_TEXT,
                                    new object[] {
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4
                                    });
            refresh.RefreshComboBox(comboBox_AssessmentResult_LevelChoose,
                                    GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_TEXT,
                                    new object[] {
                                        GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE1,
                                        GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE2,
                                        GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE3,
                                        GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE4
                                    });
            //Label and textBox Init
            refresh.RefreshModelWeightLevel3LabelAndTextBox(    label_ModelWeight_Level3_Property1,
                                                                label_ModelWeight_Level3_Property2,
                                                                label_ModelWeight_Level3_Property3,
                                                                label_ModelWeight_Level3_Property4,
                                                                label_ModelWeight_Level3_Property5,
                                                                textBox_ModelWeight_Level3_Property1Weight,
                                                                textBox_ModelWeight_Level3_Property2Weight,
                                                                textBox_ModelWeight_Level3_Property3Weight,
                                                                textBox_ModelWeight_Level3_Property4Weight,
                                                                textBox_ModelWeight_Level3_Property5Weight);

            //Init Model_Weight_Level2_textBox
            global.model = new Model();
            Model model = global.model;
            model.CreateModel();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model,  textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                            textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                            textBox_ModelWeight_Level2_StabilityWeight,
                                                            textBox_ModelWeight_Level2_ModularityWeight);
            //Init Assessment Result ListView Column
            refresh.SetAssessmentResultListViewColumn(listView_AssessmentResult_NodeInfo);
        }

        private void button_DataInput_Input_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "Choose the JSON File";
            open_file.RestoreDirectory = false;
            open_file.Filter = "JSON File(*.json)|*.json";
            open_file.FilterIndex = 0;
            open_file.Multiselect = false;
            UIRefresh refresh = new UIRefresh();
            //选择文件
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                //设置打开的文件路径
                global.open_file_path = open_file.FileName;
                //设置ui界面的提示信息
                refresh.SetLabelValue(label_DataInput_InfoText, "");

                //解析文件内容
                DataInput dataInput = new DataInput();
                string file_content = dataInput.InputDataFromFile(global.open_file_path);
                JSONDecoder jsonDecoder = new JSONDecoder();
                global.root = jsonDecoder.GetJSONObject(file_content);

                //将文件的概要输出
                refresh.RefreshDataInputTextBox(global.root, textBox_DataInput_FileInfo);

                //提取json文件数据
                DataAnalyze dataAnalyze = new DataAnalyze(global.root, global.model.modelValue);
                dataAnalyze.SetMetrics();
                global.model.CalculateModelValue();

                //设置ListView的显示项目
                try
                {
                    string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
                }
                catch (Exception)
                {
                    //if the comboBox is not selected
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
                }
            }
        }

        private void comboBox_ModelWeight_Level3_AttributeChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIRefresh refresh = new UIRefresh();
            switch (comboBox_ModelWeight_Level3_AttributeChoose.SelectedItem)
            {
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1:
                    refresh.RefreshModelWeightPropertyAnalyzability(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2:
                    refresh.RefreshModelWeightPropertyChangeability(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3:
                    refresh.RefreshModelWeightPropertyStability(    GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4:
                    refresh.RefreshModelWeightPropertyModularity(   GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
            }
        }

        //Model Weight Button_DefaultSettings
        private void button_ModelWeight_DefaultSettings_Click(object sender, EventArgs e)
        {
            Model model = GlobalData.GlobalData.globalData.model;
            UIRefresh refresh = new UIRefresh();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model,  textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                            textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                            textBox_ModelWeight_Level2_StabilityWeight,
                                                            textBox_ModelWeight_Level2_ModularityWeight);
            //comboBox Init
            refresh.RefreshComboBox(comboBox_ModelWeight_Level3_AttributeChoose,
                                    GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_TEXT,
                                    new object[] {
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4
                                    });
            refresh.RefreshComboBox(comboBox_AssessmentResult_LevelChoose,
                                    GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_TEXT,
                                    new object[] {
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4
                                    });
            //Label and textBox Init
            refresh.RefreshModelWeightLevel3LabelAndTextBox(    label_ModelWeight_Level3_Property1,
                                                                label_ModelWeight_Level3_Property2,
                                                                label_ModelWeight_Level3_Property3,
                                                                label_ModelWeight_Level3_Property4,
                                                                label_ModelWeight_Level3_Property5,
                                                                textBox_ModelWeight_Level3_Property1Weight,
                                                                textBox_ModelWeight_Level3_Property2Weight,
                                                                textBox_ModelWeight_Level3_Property3Weight,
                                                                textBox_ModelWeight_Level3_Property4Weight,
                                                                textBox_ModelWeight_Level3_Property5Weight);
            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_DEFAULTSETTINGS;
        }

        //Check Convert String To Decimal If Success
        private bool check_Convert_StringToDecimal_Success()
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_AnalyzabilityWeight.Text, out _))
                return false;
            if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ChangeabilityWeight.Text, out _))
                return false;
            if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_StabilityWeight.Text, out _))
                return false;
            if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ModularityWeight.Text, out _))
                return false;
            switch (comboBox_ModelWeight_Level3_AttributeChoose.SelectedItem)
            {
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1:
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property3Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property4Weight.Text, out _))
                        return false;
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2:
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property3Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property4Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property5Weight.Text, out _))
                        return false;
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3:
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out _))
                        return false;
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4:
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out _))
                        return false;
                    if (!global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out _))
                        return false;
                    break;
            }
            return true;
        }

        //Model Weight Button_SaveChanges
        private void button_ModelWeight_SaveChanges_Click(object sender, EventArgs e)
        {
            if (!check_Convert_StringToDecimal_Success())
            {
                label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_INVALIDVALUE;
                return;
            }

            Model model = GlobalData.GlobalData.globalData.model;
            decimal[] level2_value = new decimal[ModelLink.LEVEL2_TOTAL_NUM];
            decimal[] level3_value = new decimal[ModelLink.LEVEL3_TOTAL_NUM];
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            //Convert Level 2 Values
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_AnalyzabilityWeight.Text, out level2_value[0]);
            model.level2_nodes[0].weight = level2_value[0];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ChangeabilityWeight.Text, out level2_value[1]);
            model.level2_nodes[1].weight = level2_value[1];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_StabilityWeight.Text, out level2_value[2]);
            model.level2_nodes[2].weight = level2_value[2];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ModularityWeight.Text, out level2_value[3]);
            model.level2_nodes[3].weight = level2_value[3];
            //Conver Level 3 Values
            switch (comboBox_ModelWeight_Level3_AttributeChoose.SelectedItem)
            {
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1:
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out level3_value[0]);
                    model.level3_nodes[0].weight = level3_value[0];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out level3_value[1]);
                    model.level3_nodes[1].weight = level3_value[1];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property3Weight.Text, out level3_value[2]);
                    model.level3_nodes[2].weight = level3_value[2];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property4Weight.Text, out level3_value[3]);
                    model.level3_nodes[3].weight = level3_value[3];
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2:
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out level3_value[4]);
                    model.level3_nodes[4].weight = level3_value[4];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out level3_value[5]);
                    model.level3_nodes[5].weight = level3_value[5];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property3Weight.Text, out level3_value[6]);
                    model.level3_nodes[6].weight = level3_value[6];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property4Weight.Text, out level3_value[7]);
                    model.level3_nodes[7].weight = level3_value[7];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property5Weight.Text, out level3_value[8]);
                    model.level3_nodes[8].weight = level3_value[8];
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3:
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out level3_value[9]);
                    model.level3_nodes[9].weight = level3_value[9];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out level3_value[10]);
                    model.level3_nodes[10].weight = level3_value[10];
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4:
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property1Weight.Text, out level3_value[11]);
                    model.level3_nodes[11].weight = level3_value[11];
                    global.ConvertFromStringToDecimal(textBox_ModelWeight_Level3_Property2Weight.Text, out level3_value[12]);
                    model.level3_nodes[12].weight = level3_value[12];
                    break;
            }
            //Refresh textBox
            UIRefresh refresh = new UIRefresh();
            refresh.RefreshModelWeightLevel2TextBox(model, textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                    textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                    textBox_ModelWeight_Level2_StabilityWeight,
                                                    textBox_ModelWeight_Level2_ModularityWeight);
            switch (comboBox_ModelWeight_Level3_AttributeChoose.SelectedItem)
            {
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1:
                    refresh.RefreshModelWeightPropertyAnalyzability(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2:
                    refresh.RefreshModelWeightPropertyChangeability(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3:
                    refresh.RefreshModelWeightPropertyStability(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
                case GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4:
                    refresh.RefreshModelWeightPropertyModularity(GlobalData.GlobalData.globalData.model,
                                                                    label_ModelWeight_Level3_Property1,
                                                                    label_ModelWeight_Level3_Property2,
                                                                    label_ModelWeight_Level3_Property3,
                                                                    label_ModelWeight_Level3_Property4,
                                                                    label_ModelWeight_Level3_Property5,
                                                                    textBox_ModelWeight_Level3_Property1Weight,
                                                                    textBox_ModelWeight_Level3_Property2Weight,
                                                                    textBox_ModelWeight_Level3_Property3Weight,
                                                                    textBox_ModelWeight_Level3_Property4Weight,
                                                                    textBox_ModelWeight_Level3_Property5Weight);
                    break;
            }
            //Refresh label
            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_CHANGESUCCESS;
        }

        private void button_DataInput_Reset_Click(object sender, EventArgs e)
        {
            InitAllUI();
        }

        private void comboBox_AssessmentResult_LevelChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIRefresh refresh = new UIRefresh();
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            //设置ListView的显示项目
            try
            {
                string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
            }
            catch (Exception)
            {
                //if the comboBox is not selected
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
            }
        }

        private void listView_AssessmentResult_NodeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListView Item is chosed
            if (listView_AssessmentResult_NodeInfo.SelectedItems.Count>0)
            {
                //print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, GlobalData.GlobalData.globalData.model, comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString(), listView_AssessmentResult_NodeInfo.SelectedItems[0].Text);
            }
            //else ListView has no choose
        }
    }
}
