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

        //初始化UI界面的所有信息
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
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3,
                                        GlobalData.GlobalData.COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4
                                    });

            //Init Model_Weight_Level2_textBox
            global.model = new Model();
            Model model = global.model;
            model.CreateModel();
            model.CalculateModelWeight();
            refresh.RefreshModelWeightLevel2TextBox(model,  textBox_ModelWeight_Level2_AnalyzabilityWeight,
                                                            textBox_ModelWeight_Level2_ChangeabilityWeight,
                                                            textBox_ModelWeight_Level2_StabilityWeight,
                                                            textBox_ModelWeight_Level2_ModularityWeight);
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
    }
}
