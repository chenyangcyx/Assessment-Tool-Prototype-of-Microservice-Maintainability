using NET_Framwork48.DataHandle;
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
        }

        private void button_input_data_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "请选择要打开的json文件";
            open_file.RestoreDirectory = false;
            open_file.Filter = "json格式文件(*.json)|*.json";
            open_file.FilterIndex = 0;
            open_file.Multiselect = false;
            //选择文件
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                //设置打开的文件路径
                global.open_file_path = open_file.FileName;
                //设置ui界面的提示信息
                label_input_data_info.Text = "文件：" + global.open_file_path;
            }
            //显示信息
            DataInput dataInput = new DataInput();
            string file_content = dataInput.InputDataFromFile(global.open_file_path);
            JSONDecoder jsonDecoder = new JSONDecoder();
            global.root = jsonDecoder.GetJSONObject(file_content);
            new UIRefresh().RefreshTextBoxInputDataByDataPath(global.root, textBox_inputdata);
        }

        private void button_assess_start_Click(object sender, EventArgs e)
        {
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            if (global.open_file_path.Equals(""))
                return;

            Model model = global.model;
            model.CreateModel();
            model.CalculateModelWeight();
            DataAnalyze dataAnalyze = new DataAnalyze(global.root, model.modelValue);
            dataAnalyze.SetMetrics();
            model.CalculateModelValue();

            //显示信息
            new UIRefresh().RefreshTextBoxAssessResult(textBox_assessment_result, model, global.root);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            label_input_data_info.Text = @"还未打开json文件";
            GlobalData.GlobalData.globalData.open_file_path = "";
            textBox_inputdata.Clear();
            textBox_assessment_result.Clear();
        }

        private void button_ExitProcess(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
