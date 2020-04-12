using NET_Framwork48.GlobalData;
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
        public const string LEVEL1_NAME = "Quality Attribute";
        public const string LEVEL2_NAME = "Attribute";
        public const string LEVEL3_NAME = "Property";
        public const string LEVEL4_NAME = "Metric";

        public const string LEVELNAME_QUALITYATTRIBUTE_1 = "Maintainability";        //可维护性

        public const string LEVELNAME_ATTRIBUTE_1 = "Analyzability";                 //可分析性
        public const string LEVELNAME_ATTRIBUTE_2 = "Changeability";                 //可修改性
        public const string LEVELNAME_ATTRIBUTE_3 = "Stability";                     //稳定性
        public const string LEVELNAME_ATTRIBUTE_4 = "Modularity";                    //模块化

        public const string LEVELNAME_ATTRIBUTE_OPTIONAL= "Modularity";             //可选择评估项目名称

        public const string LEVELNAME_PROPERTY_1 = "Coupling";                      //耦合
        public const string LEVELNAME_PROPERTY_2 = "Cohesion";                      //内聚
        public const string LEVELNAME_PROPERTY_3 = "Design Complexity";             //设计复杂度
        public const string LEVELNAME_PROPERTY_4 = "System Size";                   //系统大小
        public const string LEVELNAME_PROPERTY_5 = "Service Granularity";           //服务粒度
        public const string LEVELNAME_PROPERTY_6 = "Parameter Granularity";         //参数粒度
        public const string LEVELNAME_PROPERTY_7 = "Service Loopback";              //服务调用回环

        public const string LEVELNAME_METRIC_1 = "NS";
        public const string LEVELNAME_METRIC_1_DETAIL = "Number of Services";
        public const string LEVELNAME_METRIC_2 = "NDCS()";
        public const string LEVELNAME_METRIC_2_DETAIL = "Number of Directly Connected Service of Service s";
        public const string LEVELNAME_METRIC_3 = "NM";
        public const string LEVELNAME_METRIC_3_DETAIL = "Number of Messages";
        public const string LEVELNAME_METRIC_4 = "NIS()";
        public const string LEVELNAME_METRIC_4_DETAIL = "Number of Invoking Service of Service s";
        public const string LEVELNAME_METRIC_5 = "NPI()";
        public const string LEVELNAME_METRIC_5_DETAIL = "Number of Providing Interfaces of Service s";
        public const string LEVELNAME_METRIC_6 = "NII()";
        public const string LEVELNAME_METRIC_6_DETAIL = "Number of Invoking Interfaces of Service s";
        public const string LEVELNAME_METRIC_7 = "NMP()";
        public const string LEVELNAME_METRIC_7_DETAIL = "Number of Message Parameter of Service s";
        public const string LEVELNAME_METRIC_8 = "WISL()";
        public const string LEVELNAME_METRIC_8_DETAIL = "Whether Service s In a Service Loopback";

        //Level4的Metric备注字典
        public Dictionary<string, string> level4_metric_detail;

        public ModelName()
        {
            CreateModelDictionary();
        }

        //创建模型Metric层的名字-描述对应细节
        public void CreateModelDictionary()
        {
            level4_metric_detail = new Dictionary<string, string>();
            level4_metric_detail.Add(LEVELNAME_METRIC_1, LEVELNAME_METRIC_1_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_2, LEVELNAME_METRIC_2_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_3, LEVELNAME_METRIC_3_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_4, LEVELNAME_METRIC_4_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_5, LEVELNAME_METRIC_5_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_6, LEVELNAME_METRIC_6_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_7, LEVELNAME_METRIC_7_DETAIL);
            level4_metric_detail.Add(LEVELNAME_METRIC_8, LEVELNAME_METRIC_8_DETAIL);
        }

        public void SetNodeName(ModelNode mn,string name)
        {
            switch (name)
            {
                //第一层
                case LEVELNAME_QUALITYATTRIBUTE_1:
                    mn.NodeName = LEVELNAME_QUALITYATTRIBUTE_1;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 1;
                    mn.NodeLevelName = LEVEL1_NAME;
                    break;
                //第二层
                case LEVELNAME_ATTRIBUTE_1:
                    mn.NodeName = LEVELNAME_ATTRIBUTE_1;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 2;
                    mn.NodeLevelName = LEVEL2_NAME;
                    break;
                case LEVELNAME_ATTRIBUTE_2:
                    mn.NodeName = LEVELNAME_ATTRIBUTE_2;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 2;
                    mn.NodeLevelName = LEVEL2_NAME;
                    break;
                case LEVELNAME_ATTRIBUTE_3:
                    mn.NodeName = LEVELNAME_ATTRIBUTE_3;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 2;
                    mn.NodeLevelName = LEVEL2_NAME;
                    break;
                case LEVELNAME_ATTRIBUTE_4:
                    mn.NodeName = LEVELNAME_ATTRIBUTE_4;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 2;
                    mn.NodeLevelName = LEVEL2_NAME;
                    break;
                //第三层
                case LEVELNAME_PROPERTY_1:
                    mn.NodeName = LEVELNAME_PROPERTY_1;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_2:
                    mn.NodeName = LEVELNAME_PROPERTY_2;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_3:
                    mn.NodeName = LEVELNAME_PROPERTY_3;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_4:
                    mn.NodeName = LEVELNAME_PROPERTY_4;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_5:
                    mn.NodeName = LEVELNAME_PROPERTY_5;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_6:
                    mn.NodeName = LEVELNAME_PROPERTY_6;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                case LEVELNAME_PROPERTY_7:
                    mn.NodeName = LEVELNAME_PROPERTY_7;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 3;
                    mn.NodeLevelName = LEVEL3_NAME;
                    break;
                //第四层
                case LEVELNAME_METRIC_1:
                    mn.NodeName = LEVELNAME_METRIC_1;
                    mn.NodeName_Detail = LEVELNAME_METRIC_1_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_2:
                    mn.NodeName = LEVELNAME_METRIC_2;
                    mn.NodeName_Detail = LEVELNAME_METRIC_2_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_3:
                    mn.NodeName = LEVELNAME_METRIC_3;
                    mn.NodeName_Detail = LEVELNAME_METRIC_3_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_4:
                    mn.NodeName = LEVELNAME_METRIC_4;
                    mn.NodeName_Detail = LEVELNAME_METRIC_4_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_5:
                    mn.NodeName = LEVELNAME_METRIC_5;
                    mn.NodeName_Detail = LEVELNAME_METRIC_5_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_6:
                    mn.NodeName = LEVELNAME_METRIC_6;
                    mn.NodeName_Detail = LEVELNAME_METRIC_6_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_7:
                    mn.NodeName = LEVELNAME_METRIC_7;
                    mn.NodeName_Detail = LEVELNAME_METRIC_7_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
                case LEVELNAME_METRIC_8:
                    mn.NodeName = LEVELNAME_METRIC_8;
                    mn.NodeName_Detail = LEVELNAME_METRIC_8_DETAIL;
                    mn.NodeLevel = 4;
                    mn.NodeLevelName = LEVEL4_NAME;
                    break;
            }
        }
    }
}
