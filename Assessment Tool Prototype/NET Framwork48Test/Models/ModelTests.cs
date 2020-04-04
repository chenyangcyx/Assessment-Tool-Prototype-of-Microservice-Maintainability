using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_Framwork48.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models.Tests
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public void CreateLevel4MetricDictionaryTest()
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
        public void CreateModelTest()
        {
            //测试模型层级数量
            Model model = new Model();
            model.CreateModel();
            string model_str1="";
            Queue<ModelNode> node_queue = new Queue<ModelNode>();
            node_queue.Enqueue(model.root_node);
            while (node_queue.Count > 0)
            {
                ModelNode now_node = node_queue.Dequeue();
                foreach (ModelNode node in now_node.nextlevel)
                    node_queue.Enqueue(node);
                model_str1 += now_node.NodeLevel;
            }
            Assert.AreEqual("1" + "2222" + "3333333333333" + "4444444444444444444444444444444", model_str1);

            //测试模型的层级命名
            string model_str2 = "";
            node_queue.Clear();
            node_queue.Enqueue(model.root_node);
            while (node_queue.Count > 0)
            {
                ModelNode now_node = node_queue.Dequeue();
                foreach (ModelNode node in now_node.nextlevel)
                    node_queue.Enqueue(node);
                model_str2 += now_node.NodeLevelName;
            }
            Assert.AreEqual("Quality Attribute"
                + "AttributeAttributeAttributeAttribute"
                + "PropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyProperty"
                + "MetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetric"
                , model_str2);

            //测试模型的节点名称
            string model_str3 = "";
            node_queue.Clear();
            node_queue.Enqueue(model.root_node);
            while (node_queue.Count > 0)
            {
                ModelNode now_node = node_queue.Dequeue();
                foreach (ModelNode node in now_node.nextlevel)
                    node_queue.Enqueue(node);
                model_str3 += now_node.NodeName;
            }
            Assert.AreEqual("Maintainability"
                            + "AnalyzabilityChangeabilityStabilityModularity"
                            + "CouplingCohesionDesign ComplexitySystem SizeCouplingCohesionService GranularityParameter GranularityService LoopbackParameter GranularityService LoopbackCohesionService Granularity"
                            + "NSNDCS()NSNMNSNIS()NSNPI()NII()NSNDCS()NSNMNSNMNPI()NMNMP()NPI()NSWISL()NMNMP()NPI()NSWISL()NSNMNSNMNPI()"
                            , model_str3);

            //测试level1_nodes,level2_nodes,level3_nodes,level4_nodes
            string level1_nodes_str = "";
            string level2_nodes_str = "";
            string level3_nodes_str = "";
            string level4_nodes_str = "";
            foreach (ModelNode node in model.level1_nodes)
                level1_nodes_str += node.NodeName;
            foreach (ModelNode node in model.level2_nodes)
                level2_nodes_str += node.NodeName;
            foreach (ModelNode node in model.level3_nodes)
                level3_nodes_str += node.NodeName;
            foreach (ModelNode node in model.level4_nodes)
                level4_nodes_str += node.NodeName;
            Assert.AreEqual("Maintainability", level1_nodes_str);
            Assert.AreEqual("AnalyzabilityChangeabilityStabilityModularity", level2_nodes_str);
            Assert.AreEqual("CouplingCohesionDesign ComplexitySystem SizeCouplingCohesionService GranularityParameter GranularityService LoopbackParameter GranularityService LoopbackCohesionService Granularity", level3_nodes_str);
            Assert.AreEqual("NSNDCS()NSNMNSNIS()NSNPI()NII()NSNDCS()NSNMNSNMNPI()NMNMP()NPI()NSWISL()NMNMP()NPI()NSWISL()NSNMNSNMNPI()", level4_nodes_str);
        }
    }
}