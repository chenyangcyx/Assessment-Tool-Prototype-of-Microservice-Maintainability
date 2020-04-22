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
    }
}
