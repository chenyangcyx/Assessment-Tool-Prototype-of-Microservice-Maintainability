using NET_Framwork48.DataHandle;
using NET_Framwork48.Models;
using NET_Framwork48.UIDesign;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
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

        // initialize all the component in UI Design System
        private void InitAllUI()
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            UIRefresh refresh = new UIRefresh();
            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_INFOTEXT;
            global.open_file_path = "";
            global.if_open_data = false;
            global.assessment_result_last_choose_level = "null";
            global.assessment_result_last_choose_num = "null";

            // comboBox initialization
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
            // initialize ouput textBox
            textBox_DataInput_FileInfo.Text = "";
            textBox_AssessmentResult_NodeInfoDetail.Text = "";
            // Label and textBox initialization
            refresh.RefreshModelWeightLevel3LabelAndTextBox(label_ModelWeight_Level3_Property1,
                                                                label_ModelWeight_Level3_Property2,
                                                                label_ModelWeight_Level3_Property3,
                                                                label_ModelWeight_Level3_Property4,
                                                                label_ModelWeight_Level3_Property5,
                                                                textBox_ModelWeight_Level3_Property1Weight,
                                                                textBox_ModelWeight_Level3_Property2Weight,
                                                                textBox_ModelWeight_Level3_Property3Weight,
                                                                textBox_ModelWeight_Level3_Property4Weight,
                                                                textBox_ModelWeight_Level3_Property5Weight);

            // initialize Model_Weight_Level2_textBox
            global.model = new Model();
            Model model = global.model;
            model.CreateModel();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model, textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                            textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                            textBox_ModelWeight_Level2_StabilityWeight,
                                                            textBox_ModelWeight_Level2_ModularityWeight);
            // initialize Assessment Result ListView Column
            refresh.SetAssessmentResultListViewColumn(listView_AssessmentResult_NodeInfo);

            // initialize History ListView Column
            refresh.SetHistoryListViewColumn(listView_History_HistoryInfo);
            // refresh History ListView Data
            ReadAndShowHistoryJSONData();
        }

        // read history json file data and show in the ListView
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
            // choose a file
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                global.if_open_data = true;
                // set the open file path
                global.open_file_path = open_file.FileName;
                // set the prompt information of the UI interface
                label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_INPUTNEWFILE;

                // parsing file content
                DataInputOutput dataInputOutput = new DataInputOutput();
                string file_content = dataInputOutput.InputDataFromFile(global.open_file_path);
                JSONDecoder jsonDecoder = new JSONDecoder();
                global.new_root = jsonDecoder.GetNewJSONDataObject(file_content);

                // output summary of file
                refresh.RefreshDataInputTextBox(global.new_root, textBox_DataInput_FileInfo);

                // extract json file data
                DataAnalyze dataAnalyze = new DataAnalyze(global.new_root, global.model.modelValue);
                dataAnalyze.SetMetrics();
                global.model.CalculateModelValue();

                // set ListView display items
                try
                {
                    string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
                }
                catch (Exception)
                {
                    // if the comboBox is not selected
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
                }

                // write the new json file to history data
                // case 1: history root entity not null
                if (global.history_root != null)
                {
                    AddNewJsonDataToHistoryRoot(true);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
                }
                // case 2: history root is null
                else
                {
                    AddNewJsonDataToHistoryRoot(false);
                    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
                }
                // refresh History ListView Data
                ReadAndShowHistoryJSONData();
            }
        }

        private void AddNewJsonDataToHistoryRoot(bool if_exist)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;

            string now_time_string = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            if (!if_exist)
            {
                global.history_root = new DataHandle.JSONHistoryDataStruct.Rootobject();
                global.history_root.commitTimeHistory = new List<string>();
                global.history_root.historyData = new List<DataHandle.JSONHistoryDataStruct.Historydata>();
            }
            global.history_root.lastAssessTime = now_time_string;
            global.history_root.commitTimeHistory.Add(now_time_string);
            DataHandle.JSONHistoryDataStruct.Historydata history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.Historydata();
            history_add_new_historydata.assessTime = now_time_string;
            history_add_new_historydata.resultValue = new DataHandle.JSONHistoryDataStruct.Resultvalue();
            history_add_new_historydata.resultValue.Level1 = new DataHandle.JSONHistoryDataStruct.Level1();
            history_add_new_historydata.resultValue.Level1.Maintainability = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.resultValue.Level2 = new DataHandle.JSONHistoryDataStruct.Level2();
            history_add_new_historydata.resultValue.Level2.Analyzability = global.model.level2_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.resultValue.Level2.Changeability = global.model.level2_nodes[1].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.resultValue.Level2.Stability = global.model.level2_nodes[2].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.resultValue.Level2.Modularity = global.model.level2_nodes[3].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            DataHandle.JSONHistoryDataStruct.Level3 level3_1 = new DataHandle.JSONHistoryDataStruct.Level3();
            DataHandle.JSONHistoryDataStruct.Level3 level3_2 = new DataHandle.JSONHistoryDataStruct.Level3();
            DataHandle.JSONHistoryDataStruct.Level3 level3_3 = new DataHandle.JSONHistoryDataStruct.Level3();
            DataHandle.JSONHistoryDataStruct.Level3 level3_4 = new DataHandle.JSONHistoryDataStruct.Level3();
            level3_1.Coupling = global.model.level3_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_1.Cohesion = global.model.level3_nodes[1].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_1.DesignComplexity = global.model.level3_nodes[2].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_1.SystemSize = global.model.level3_nodes[3].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_2.Coupling = global.model.level3_nodes[4].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_2.Cohesion = global.model.level3_nodes[5].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_2.ServiceGranularity = global.model.level3_nodes[6].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_2.ParameterGranularity = global.model.level3_nodes[7].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_2.ServiceLoopback = global.model.level3_nodes[8].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_3.ParameterGranularity = global.model.level3_nodes[9].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_3.ServiceLoopback = global.model.level3_nodes[10].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_4.Cohesion = global.model.level3_nodes[11].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            level3_4.ServiceGranularity = global.model.level3_nodes[12].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.resultValue.Level3 = new List<DataHandle.JSONHistoryDataStruct.Level3>();
            history_add_new_historydata.resultValue.Level3.Add(level3_1);
            history_add_new_historydata.resultValue.Level3.Add(level3_2);
            history_add_new_historydata.resultValue.Level3.Add(level3_3);
            history_add_new_historydata.resultValue.Level3.Add(level3_4);
            history_add_new_historydata.metricDetail = new DataHandle.JSONHistoryDataStruct.Metricdetail();
            history_add_new_historydata.metricDetail.ServiceName = new List<string>();
            history_add_new_historydata.metricDetail.MessageName = new List<string>();
            history_add_new_historydata.metricDetail.NDCS = new List<string>();
            history_add_new_historydata.metricDetail.NIS = new List<string>();
            history_add_new_historydata.metricDetail.NPI = new List<string>();
            history_add_new_historydata.metricDetail.NII = new List<string>();
            history_add_new_historydata.metricDetail.NMP = new List<string>();
            history_add_new_historydata.metricDetail.WISL = new List<string>();
            history_add_new_historydata.metricDetail.connectionRelationship = new List<string>();
            history_add_new_historydata.metricDetail.callRelationship = new List<string>();
            foreach (var node in global.model.modelValue.Dic_NO_ServiceName)
                history_add_new_historydata.metricDetail.ServiceName.Add(node.Key + " -- " + node.Value);
            foreach (var node in global.model.modelValue.Dic_NO_MessageName)
                history_add_new_historydata.metricDetail.MessageName.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NS = global.model.modelValue.NS.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.NDCS_NO_VALUE)
                history_add_new_historydata.metricDetail.NDCS.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NDCS_TOTAL = global.model.modelValue.NDCS_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            history_add_new_historydata.metricDetail.NM = global.model.modelValue.NM.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.NIS_NO_VALUE)
                history_add_new_historydata.metricDetail.NIS.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NIS_TOTAL = global.model.modelValue.NIS_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.NPI_NO_VALUE)
                history_add_new_historydata.metricDetail.NPI.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NPI_TOTAL = global.model.modelValue.NPI_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.NII_NO_VALUE)
                history_add_new_historydata.metricDetail.NII.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NII_TOTAL = global.model.modelValue.NII_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.NMP_NO_VALUE)
                history_add_new_historydata.metricDetail.NMP.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.NMP_TOTAL = global.model.modelValue.NMP_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            foreach (var node in global.model.modelValue.WISL_NO_VALUE)
                history_add_new_historydata.metricDetail.WISL.Add(node.Key + " -- " + node.Value);
            history_add_new_historydata.metricDetail.WISL_TOTAL = global.model.modelValue.WISL_TOTAL.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
            // connection relationship
            history_add_new_historydata.metricDetail.connectionRelationship = global.model.modelValue.connectionRelationship;
            // call relationship
            history_add_new_historydata.metricDetail.callRelationship = global.model.modelValue.callRelationship;

            history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.Jsoncontent>(JsonConvert.SerializeObject(global.new_root));
            global.history_root.historyData.Add(history_add_new_historydata);
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
        }

        // Model Weight Button_DefaultSettings
        private void button_ModelWeight_DefaultSettings_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            Model model = global.model;
            UIRefresh refresh = new UIRefresh();
            model.CalculateModelWeight();
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

            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_DEFAULTSETTINGS;

            // check if open json data
            if (!global.if_open_data)
                return;
            // re-calculate model value
            global.model.CalculateModelValue();
            // show new value in Assessment Result ListView
            try
            {
                string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
            }
            catch (Exception)
            {
                // if the comboBox is not selected
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
            }
            // refresh Assessment Result textBox
            if (!global.assessment_result_last_choose_num.Equals("null"))
                // print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, global.model, global.assessment_result_last_choose_level, global.assessment_result_last_choose_num);
        }

        // Check Convert String To Decimal If Success
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

        // Model Weight Button_SaveChanges
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
            // Convert Level 2 Values
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_AnalyzabilityWeight.Text, out level2_value[0]);
            model.level2_nodes[0].weight = level2_value[0];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ChangeabilityWeight.Text, out level2_value[1]);
            model.level2_nodes[1].weight = level2_value[1];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_StabilityWeight.Text, out level2_value[2]);
            model.level2_nodes[2].weight = level2_value[2];
            global.ConvertFromStringToDecimal(textBox_ModelWeight_Level2_ModularityWeight.Text, out level2_value[3]);
            model.level2_nodes[3].weight = level2_value[3];
            // Convert Level 3 Values
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
            // refresh textBox
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
            // refresh label
            label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_CHANGESUCCESS;

            // check if open json data
            if (!global.if_open_data)
                return;
            // re-calculate model value
            global.model.CalculateModelValue();
            // show new value in Assessment Result ListView
            try
            {
                string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
            }
            catch (Exception)
            {
                // if the comboBox is not selected
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
            }
            // refresh Assessment Result textBox
            if (!global.assessment_result_last_choose_num.Equals("null"))
                // print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, global.model, global.assessment_result_last_choose_level, global.assessment_result_last_choose_num);
        }

        private void comboBox_AssessmentResult_LevelChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIRefresh refresh = new UIRefresh();
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            // set ListView display items
            try
            {
                string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
            }
            catch (Exception)
            {
                // if the comboBox is not selected
                refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
            }
        }

        private void listView_AssessmentResult_NodeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListView Item is chosed
            if (listView_AssessmentResult_NodeInfo.SelectedItems.Count > 0)
            {
                // record the last choose
                GlobalData.GlobalData.globalData.assessment_result_last_choose_level = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                GlobalData.GlobalData.globalData.assessment_result_last_choose_num = listView_AssessmentResult_NodeInfo.SelectedItems[0].Text;
                // print the detail info
                new UIRefresh().RefreshAssessmentResultTextBoxContent(textBox_AssessmentResult_NodeInfoDetail, GlobalData.GlobalData.globalData.model, comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString(), listView_AssessmentResult_NodeInfo.SelectedItems[0].Text);
            }
            // else ListView has no choose
        }

        private void button_History_ClearAll_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            global.history_root = new DataHandle.JSONHistoryDataStruct.Rootobject();
            global.history_root.lastAssessTime = "";
            global.history_root.commitTimeHistory = new List<string>();
            global.history_root.historyData = new List<DataHandle.JSONHistoryDataStruct.Historydata>();
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
                // set the prompt information of the UI interface
                label_DataInput_InfoText.Text = GlobalData.GlobalData.LABEL_DATAINPUT_HISTORYDATA;
                // parsing file content
                DataInputOutput dataInputOutput = new DataInputOutput();
                global.new_root = JsonConvert.DeserializeObject<DataHandle.JSONDataStruct.Rootobject>(JsonConvert.SerializeObject(global.history_root.historyData[choose_num].JSONContent));
                // output summary of file
                refresh.RefreshDataInputTextBox(global.new_root, textBox_DataInput_FileInfo);
                // extract json file data
                DataAnalyze dataAnalyze = new DataAnalyze(global.new_root, global.model.modelValue);
                dataAnalyze.SetMetrics();
                global.model.CalculateModelValue();

                // set ListView display items
                try
                {
                    string comboBox_AssessmentResult_LevelChoose_string = comboBox_AssessmentResult_LevelChoose.SelectedItem.ToString();
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, comboBox_AssessmentResult_LevelChoose_string);
                }
                catch (Exception)
                {
                    // if the comboBox is not selected
                    refresh.RefreshAssessmentResultListViewData(listView_AssessmentResult_NodeInfo, global.model, GlobalData.GlobalData.COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE);
                }

                // write the new json file to history data
                // case 1: history root entity not null
                //if (global.history_root != null)
                //{
                //    string now_time_string = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                //    global.history_root.lastAssessTime = now_time_string;
                //    global.history_root.commitTimeHistory.Add(now_time_string);
                //    DataHandle.JSONHistoryDataStruct.Historydata history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.Historydata();
                //    history_add_new_historydata.assessTime = now_time_string;
                //    history_add_new_historydata.resultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                //    history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.Jsoncontent>(JsonConvert.SerializeObject(global.new_root));
                //    global.history_root.historyData.Add(history_add_new_historydata);
                //    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented));
                //}
                //// case 2: history root is null
                //else
                //{
                //    string now_time_string = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                //    global.history_root = new DataHandle.JSONHistoryDataStruct.Rootobject();
                //    global.history_root.commitTimeHistory = new List<string>();
                //    global.history_root.historyData = new List<DataHandle.JSONHistoryDataStruct.Historydata>();
                //    global.history_root.lastAssessTime = now_time_string;
                //    global.history_root.commitTimeHistory.Add(now_time_string);
                //    DataHandle.JSONHistoryDataStruct.Historydata history_add_new_historydata = new DataHandle.JSONHistoryDataStruct.Historydata();
                //    history_add_new_historydata.assessTime = now_time_string;
                //    history_add_new_historydata.resultValue = global.model.level1_nodes[0].value.ToString(GlobalData.GlobalData.DECIMAL_FORMAT);
                //    history_add_new_historydata.JSONContent = JsonConvert.DeserializeObject<DataHandle.JSONHistoryDataStruct.Jsoncontent>(JsonConvert.SerializeObject(global.new_root));
                //    global.history_root.historyData.Add(history_add_new_historydata);
                //    dataInputOutput.OutputDataToFile(GlobalData.GlobalData.History_FILE_PATH, JsonConvert.SerializeObject(global.history_root, Formatting.Indented));
                //}

                // refresh History ListView Data
                ReadAndShowHistoryJSONData();
            }
        }
    }
}
