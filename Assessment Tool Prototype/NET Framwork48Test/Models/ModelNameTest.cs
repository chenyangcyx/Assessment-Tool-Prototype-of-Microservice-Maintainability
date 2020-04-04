using NET_Framwork48.Models;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_Framwork48.Utils;

namespace NET_Framwork48.Models.Tests
{
    [TestClass()]
    public class ModelNameTest
    {
        [TestMethod()]
        public void CreateModelDictionaryTest()
        {
            List<string> level4_names;
            level4_names = new List<string>()
            {
                ModelName.LEVELNAME_METRIC_1,
                ModelName.LEVELNAME_METRIC_2,
                ModelName.LEVELNAME_METRIC_3,
                ModelName.LEVELNAME_METRIC_4,
                ModelName.LEVELNAME_METRIC_5,
                ModelName.LEVELNAME_METRIC_6,
                ModelName.LEVELNAME_METRIC_7,
                ModelName.LEVELNAME_METRIC_8
            };

            ModelName modelName = new ModelName();
            Dictionary<string, string> level4_metric_detail = new Dictionary<string, string>();
            modelName.CreateModelDictionary(level4_metric_detail);
            Assert.AreEqual(ModelLink.LEVEL4_UNITNUM, level4_metric_detail.Count);
            string str_get;
            for (int i = 0; i < ModelLink.LEVEL4_UNITNUM; i++)
                Assert.IsTrue(level4_metric_detail.TryGetValue(level4_names[i], out _));

            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_1, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_1_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_2, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_2_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_3, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_3_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_4, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_4_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_5, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_5_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_6, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_6_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_7, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_7_DETAIL, str_get);
            level4_metric_detail.TryGetValue(ModelName.LEVELNAME_METRIC_8, out str_get);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_8_DETAIL, str_get);
        }

        [TestMethod()]
        public void SetNodeNameTest()
        {
            List<string> level1_names, level2_names, level3_names, level4_names;
            level1_names = new List<string>()
            {
                ModelName.LEVELNAME_QUALITYATTRIBUTE_1
            };
            level2_names = new List<string>()
            {
                ModelName.LEVELNAME_ATTRIBUTE_1,
                ModelName.LEVELNAME_ATTRIBUTE_2,
                ModelName.LEVELNAME_ATTRIBUTE_3,
                ModelName.LEVELNAME_ATTRIBUTE_4
            };
            level3_names = new List<string>()
            {
                ModelName.LEVELNAME_PROPERTY_1,
                ModelName.LEVELNAME_PROPERTY_2,
                ModelName.LEVELNAME_PROPERTY_3,
                ModelName.LEVELNAME_PROPERTY_4,
                ModelName.LEVELNAME_PROPERTY_5,
                ModelName.LEVELNAME_PROPERTY_6,
                ModelName.LEVELNAME_PROPERTY_7,
            };
            level4_names = new List<string>()
            {
                ModelName.LEVELNAME_METRIC_1,
                ModelName.LEVELNAME_METRIC_2,
                ModelName.LEVELNAME_METRIC_3,
                ModelName.LEVELNAME_METRIC_4,
                ModelName.LEVELNAME_METRIC_5,
                ModelName.LEVELNAME_METRIC_6,
                ModelName.LEVELNAME_METRIC_7,
                ModelName.LEVELNAME_METRIC_8
            };

            ModelName mn = new ModelName();
            ModelNode[] node1 = new ModelNode[ModelLink.LEVEL1_UNITNUM];
            ModelNode[] node2 = new ModelNode[ModelLink.LEVEL2_UNITNUM];
            ModelNode[] node3 = new ModelNode[ModelLink.LEVEL3_UNITNUM];
            ModelNode[] node4 = new ModelNode[ModelLink.LEVEL4_UNITNUM];
            //第一层
            for (int i = 0; i < ModelLink.LEVEL1_UNITNUM; i++)
            {
                node1[i] = new ModelNode();
                mn.SetNodeName(node1[i], level1_names[i]);
            }
            Assert.AreEqual(ModelName.LEVELNAME_QUALITYATTRIBUTE_1, node1[0].NodeName);
            Assert.AreEqual("", node1[0].NodeName_Detail);
            Assert.AreEqual(1, node1[0].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL1_NAME, node1[0].NodeLevelName);
            //第二层
            for (int i = 0; i < ModelLink.LEVEL2_UNITNUM; i++)
            {
                node2[i] = new ModelNode();
                mn.SetNodeName(node2[i], level2_names[i]);
            }
            Assert.AreEqual(ModelName.LEVELNAME_ATTRIBUTE_1, node2[0].NodeName);
            Assert.AreEqual("", node2[0].NodeName_Detail);
            Assert.AreEqual(2, node2[0].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL2_NAME, node2[0].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_ATTRIBUTE_2, node2[1].NodeName);
            Assert.AreEqual("", node2[1].NodeName_Detail);
            Assert.AreEqual(2, node2[1].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL2_NAME, node2[1].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_ATTRIBUTE_3, node2[2].NodeName);
            Assert.AreEqual("", node2[2].NodeName_Detail);
            Assert.AreEqual(2, node2[2].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL2_NAME, node2[2].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_ATTRIBUTE_4, node2[3].NodeName);
            Assert.AreEqual("", node2[3].NodeName_Detail);
            Assert.AreEqual(2, node2[3].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL2_NAME, node2[3].NodeLevelName);
            //第三层
            for (int i = 0; i < ModelLink.LEVEL3_UNITNUM; i++)
            {
                node3[i] = new ModelNode();
                mn.SetNodeName(node3[i], level3_names[i]);
            }
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_1, node3[0].NodeName);
            Assert.AreEqual("", node3[0].NodeName_Detail);
            Assert.AreEqual(3, node3[0].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[0].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_2, node3[1].NodeName);
            Assert.AreEqual("", node3[1].NodeName_Detail);
            Assert.AreEqual(3, node3[1].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[1].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_3, node3[2].NodeName);
            Assert.AreEqual("", node3[2].NodeName_Detail);
            Assert.AreEqual(3, node3[2].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[2].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_4, node3[3].NodeName);
            Assert.AreEqual("", node3[3].NodeName_Detail);
            Assert.AreEqual(3, node3[3].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[3].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_5, node3[4].NodeName);
            Assert.AreEqual("", node3[4].NodeName_Detail);
            Assert.AreEqual(3, node3[4].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[4].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_6, node3[5].NodeName);
            Assert.AreEqual("", node3[5].NodeName_Detail);
            Assert.AreEqual(3, node3[5].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[5].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_PROPERTY_7, node3[6].NodeName);
            Assert.AreEqual("", node3[6].NodeName_Detail);
            Assert.AreEqual(3, node3[6].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL3_NAME, node3[6].NodeLevelName);
            //第四层
            for (int i = 0; i < ModelLink.LEVEL4_UNITNUM; i++)
            {
                node4[i] = new ModelNode();
                mn.SetNodeName(node4[i], level4_names[i]);
            }
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_1, node4[0].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_1_DETAIL, node4[0].NodeName_Detail);
            Assert.AreEqual(4, node4[0].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[0].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_2, node4[1].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_2_DETAIL, node4[1].NodeName_Detail);
            Assert.AreEqual(4, node4[1].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[1].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_3, node4[2].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_3_DETAIL, node4[2].NodeName_Detail);
            Assert.AreEqual(4, node4[2].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[2].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_4, node4[3].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_4_DETAIL, node4[3].NodeName_Detail);
            Assert.AreEqual(4, node4[3].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[3].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_5, node4[4].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_5_DETAIL, node4[4].NodeName_Detail);
            Assert.AreEqual(4, node4[4].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[4].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_6, node4[5].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_6_DETAIL, node4[5].NodeName_Detail);
            Assert.AreEqual(4, node4[5].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[5].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_7, node4[6].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_7_DETAIL, node4[6].NodeName_Detail);
            Assert.AreEqual(4, node4[6].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[6].NodeLevelName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_8, node4[7].NodeName);
            Assert.AreEqual(ModelName.LEVELNAME_METRIC_8_DETAIL, node4[7].NodeName_Detail);
            Assert.AreEqual(4, node4[7].NodeLevel);
            Assert.AreEqual(ModelName.LEVEL4_NAME, node4[7].NodeLevelName);
        }
    }
}