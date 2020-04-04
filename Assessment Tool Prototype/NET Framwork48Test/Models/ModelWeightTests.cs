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
    }
}