using System.Collections.Generic;

namespace NET_Framwork48.Models
{
    public class ModelName
    {
        /*
         * Model description:
         * Level 1：Quality Attribute
         * Level 2：Attribute
         * Level 3：Property
         * Level 4：Metric
         * 
         * Level 1：Maintainability
         * Level 2：Analyzability、Changeability、Stability、Modularity
         * Level 3：Coupling、Cohesion、Design Complexity、System Size
         *      Coupling、Cohesion、Service Granularity、Parameter Granularity、Service Loopback
         *      Parameter Granularity、Service Loopback
         *      Cohesion、Service Granularity
         */

        // level name definition
        public const string LEVEL1_NAME = "Quality Attribute";
        public const string LEVEL2_NAME = "Attribute";
        public const string LEVEL3_NAME = "Property";
        public const string LEVEL4_NAME = "Metric";

        public const string LEVELNAME_QUALITYATTRIBUTE_1 = "Maintainability";           // Maintainability

        public const string LEVELNAME_ATTRIBUTE_1 = "Analyzability";                    // Analyzability
        public const string LEVELNAME_ATTRIBUTE_2 = "Changeability";                    // Changeability
        public const string LEVELNAME_ATTRIBUTE_3 = "Stability";                        // Stability
        public const string LEVELNAME_ATTRIBUTE_4 = "Modularity";                       // Modularity

        public const string LEVELNAME_PROPERTY_1 = "Coupling";                          // Coupling
        public const string LEVELNAME_PROPERTY_2 = "Cohesion";                          // Cohesion
        public const string LEVELNAME_PROPERTY_3 = "Design Complexity";                 // Design Complexity
        public const string LEVELNAME_PROPERTY_4 = "System Size";                       // System Size
        public const string LEVELNAME_PROPERTY_5 = "Service Granularity";               // Service Granularity
        public const string LEVELNAME_PROPERTY_6 = "Parameter Granularity";             // Parameter Granularity
        public const string LEVELNAME_PROPERTY_7 = "Service Loopback";                  // Service Loopback

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

        // Level4 Metric Remarks Dictionary
        public Dictionary<string, string> level4_metric_detail;

        public ModelName()
        {
            CreateModelDictionary();
        }

        // create a model Metric Level name-describe the corresponding details
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

        public void SetNodeName(ModelNode mn, string name)
        {
            switch (name)
            {
                // Level 1
                case LEVELNAME_QUALITYATTRIBUTE_1:
                    mn.NodeName = LEVELNAME_QUALITYATTRIBUTE_1;
                    mn.NodeName_Detail = "";
                    mn.NodeLevel = 1;
                    mn.NodeLevelName = LEVEL1_NAME;
                    break;
                // Level 2
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
                // Level 3
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
                // Level 4
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
