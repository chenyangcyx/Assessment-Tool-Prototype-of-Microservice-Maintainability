using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_Framwork48.Models;
using NET_Framwork48.Utils;
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
        public void CreateModelTest()
        {
            //测试模型层级数量
            Model model = new Model();
            model.CreateModel();
            string model_str1 = "";
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

            //测试节点的上层节点
            foreach (ModelNode node1 in model.level1_nodes)
            {
                foreach (ModelNode node2 in node1.nextlevel)
                {
                    foreach (ModelNode node3 in node2.nextlevel)
                    {
                        foreach (ModelNode node4 in node3.nextlevel)
                            Assert.AreEqual(node3, node4.prelevel);
                        Assert.AreEqual(node2, node3.prelevel);
                    }
                    Assert.AreEqual(node1, node2.prelevel);
                }
                Assert.AreEqual(null, node1.prelevel);
            }

            //测试节点的上层节点 方法2
            ModelLink ml = new ModelLink();
            for (int i = 0; i < ml.LEVEL1_LINK_1_NUM; i++)
                Assert.AreEqual(model.root_node.prelevel, model.level1_nodes[i].prelevel);

            for (int i = 0; i < ml.LEVEL1_LINK_2_NUM; i++)
                Assert.AreEqual(model.level1_nodes[ml.LEVEL1_LINK_1_NUM - 1], model.level2_nodes[i].prelevel);

            for (int i = 0; i < ml.LEVEL2_LINK_3_NUM[0]; i++)
                Assert.AreEqual(model.level2_nodes[0], model.level3_nodes[i].prelevel);
            for (int i = ml.LEVEL2_LINK_3_NUM[0]; i < ml.LEVEL2_LINK_3_NUM[0] + ml.LEVEL2_LINK_3_NUM[1]; i++)
                Assert.AreEqual(model.level2_nodes[1], model.level3_nodes[i].prelevel);
            for (int i = ml.LEVEL2_LINK_3_NUM[0]
                + ml.LEVEL2_LINK_3_NUM[1];
                i < ml.LEVEL2_LINK_3_NUM[0]
                + ml.LEVEL2_LINK_3_NUM[1]
                + ml.LEVEL2_LINK_3_NUM[2]; i++)
                Assert.AreEqual(model.level2_nodes[2], model.level3_nodes[i].prelevel);
            for (int i = ml.LEVEL2_LINK_3_NUM[0]
                + ml.LEVEL2_LINK_3_NUM[1]
                + ml.LEVEL2_LINK_3_NUM[2];
                i < ml.LEVEL2_LINK_3_NUM[0]
                + ml.LEVEL2_LINK_3_NUM[1]
                + ml.LEVEL2_LINK_3_NUM[2]
                + ml.LEVEL2_LINK_3_NUM[3]; i++)
                Assert.AreEqual(model.level2_nodes[3], model.level3_nodes[i].prelevel);

            for (int i = 0
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                ; i++)
                Assert.AreEqual(model.level3_nodes[0], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                ; i++)
                Assert.AreEqual(model.level3_nodes[1], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                ; i++)
                Assert.AreEqual(model.level3_nodes[2], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                ; i++)
                Assert.AreEqual(model.level3_nodes[3], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                ; i++)
                Assert.AreEqual(model.level3_nodes[4], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                ; i++)
                Assert.AreEqual(model.level3_nodes[5], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                ; i++)
                Assert.AreEqual(model.level3_nodes[6], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                ; i++)
                Assert.AreEqual(model.level3_nodes[7], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                ; i++)
                Assert.AreEqual(model.level3_nodes[8], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                ; i++)
                Assert.AreEqual(model.level3_nodes[9], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                + ml.LEVEL3_LINK_4_NUM[2][1]
                ; i++)
                Assert.AreEqual(model.level3_nodes[10], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                + ml.LEVEL3_LINK_4_NUM[2][1]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                + ml.LEVEL3_LINK_4_NUM[2][1]
                + ml.LEVEL3_LINK_4_NUM[3][0]
                ; i++)
                Assert.AreEqual(model.level3_nodes[11], model.level4_nodes[i].prelevel);
            for (int i = ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                + ml.LEVEL3_LINK_4_NUM[2][1]
                + ml.LEVEL3_LINK_4_NUM[3][0]
                ; i < ml.LEVEL3_LINK_4_NUM[0][0]
                + ml.LEVEL3_LINK_4_NUM[0][1]
                + ml.LEVEL3_LINK_4_NUM[0][2]
                + ml.LEVEL3_LINK_4_NUM[0][3]
                + ml.LEVEL3_LINK_4_NUM[1][0]
                + ml.LEVEL3_LINK_4_NUM[1][1]
                + ml.LEVEL3_LINK_4_NUM[1][2]
                + ml.LEVEL3_LINK_4_NUM[1][3]
                + ml.LEVEL3_LINK_4_NUM[1][4]
                + ml.LEVEL3_LINK_4_NUM[2][0]
                + ml.LEVEL3_LINK_4_NUM[2][1]
                + ml.LEVEL3_LINK_4_NUM[3][0]
                + ml.LEVEL3_LINK_4_NUM[3][1]
                ; i++)
                Assert.AreEqual(model.level3_nodes[12], model.level4_nodes[i].prelevel);
        }

        [TestMethod()]
        public void TrimModelTest()
        {
            OverAllData all = OverAllData.allData;
            all.if_assess_modularity = false;

            //测试模型层级数量
            Model model = new Model();
            model.CreateModel();
            model.TrimModel();
            string model_str1 = "";
            Queue<ModelNode> node_queue = new Queue<ModelNode>();
            node_queue.Enqueue(model.root_node);
            while (node_queue.Count > 0)
            {
                ModelNode now_node = node_queue.Dequeue();
                foreach (ModelNode node in now_node.nextlevel)
                    node_queue.Enqueue(node);
                model_str1 += now_node.NodeLevel;
            }
            Assert.AreEqual("1" + "222" + "33333333333" + "44444444444444444444444444", model_str1);

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
                + "AttributeAttributeAttribute"
                + "PropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyPropertyProperty"
                + "MetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetricMetric"
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
                            + "AnalyzabilityChangeabilityStability"
                            + "CouplingCohesionDesign ComplexitySystem SizeCouplingCohesionService GranularityParameter GranularityService LoopbackParameter GranularityService Loopback"
                            + "NSNDCS()NSNMNSNIS()NSNPI()NII()NSNDCS()NSNMNSNMNPI()NMNMP()NPI()NSWISL()NMNMP()NPI()NSWISL()"
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
            Assert.AreEqual("AnalyzabilityChangeabilityStability", level2_nodes_str);
            Assert.AreEqual("CouplingCohesionDesign ComplexitySystem SizeCouplingCohesionService GranularityParameter GranularityService LoopbackParameter GranularityService Loopback", level3_nodes_str);
            Assert.AreEqual("NSNDCS()NSNMNSNIS()NSNPI()NII()NSNDCS()NSNMNSNMNPI()NMNMP()NPI()NSWISL()NMNMP()NPI()NSWISL()", level4_nodes_str);
        }

        [TestMethod()]
        public void CalculateModelWeightTest()
        {
            OverAllData all = OverAllData.allData;
            ModelWeight mw = new ModelWeight();
            //未经过修剪的模型
            Model model1 = new Model();
            model1.CreateModel();
            all.if_assess_modularity = true;
            model1.TrimModel();

            mw.CalculateNodeNextLevelWeight(model1.level1_nodes[0]);
            Assert.AreEqual(0.25000m, Math.Round(model1.level1_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level1_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level1_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level1_nodes[0].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level2_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level2_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level2_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.25000m, Math.Round(model1.level2_nodes[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model1.level2_nodes[0]);
            Assert.AreEqual(-0.08333m, Math.Round(model1.level2_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.25000m, Math.Round(model1.level2_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model1.level2_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model1.level2_nodes[0].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model1.level3_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.25000m, Math.Round(model1.level3_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model1.level3_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model1.level3_nodes[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model1.level2_nodes[1]);
            Assert.AreEqual(-0.10000m, Math.Round(model1.level2_nodes[1].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level2_nodes[1].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level2_nodes[1].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level2_nodes[1].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model1.level2_nodes[1].nextlevel[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model1.level3_nodes[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level3_nodes[5].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level3_nodes[6].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model1.level3_nodes[7].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model1.level3_nodes[8].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model1.level2_nodes[2]);
            Assert.AreEqual(1.50000m, Math.Round(model1.level2_nodes[2].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.50000m, Math.Round(model1.level2_nodes[2].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.50000m, Math.Round(model1.level3_nodes[9].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.50000m, Math.Round(model1.level3_nodes[10].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model1.level2_nodes[3]);
            Assert.AreEqual(0.50000m, Math.Round(model1.level2_nodes[3].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.50000m, Math.Round(model1.level2_nodes[3].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.50000m, Math.Round(model1.level3_nodes[11].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.50000m, Math.Round(model1.level3_nodes[12].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            for (int i = 0; i < ModelLink.LEVEL3_TOTAL_NUM; i++)
                mw.CalculateNodeNextLevelWeight(model1.level3_nodes[i]);
            for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM; i++)
                mw.CalculateNodeNextLevelWeight(model1.level4_nodes[i]);

            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[0].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[0].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[1].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[1].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[2].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[2].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[3].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[3].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[3].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[4].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[4].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[5].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[5].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[6].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[6].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[6].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[7].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[7].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[7].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[8].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[8].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[9].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[9].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[9].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[10].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[10].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[11].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[11].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[12].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[12].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level3_nodes[12].nextlevel[2].weight);
            for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM; i++)
                Assert.AreEqual(ModelNode.WEIGHT_NONE, model1.level4_nodes[i].weight);

            //经过修剪的模型
            Model model2 = new Model();
            model2.CreateModel();
            all.if_assess_modularity = false;
            model2.TrimModel();

            mw.CalculateNodeNextLevelWeight(model2.level1_nodes[0]);
            Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model2.level2_nodes[0]);
            Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.25000m, Math.Round(model2.level2_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.25000m, Math.Round(model2.level3_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model2.level2_nodes[1]);
            Assert.AreEqual(-0.10000m, Math.Round(model2.level2_nodes[1].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model2.level2_nodes[1].nextlevel[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model2.level3_nodes[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[5].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[6].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[7].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.10000m, Math.Round(model2.level3_nodes[8].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            mw.CalculateNodeNextLevelWeight(model2.level2_nodes[2]);
            Assert.AreEqual(1.50000m, Math.Round(model2.level2_nodes[2].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.50000m, Math.Round(model2.level2_nodes[2].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(1.50000m, Math.Round(model2.level3_nodes[9].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            Assert.AreEqual(-0.50000m, Math.Round(model2.level3_nodes[10].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            for (int i = 0; i < ModelLink.LEVEL3_TOTAL_NUM - 2; i++)
                mw.CalculateNodeNextLevelWeight(model2.level3_nodes[i]);
            for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM - 5; i++)
                mw.CalculateNodeNextLevelWeight(model2.level4_nodes[i]);

            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[0].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[0].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[1].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[1].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[2].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[2].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[4].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[4].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[5].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[5].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[8].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[8].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[1].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[2].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[10].nextlevel[0].weight);
            Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[10].nextlevel[1].weight);
            for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM - 5; i++)
                Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level4_nodes[i].weight);
        }
    }
}