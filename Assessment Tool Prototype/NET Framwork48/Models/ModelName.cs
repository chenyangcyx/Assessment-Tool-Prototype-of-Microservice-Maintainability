using NET_Framwork48.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelName
    {
        /*
         * 模型说明：
         * 层1：Quality Attribute
         * 层2：Attribute
         * 层3：Property
         * 层4：Metric
         * 
         * 层1：Maintainability
         * 层2：Analyzability、Changeability、Stability、Modularity
         * 层3：Coupling、Cohesion、Design Complexity、System Size
         *      Coupling、Cohesion、Service Granularity、Parameter Granularity、Service Loopback
         *      Parameter Granularity、Service Loopback
         *      Cohesion、Service Granularity
         */

        /*层名字定义*/
        string LEVELNAME_QUALITYATTribute_1 = "Maintainability";        //可维护性

        string LEVELNAME_ATTRIBUTE_1 = "Analyzability";                 //可分析性
        string LEVELNAME_ATTRIBUTE_2 = "Changeability";                 //可修改性
        string LEVELNAME_ATTRIBUTE_3 = "Stability";                     //稳定性
        string LEVELNAME_ATTRIBUTE_4 = "Modularity";                    //模块化

        string LEVELNAME_PROPERTY_1 = "Coupling";                      //耦合
        string LEVELNAME_PROPERTY_2 = "Cohesion";                      //内聚
        string LEVELNAME_PROPERTY_3 = "Design Complexity";             //设计复杂度
        string LEVELNAME_PROPERTY_4 = "System Size";                   //系统大小
        string LEVELNAME_PROPERTY_5 = "Service Granularity";           //服务粒度
        string LEVELNAME_PROPERTY_6 = "Parameter Granularity";         //参数粒度
        string LEVELNAME_PROPERTY_7 = "Service Loopback";              //服务调用回环

        string LEVELNAME_METRIC_1 = "NS";
        string LEVELNAME_METRIC_1_DETAIL = "Number of Services";
        string LEVELNAME_METRIC_2 = "NDCS()";
        string LEVELNAME_METRIC_2_DETAIL = "Number of Directly Connected Service";
        string LEVELNAME_METRIC_3 = "NM";
        string LEVELNAME_METRIC_3_DETAIL = "Number of Messages";
        string LEVELNAME_METRIC_4 = "NIS()";
        string LEVELNAME_METRIC_4_DETAIL = "Number of Invoking Service";
        string LEVELNAME_METRIC_5 = "NPI()";
        string LEVELNAME_METRIC_5_DETAIL = "Number of Providing Interfaces";
        string LEVELNAME_METRIC_6 = "NII()";
        string LEVELNAME_METRIC_6_DETAIL = "Number of Invoking Interfaces";
        string LEVELNAME_METRIC_7 = "NMP()";
        string LEVELNAME_METRIC_7_DETAIL = "Number of Message Parameter";
        string LEVELNAME_METRIC_8 = "WISL()";
        string LEVELNAME_METRIC_8_DETAIL = "Whether In a Service Loopback";

        //模型名字构建列表
        Dictionary<string, string> level4_name_detail = new Dictionary<string, string>();
        public string level4_1, level4_2, level4_3, level4_4, level4_5, level4_6, level4_7, level4_8;
        public List<string> level3_1, level3_2, level3_3, level3_4, level3_5, level3_6, level3_7;
        public List<List<string>> level2_1, level2_2, level2_3, level2_4;
        public List<List<List<string>>> level1_1;

        //创建模型Metric层的名字-描述对应细节
        public void CreateModelDictionary()
        {
            level4_name_detail.Add(LEVELNAME_METRIC_1, LEVELNAME_METRIC_1_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_2, LEVELNAME_METRIC_2_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_3, LEVELNAME_METRIC_3_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_4, LEVELNAME_METRIC_4_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_5, LEVELNAME_METRIC_5_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_6, LEVELNAME_METRIC_6_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_7, LEVELNAME_METRIC_7_DETAIL);
            level4_name_detail.Add(LEVELNAME_METRIC_8, LEVELNAME_METRIC_8_DETAIL);
        }

        //创建模型名字引用树
        public void CreateModelNameTree()
        {
            level3_1.Clear();
            level3_2.Clear();
            level3_3.Clear();
            level3_4.Clear();
            level3_5.Clear();
            level3_6.Clear();
            level3_7.Clear();
            level2_1.Clear();
            level2_2.Clear();
            level2_3.Clear();
            level2_4.Clear();
            level1_1.Clear();
            level4_1 = LEVELNAME_METRIC_1;
            level4_2 = LEVELNAME_METRIC_2;
            level4_3 = LEVELNAME_METRIC_3;
            level4_4 = LEVELNAME_METRIC_4;
            level4_5 = LEVELNAME_METRIC_5;
            level4_6 = LEVELNAME_METRIC_6;
            level4_7 = LEVELNAME_METRIC_7;
            level4_8 = LEVELNAME_METRIC_8;
        }

        //创建模型
        public void CreateModel()
        {
            CreateModelDictionary();
            CreateModelNameTree();
        }
    }
}
