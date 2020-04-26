using Microsoft.Win32.SafeHandles;
using NET_Framwork48.DataHandle;
using NET_Framwork48.GlobalData;
using NET_Framwork48.Models;
using NET_Framwork48.UIDesign;
using Newtonsoft.Json;
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
            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_INFOTEXT;
            global.open_file_path = "";
            global.if_open_data = false;
            global.assessment_result_last_choose_level = "null";
            global.assessment_result_last_choose_num = "null";

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
            //init ouput textBox
            textBox_DataInput_FileInfo.Text = "";
            textBox_AssessmentResult_NodeInfoDetail.Text = "";
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

            //init Model_Weight_Level2_textBox
            global.model = new Model();
            Model model = global.model;
            model.CreateModel();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model,  textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                            textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                            textBox_ModelWeight_Level2_StabilityWeight,
                                                            textBox_ModelWeight_Level2_ModularityWeight);
            //init Assessment Result ListView Column
            refresh.SetAssessmentResultListViewColumn(listView_AssessmentResult_NodeInfo);

            //init History ListView Column
            refresh.SetHistoryListViewColumn(listView_History_HistoryInfo);
            //refresh History ListView Data
            ReadAndShowHistoryJSONData();
        }

        //read history json file data and show in the ListView
        private void ReadAndShowHistoryJSONData()
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            if (File.Exists(GlobalData.GlobalData.History_FILE_PATH))
            {
                DataInputOutput dataInput = new DataInputOutput();
                string history_file_content = dataInput.InputDataFromFile(GlobalData.GlobalData.History_FILE_PATH);
                JSONDecoder jsonDecoder = new JSONDecoder();
                global.history_root = jsonDecoder.GetHistoryJSONDataObject(history_file_content);
                new UIRefresh().RefreshHistoryListViewData(listView_History_HistoryInfo, global.history_root);
            }
            else
                global.history_root = null;
        }

        private void button_DataInput_Input_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            if (global.if_open_data)
            {
                MessageBox.Show(GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT1 + GlobalData.GlobalData.globalData.newline + GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT2, GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_CAPTION);
                return;
            }
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
                global.if_open_data = true;
                //设置打开的文件路径
                global.open_file_path = open_file.FileName;
                //设置ui界面的提示信息
                label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_INPUTNEWFILE;

                //解析文件内容
                DataInputOutput dataInputOutput = new DataInputOutput();
                string file_content = dataInputOutput.InputDataFromFile(global.open_file_path);
                JSONDecoder jsonDecoder = new JSONDecoder();
                global.new_root = jsonDecoder.GetNewJSONDataObject(file_content);

                //将文件的概要输出
                refresh.RefreshDataInputTextBox(global.new_root, textBox_DataInput_FileInfo);

                //提取json文件数据
                DataAnalyze dataAnalyze = new DataAnalyze(global.new_root, global.model.modelValue);
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

                //write the new json file to history data
                //case 1: history root entity not null
                if (global.history_root != null)
                {
                    string now_time_string= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    global.history_root.LastAssessTime = now_time_string;
                    global.history_root.CommitTimeHistory.Add(now_time_string);
                    DataHandle.JSONHistoryDataStruct.HistoryData history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.HistoryData();
                    history_add_new_historydata.AssessTime = now_time_string;
                    history_add_new_historydata.ResultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                    history_add_new_historydata.JSONContent= JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.JSONContent>(JsonConvert.SerializeObject(global.new_root));
                    global.history_root.HistoryData.Add(history_add_new_historydata);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root,Formatting.Indented));
                }
                //case 2: history root is null
                else
                {
                    string now_time_string = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    global.history_root = new DataHandle.JSONHistoryDataStruct.Root();
                    global.history_root.CommitTimeHistory = new List<string>();
                    global.history_root.HistoryData = new List<DataHandle.JSONHistoryDataStruct.HistoryData>();
                    global.history_root.LastAssessTime = now_time_string;
                    global.history_root.CommitTimeHistory.Add(now_time_string);
                    DataHandle.JSONHistoryDataStruct.HistoryData history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.HistoryData();
                    history_add_new_historydata.AssessTime = now_time_string;
                    history_add_new_historydata.ResultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                    history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.JSONContent>(JsonConvert.SerializeObject(global.new_root));
                    global.history_root.HistoryData.Add(history_add_new_historydata);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root,Formatting.Indented));
                }

                //refresh History ListView Data
                ReadAndShowHistoryJSONData();
            }
        }

        private void button_DataInput_Reset_Click(object sender, EventArgs e)
        {
            InitAllUI();
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
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            Model model = global.model;
            UIRefresh refresh = new UIRefresh();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model,  textBox_ModelWeight_Level2_AnalyzabilityWeight,
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

            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_DEFAULTSETTINGS;

            //check if open json data
            if (!global.if_open_data)
                return;
            //re-calculate model value
            global.model.CalculateModelValue();
            //show new value in Assessment Result ListView
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
            //refresh Assessment Result textBox
            if (!global.assessment_result_last_choose_num.Equals("null"))
                //print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, global.model, global.assessment_result_last_choose_level, global.assessment_result_last_choose_num);
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
            //Convert Level 3 Values
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

            //check if open json data
            if (!global.if_open_data)
                return;
            //re-calculate model value
            global.model.CalculateModelValue();
            //show new value in Assessment Result ListView
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
            //refresh Assessment Result textBox
            if (!global.assessment_result_last_choose_num.Equals("null"))
                //print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, global.model, global.assessment_result_last_choose_level, global.assessment_result_last_choose_num);
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
                //record the last choose
                GlobalData.GlobalData.globalData.assessment_result_last_choose_level = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                GlobalData.GlobalData.globalData.assessment_result_last_choose_num = listView_AssessmentResult_NodeInfo.SelectedItems[0].Text;
                //print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, GlobalData.GlobalData.globalData.model, comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString(), listView_AssessmentResult_NodeInfo.SelectedItems[0].Text);
            }
            //else ListView has no choose
        }

        private void button_History_ClearAll_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            global.history_root = new DataHandle.JSONHistoryDataStruct.Root();
            global.history_root.LastAssessTime = "";
            global.history_root.CommitTimeHistory = new List<string>();
            global.history_root.HistoryData = new List<DataHandle.JSONHistoryDataStruct.HistoryData>();
            DataInputOutput dataInputOutput = new DataInputOutput();
            dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented));
            ReadAndShowHistoryJSONData();
        }

        private void button_History_Details_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            if (global.if_open_data)
            {
                MessageBox.Show(GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT1 + GlobalData.GlobalData.globalData.newline + GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT2, GlobalData.GlobalData.MESSAGEBOX_ERROR_OPEN_JSON_FILE_CAPTION);
                return;
            }
            if (listView_History_HistoryInfo.SelectedItems.Count > 0)
            {
                global.if_open_data = true;

                int choose_num = int.Parse(listView_History_HistoryInfo.SelectedItems[0].Text) - 1;
                UIRefresh refresh = new UIRefresh();
                //设置ui界面的提示信息
                label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_HISTORYDATA;
                //解析文件内容
                DataInputOutput dataInputOutput = new DataInputOutput();
                global.new_root = JsonConvert.DeserializeObject<DataHandle.JSONDataStruct.Root>(JsonConvert.SerializeObject(global.history_root.HistoryData[choose_num].JSONContent));
                //将文件的概要输出
                refresh.RefreshDataInputTextBox(global.new_root, textBox_DataInput_FileInfo);
                //提取json文件数据
                DataAnalyze dataAnalyze = new DataAnalyze(global.new_root, global.model.modelValue);
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

                //write the new json file to history data
                //case 1: history root entity not null
                if (global.history_root != null)
                {
                    string now_time_string = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    global.history_root.LastAssessTime = now_time_string;
                    global.history_root.CommitTimeHistory.Add(now_time_string);
                    DataHandle.JSONHistoryDataStruct.HistoryData history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.HistoryData();
                    history_add_new_historydata.AssessTime = now_time_string;
                    history_add_new_historydata.ResultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                    history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.JSONContent>(JsonConvert.SerializeObject(global.new_root));
                    global.history_root.HistoryData.Add(history_add_new_historydata);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented));
                }
                //case 2: history root is null
                else
                {
                    string now_time_string = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    global.history_root = new DataHandle.JSONHistoryDataStruct.Root();
                    global.history_root.CommitTimeHistory = new List<string>();
                    global.history_root.HistoryData = new List<DataHandle.JSONHistoryDataStruct.HistoryData>();
                    global.history_root.LastAssessTime = now_time_string;
                    global.history_root.CommitTimeHistory.Add(now_time_string);
                    DataHandle.JSONHistoryDataStruct.HistoryData history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.HistoryData();
                    history_add_new_historydata.AssessTime = now_time_string;
                    history_add_new_historydata.ResultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                    history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.JSONContent>(JsonConvert.SerializeObject(global.new_root));
                    global.history_root.HistoryData.Add(history_add_new_historydata);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented));
                }

                //refresh History ListView Data
                ReadAndShowHistoryJSONData();
            }
        }
    }
}
