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

        ////是否评估 Modularity
        //public bool if_assess_modularity = true;
        //程序使用的模型
        public Model model = new Model();        //使用的模型
        public DataHandle.JSONDataStruct.Root root;      //json文件的root

        //UI中的全局参数
        public string open_file_path = "";      //打开的文件路径
    }
}
