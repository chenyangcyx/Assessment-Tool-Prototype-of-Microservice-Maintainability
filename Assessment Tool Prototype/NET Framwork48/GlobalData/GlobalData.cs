using NET_Framwork48.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.GlobalData
{
    public class GlobalData
    {
        public static GlobalData globalData = new GlobalData();

        //程序使用的模型
        public Model model;                             //使用的模型
        public DataHandle.JSONDataStruct.Root root;     //从json文件中提取的的root类

        //UI中的全局参数
        public string newline = Environment.NewLine;    //New Line
        public string open_file_path = "";      //打开的文件路径

        ///UI中的常量
        //Label Text
        public const string LABEL_DATAINPUT_INFOTEXT= @"No JSON File Input";
        //comboBox Text
        public const string COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_TEXT = @"Choose One To Edit";
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_TEXT = @"Choose One To See Details";
        //comboBox Choice
        public const string COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE1 = ModelName.LEVELNAME_ATTRIBUTE_1;
        public const string COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE2 = ModelName.LEVELNAME_ATTRIBUTE_2;
        public const string COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE3 = ModelName.LEVELNAME_ATTRIBUTE_3;
        public const string COMBOBOX_MODELWEIGHT_LEVEL3_ATTRIBUTECHOOSE_CHOICE4 = ModelName.LEVELNAME_ATTRIBUTE_4;
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE1 = @"Level 1 - " + ModelName.LEVEL1_NAME;
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE2 = @"Level 2 - " + ModelName.LEVEL2_NAME;
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE3 = @"Level 3 - " + ModelName.LEVEL3_NAME;
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_CHOICE4 = @"Level 4 - " + ModelName.LEVEL4_NAME;
    }
}
