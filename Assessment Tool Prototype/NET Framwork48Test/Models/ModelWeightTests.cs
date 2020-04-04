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
            List<ModelNode> level1_nodes = new List<ModelNode>();
            List<ModelNode> level2_nodes = new List<ModelNode>();
            List<ModelNode> level3_nodes = new List<ModelNode>();
            List<ModelNode> level4_nodes = new List<ModelNode>();
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
            OverAllData all = OverAllData.allData;
            int gain_num, damage_num;
            ModelWeight mw = new ModelWeight();
            //未经过修剪的模型
            Model model = new Model();
            model.CreateModel();
            all.if_assess_modularity = true;
            model.TrimModel();

            mw.CollectNodeNextLevelGainORDamageNum(model.level1_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(4, gain_num);
            Assert.AreEqual(0, damage_num);

            mw.CollectNodeNextLevelGainORDamageNum(model.level2_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(1, gain_num);
            Assert.AreEqual(3, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level2_nodes[1], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(2, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level2_nodes[2], out gain_num, out damage_num);
            Assert.AreEqual(1, gain_num);
            Assert.AreEqual(1, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level2_nodes[3], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);

            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[0], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[1], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[2], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[3], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[4], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[5], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[6], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[7], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[8], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[9], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[10], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[11], out gain_num, out damage_num);
            Assert.AreEqual(2, gain_num);
            Assert.AreEqual(0, damage_num);
            mw.CollectNodeNextLevelGainORDamageNum(model.level3_nodes[12], out gain_num, out damage_num);
            Assert.AreEqual(3, gain_num);
            Assert.AreEqual(0, damage_num);

            foreach(ModelNode node in model.level4_nodes)
            {
                mw.CollectNodeNextLevelGainORDamageNum(node, out gain_num, out damage_num);
                Assert.AreEqual(0, gain_num);
                Assert.AreEqual(0, damage_num);
            }
        }
    }
}