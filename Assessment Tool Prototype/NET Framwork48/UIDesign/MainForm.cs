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
            label_DataInput_InfoText.Text = @"No JSON File Input";
            GlobalData.GlobalData global = GlobalData.GlobalData.globalData;
            global.model = new Model();
            global.open_file_path = "";
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
            //选择文件
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                //设置打开的文件路径
                global.open_file_path = open_file.FileName;
                //设置ui界面的提示信息
                label_DataInput_InfoText.Text = "";

                //解析文件内容
                DataInput dataInput = new DataInput();
                string file_content = dataInput.InputDataFromFile(global.open_file_path);
                JSONDecoder jsonDecoder = new JSONDecoder();
                global.root = jsonDecoder.GetJSONObject(file_content);

                //将文件的概要输出
                UIRefresh refresh = new UIRefresh();
                refresh.RefreshDataInputTextBox(global.root, textBox_DataInput_FileInfo);
            }
        }
    }
}
