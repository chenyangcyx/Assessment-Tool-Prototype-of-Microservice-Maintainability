using NET_Framwork48.Models;
using System;

namespace NET_Framwork48.GlobalData
{
    public class GlobalData
    {
        public static GlobalData globalData = new GlobalData();

        //the model used by the program
        public Model model;                                             //used Model
        public DataHandle.JSONDataStruct.Root new_root;                 //Root entity from new json file
        public DataHandle.JSONHistoryDataStruct.Root history_root;      //Root entity from history json file

        //global parameters in the UI
        public string newline = Environment.NewLine;                    //new line string
        public string open_file_path = "";                              //open file path
        public const string History_FILE_PATH = "history.json";         //history file path

        ///constants in the UI
        //if already open a JSON data
        public bool if_open_data;
        //Assessment Result ListView Last Choose
        public string assessment_result_last_choose_level;
        public string assessment_result_last_choose_num;
        //Already Open JSON File
        public const string MESSAGEBOX_ERROR_OPEN_JSON_FILE_CAPTION = @"Error Message";
        public const string MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT1 = @"You have already opened a JSON data!";
        public const string MESSAGEBOX_ERROR_OPEN_JSON_FILE_TEXT2 = @"Please click the Reset Button!";
        //Label Text
        public const string LABEL_DATAINPUT_INFOTEXT = @"No JSON File Input!";
        public const string LABEL_DATAINPUT_INPUTNEWFILE = @"New JSON File!";
        public const string LABEL_DATAINPUT_HISTORYDATA = @"History Data!";
        public const string LABEL_DATAINPUT_INVALIDVALUE = @"Invalid Value!";
        public const string LABEL_DATAINPUT_CHANGESUCCESS = @"Change Successful!";
        public const string LABEL_DATAINPUT_DEFAULTSETTINGS = @"Default Settings!";
        //Label Text
        public const string LABEL_MODELWEIGHT_LEVEL3_PROPERTY1 = @"Property1";
        public const string LABEL_MODELWEIGHT_LEVEL3_PROPERTY2 = @"Property2";
        public const string LABEL_MODELWEIGHT_LEVEL3_PROPERTY3 = @"Property3";
        public const string LABEL_MODELWEIGHT_LEVEL3_PROPERTY4 = @"Property4";
        public const string LABEL_MODELWEIGHT_LEVEL3_PROPERTY5 = @"Property5";
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
        public const string COMBOBOX_ASSESSMENTRESULT_LEVELCHOOSE_NOCHOOSE = @"No Choose";
        //Decimal Number Format
        public const string DECIMAL_FORMAT = @"#0.00000000000000";
        //History ListView
        public const string LISTVIEW_HISTORY_COLUMN1_STRING = @"No";
        public const string LISTVIEW_HISTORY_COLUMN2_STRING = @"AssessTime";
        public const string LISTVIEW_HISTORY_COLUMN3_STRING = @"ResultValue";
        public const int LISTVIEW_HISTORY_COLUMN1_WIDTH = 50;
        public const int LISTVIEW_HISTORY_COLUMN2_WIDTH = 140;
        public const int LISTVIEW_HISTORY_COLUMN3_WIDTH = 152;
        //Assessment Result ListView
        public const string LISTVIEW_ASSESSMENTRESULT_COLUMN1_STRING = @"No";
        public const string LISTVIEW_ASSESSMENTRESULT_COLUMN2_STRING = @"Level";
        public const string LISTVIEW_ASSESSMENTRESULT_COLUMN3_STRING = @"Name";
        public const string LISTVIEW_ASSESSMENTRESULT_COLUMN4_STRING = @"Value";
        public const int LISTVIEW_ASSESSMENTRESULT_COLUMN1_WIDTH = 40;
        public const int LISTVIEW_ASSESSMENTRESULT_COLUMN2_WIDTH = 50;
        public const int LISTVIEW_ASSESSMENTRESULT_COLUMN3_WIDTH = 139;
        public const int LISTVIEW_ASSESSMENTRESULT_COLUMN4_WIDTH = 135;

        //convert from String to get Decimal value
        public bool ConvertFromStringToDecimal(string value_str, out decimal value)
        {
            try
            {
                value = Convert.ToDecimal(value_str);
                return true;
            }
            catch (Exception)
            {
                value = 0;
                return false;
            }
        }
    }
}
