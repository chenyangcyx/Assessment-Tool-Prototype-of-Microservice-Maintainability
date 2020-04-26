using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NET_Framwork48.Models.Tests
{
    [TestClass()]
    public class ModelWeightTests
    {
        [TestMethod()]
        public void CreateModelNodeAffectDictionaryTest()
        {
            ModelWeight mw = new ModelWeight();
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_QUALITYATTRIBUTE_1, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_1, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_2, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_3, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_4, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_1, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_2, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_3, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_4, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_5, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_6, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_7, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_1, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_2, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_3, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_4, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_5, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_6, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_7, out _));
            Assert.IsTrue(mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_8, out _));

            int result;
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_QUALITYATTRIBUTE_1, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_1, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_2, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_3, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_ATTRIBUTE_4, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_1, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_DAMAGE, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_2, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_3, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_DAMAGE, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_4, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_DAMAGE, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_5, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_6, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_PROPERTY_7, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_DAMAGE, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_1, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_2, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_3, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_4, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_5, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_6, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_7, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
            mw.node_affect_dictionary.TryGetValue(ModelName.LEVELNAME_METRIC_8, out result);
            Assert.AreEqual(ModelWeight.NODE_AFFECT_GAIN, result);
        }

        [TestMethod()]
        public void SetNodeGainORDamageTest()
        {
            ModelName mn = new ModelName();
            ModelWeight mw = new ModelWeight();

            ModelNode[] l1n = new ModelNode[ModelLink.LEVEL1_UNITNUM];
            ModelNode[] l2n = new ModelNode[ModelLink.LEVEL2_UNITNUM];
            ModelNode[] l3n = new ModelNode[ModelLink.LEVEL3_UNITNUM];
            ModelNode[] l4n = new ModelNode[ModelLink.LEVEL4_UNITNUM];
            for (int i = 0; i < ModelLink.LEVEL1_UNITNUM; i++)
                l1n[i] = new ModelNode();
            for (int i = 0; i < ModelLink.LEVEL2_UNITNUM; i++)
                l2n[i] = new ModelNode();
            for (int i = 0; i < ModelLink.LEVEL3_UNITNUM; i++)
                l3n[i] = new ModelNode();
            for (int i = 0; i < ModelLink.LEVEL4_UNITNUM; i++)
                l4n[i] = new ModelNode();

            mn.SetNodeName(l1n[0], ModelName.LEVELNAME_QUALITYATTRIBUTE_1);
            mn.SetNodeName(l2n[0], ModelName.LEVELNAME_ATTRIBUTE_1);
            mn.SetNodeName(l2n[1], ModelName.LEVELNAME_ATTRIBUTE_2);
            mn.SetNodeName(l2n[2], ModelName.LEVELNAME_ATTRIBUTE_3);
            mn.SetNodeName(l2n[3], ModelName.LEVELNAME_ATTRIBUTE_4);
            mn.SetNodeName(l3n[0], ModelName.LEVELNAME_PROPERTY_1);
            mn.SetNodeName(l3n[1], ModelName.LEVELNAME_PROPERTY_2);
            mn.SetNodeName(l3n[2], ModelName.LEVELNAME_PROPERTY_3);
            mn.SetNodeName(l3n[3], ModelName.LEVELNAME_PROPERTY_4);
            mn.SetNodeName(l3n[4], ModelName.LEVELNAME_PROPERTY_5);
            mn.SetNodeName(l3n[5], ModelName.LEVELNAME_PROPERTY_6);
            mn.SetNodeName(l3n[6], ModelName.LEVELNAME_PROPERTY_7);
            mn.SetNodeName(l4n[0], ModelName.LEVELNAME_METRIC_1);
            mn.SetNodeName(l4n[1], ModelName.LEVELNAME_METRIC_2);
            mn.SetNodeName(l4n[2], ModelName.LEVELNAME_METRIC_3);
            mn.SetNodeName(l4n[3], ModelName.LEVELNAME_METRIC_4);
            mn.SetNodeName(l4n[4], ModelName.LEVELNAME_METRIC_5);
            mn.SetNodeName(l4n[5], ModelName.LEVELNAME_METRIC_6);
            mn.SetNodeName(l4n[6], ModelName.LEVELNAME_METRIC_7);
            mn.SetNodeName(l4n[7], ModelName.LEVELNAME_METRIC_8);

            for (int i = 0; i < ModelLink.LEVEL1_UNITNUM; i++)
                mw.SetNodeGainORDamage(l1n[i]);
            for (int i = 0; i < ModelLink.LEVEL2_UNITNUM; i++)
                mw.SetNodeGainORDamage(l2n[i]);
            for (int i = 0; i < ModelLink.LEVEL3_UNITNUM; i++)
                mw.SetNodeGainORDamage(l3n[i]);
            for (int i = 0; i < ModelLink.LEVEL4_UNITNUM; i++)
                mw.SetNodeGainORDamage(l4n[i]);

            int result;
            for (int i = 0; i < ModelLink.LEVEL1_UNITNUM; i++)
            {
                mw.node_affect_dictionary.TryGetValue(l1n[i].NodeName, out result);
                Assert.AreEqual(result, l1n[i].gain_or_damage);
            }
            for (int i = 0; i < ModelLink.LEVEL2_UNITNUM; i++)
            {
                mw.node_affect_dictionary.TryGetValue(l2n[i].NodeName, out result);
                Assert.AreEqual(result, l2n[i].gain_or_damage);
            }
            for (int i = 0; i < ModelLink.LEVEL3_UNITNUM; i++)
            {
                mw.node_affect_dictionary.TryGetValue(l3n[i].NodeName, out result);
                Assert.AreEqual(result, l3n[i].gain_or_damage);
            }
            for (int i = 0; i < ModelLink.LEVEL4_UNITNUM; i++)
            {
                mw.node_affect_dictionary.TryGetValue(l4n[i].NodeName, out result);
                Assert.AreEqual(result, l4n[i].gain_or_damage);
            }
        }

        [TestMethod()]
        public void CollectNodeNextLevelGainORDamageNumTest()
        {
            //GlobalData.GlobalData all = GlobalData.GlobalData.globalData;
            int gain_num, damage_num;
            ModelWeight mw = new ModelWeight();
            Model model1 = new Model();
            model1.CreateModel();
            //all.if_assess_modularity = true;
            //model1.TrimModel();

            mw.CollectNodeNextLevelGainORDamageNum(model1.level1_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(4, gain_num);
            Assert.AreEqual(0, damage_num);

            mw.CollectNodeNextLevelGainORDamageNum(model1.level2_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(1, gain_num);
            Assert.AreEqual(3, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level2_nodes[1], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(2, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level2_nodes[2], out gain_num, out damage_num);
            Assert.AreEqual(1, gain_num);
            Assert.AreEqual(1, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level2_nodes[3], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);

            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[1], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[2], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[3], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[4], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[5], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[6], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[7], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[8], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[9], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[10], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[11], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model1.level3_nodes[12], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);

            foreach (ModelNode node in model1.level4_nodes)
            {
                mw.CollectNodeNextLevelGainORDamageNum(node, out gain_num, out damage_num);
                Assert.AreEqual(0, gain_num);
                Assert.AreEqual(0, damage_num);
            }

            ////经过修剪的模型
            //Model model2 = new Model();
            //model2.CreateModel();
            //all.if_assess_modularity = false;
            //model2.TrimModel();

            //mw.CollectNodeNextLevelGainORDamageNum(model2.level1_nodes[0], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(0, damage_num);

            //mw.CollectNodeNextLevelGainORDamageNum(model2.level2_nodes[0], out gain_num, out damage_num);
            //Assert.AreEqual(1, gain_num);
            //Assert.AreEqual(3, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level2_nodes[1], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(2, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level2_nodes[2], out gain_num, out damage_num);
            //Assert.AreEqual(1, gain_num);
            //Assert.AreEqual(1, damage_num);

            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[0], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[1], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[2], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[3], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[4], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[5], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[6], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[7], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[8], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[9], out gain_num, out damage_num);
            //Assert.AreEqual(3, gain_num);
            //Assert.AreEqual(0, damage_num);
            //mw.CollectNodeNextLevelGainORDamageNum(model2.level3_nodes[10], out gain_num, out damage_num);
            //Assert.AreEqual(2, gain_num);
            //Assert.AreEqual(0, damage_num);

            //foreach (ModelNode node in model2.level4_nodes)
            //{
            //    mw.CollectNodeNextLevelGainORDamageNum(node, out gain_num, out damage_num);
            //    Assert.AreEqual(0, gain_num);
            //    Assert.AreEqual(0, damage_num);
            //}
        }

        [TestMethod()]
        public void CalculateNodeNextLevelWeightTest()
        {
            //GlobalData.GlobalData all = GlobalData.GlobalData.globalData;
            ModelWeight mw = new ModelWeight();
            Model model1 = new Model();
            model1.CreateModel();
            //all.if_assess_modularity = true;
            //model1.TrimModel();

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

            ////经过修剪的模型
            //Model model2 = new Model();
            //model2.CreateModel();
            //all.if_assess_modularity = false;
            //model2.TrimModel();

            //mw.CalculateNodeNextLevelWeight(model2.level1_nodes[0]);
            //Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.33333m, Math.Round(model2.level1_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.33333m, Math.Round(model2.level2_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            //mw.CalculateNodeNextLevelWeight(model2.level2_nodes[0]);
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(1.25000m, Math.Round(model2.level2_nodes[0].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level2_nodes[0].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(1.25000m, Math.Round(model2.level3_nodes[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.08333m, Math.Round(model2.level3_nodes[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            //mw.CalculateNodeNextLevelWeight(model2.level2_nodes[1]);
            //Assert.AreEqual(-0.10000m, Math.Round(model2.level2_nodes[1].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[2].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level2_nodes[1].nextlevel[3].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.10000m, Math.Round(model2.level2_nodes[1].nextlevel[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.10000m, Math.Round(model2.level3_nodes[4].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[5].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[6].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(0.40000m, Math.Round(model2.level3_nodes[7].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.10000m, Math.Round(model2.level3_nodes[8].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            //mw.CalculateNodeNextLevelWeight(model2.level2_nodes[2]);
            //Assert.AreEqual(1.50000m, Math.Round(model2.level2_nodes[2].nextlevel[0].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.50000m, Math.Round(model2.level2_nodes[2].nextlevel[1].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(1.50000m, Math.Round(model2.level3_nodes[9].weight, ModelWeight.WEIGHT_VALUE_ROUND));
            //Assert.AreEqual(-0.50000m, Math.Round(model2.level3_nodes[10].weight, ModelWeight.WEIGHT_VALUE_ROUND));

            //for (int i = 0; i < ModelLink.LEVEL3_TOTAL_NUM - 2; i++)
            //    mw.CalculateNodeNextLevelWeight(model2.level3_nodes[i]);
            //for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM - 5; i++)
            //    mw.CalculateNodeNextLevelWeight(model2.level4_nodes[i]);

            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[0].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[0].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[1].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[1].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[2].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[2].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[3].nextlevel[2].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[4].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[4].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[5].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[5].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[6].nextlevel[2].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[7].nextlevel[2].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[8].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[8].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[1].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[9].nextlevel[2].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[10].nextlevel[0].weight);
            //Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level3_nodes[10].nextlevel[1].weight);
            //for (int i = 0; i < ModelLink.LEVEL4_TOTAL_NUM - 5; i++)
            //    Assert.AreEqual(ModelNode.WEIGHT_NONE, model2.level4_nodes[i].weight);
        }
    }
}