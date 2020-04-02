using NET_Framwork48.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    class ModelData
    {
        public static ModelData modelData = new ModelData();
        OverAllData all = OverAllData.allData;

        /********模型层级名字********/
        //第一层
        public string model_levelname_level1;
        string MODEL_LEVELNAME_LEVEL1_INIT = "Maintainability";
        //第二层
        public List<string> model_levelname_level2 = new List<string>();
        string MODEL_LEVELNAME_LEVEL2_OPTIONAL = "Modularity";
        List<string> MODEL_LEVELNAME_LEVEL2_INIT = new List<string>()
        {
            "Analyzability"
            ,"Changeability"
            ,"Stability"
            ,"Modularity"
        };
        //第三层
        public List<List<string>> model_levelname_level3 = new List<List<string>>();
        List<List<string>> MODEL_LEVELNAME_LEVEL3_INIT = new List<List<string>>()
        {
            new List<string>{"Coupling","Cohesion","Design Complexity","System Size"},
            new List<string>{"Coupling","Cohesion","Service Granularity","Parameter Granularity","Service Loopback" },
            new List<string>{"Parameter Granularity","Service Loopback" },
            new List<string>{"Cohesion","Service Granularity" }
        };
        //第四层
        public List<List<List<string>>> model_levelname_level4 = new List<List<List<string>>>();
        List<List<List<string>>> MODEL_LEVELNAME_LEVEL4_INIT = new List<List<List<string>>>()
        {
            new List<List<string>>
            {
                new List<string>{"NS","NDCS()"},
                new List<string>{"NS","NM"},
                new List<string>{"NS","NIS"},
                new List<string>{"NS","NPI()","NII()"}
            },
            new List<List<string>>
            {
                new List<string>{"NS","NDCS()"},
                new List<string>{"NS","NM"},
                new List<string>{"NS","NM","NPI()"},
                new List<string>{"NM","NMP()","NPI()"},
                new List<string>{"NS","WISL()"}
            },
            new List<List<string>>
            {
                new List<string>{"NM","NMP()","NPI()"},
                new List<string>{"NS","WISL()"},
            },
            new List<List<string>>
            {
                new List<string>{"NS","NM"},
                new List<string>{"NS","NM","NPI()"}
            }
        };

        //设置层1的名字
        public void SetLevel1Name()
        {
            model_levelname_level1 = MODEL_LEVELNAME_LEVEL1_INIT;
        }

        //设置层2的名字
        public void SetLevel2Name()
        {
            model_levelname_level2.Clear();
            foreach (string str in MODEL_LEVELNAME_LEVEL2_INIT)
                model_levelname_level2.Add(str);
            //检查是否选择了Modularity
            if (!all.if_assess_modularity)
                model_levelname_level2.Remove(MODEL_LEVELNAME_LEVEL2_OPTIONAL);
        }

        //设置层3的名字
        public void SetLevel3Name()
        {
            foreach(List<string> list in MODEL_LEVELNAME_LEVEL3_INIT)
            {
                List<string> new_list = new List<string>();
                foreach(string str in list)
                    new_list.Add(str);
                model_levelname_level3.Add(new_list);
            }
        }

        //设置层4的名字
        public void SetLevel4Name()
        {
            foreach(List<List<string>> list_list in MODEL_LEVELNAME_LEVEL4_INIT)
            {
                List<List<string>> new_list_list = new List<List<string>>();
                foreach(List<string> list in list_list)
                {
                    List<string> new_list = new List<string>();
                    foreach (string str in list)
                        new_list.Add(str);
                    new_list_list.Add(new_list);
                }
                model_levelname_level4.Add(new_list_list);
            }
        }

        //设置所有层的名字
        public void SetAllLevelName()
        {
            SetLevel1Name();
            SetLevel2Name();
            SetLevel3Name();
            SetLevel4Name();
        }
    }
}
