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
        public void ReSetLevelNameTest()
        {
            ModelName modelName = new ModelName();
            modelName.ReSetLevelName();
            Assert.AreEqual(0, modelName.model_levelname_level1.Length);
            Assert.AreEqual(0, modelName.model_levelname_level2.Count);
            Assert.AreEqual(0, modelName.model_levelname_level3.Count);
            Assert.AreEqual(0, modelName.model_levelname_level4.Count);
        }

        [TestMethod()]
        public void SetLevel1NameTest()
        {
            ModelName modelName = new ModelName();
            modelName.SetLevel1Name();
            Assert.AreEqual(modelName.MODEL_LEVELNAME_LEVEL1_INIT.Length, modelName.model_levelname_level1.Length);

            string init = modelName.MODEL_LEVELNAME_LEVEL1_INIT;
            string newstr = modelName.model_levelname_level1;
            Assert.AreEqual(init, newstr);
        }

        [TestMethod()]
        public void SetLevel2NameTest()
        {
            OverAllData all = OverAllData.allData;

            all.if_assess_modularity = true;
            ModelName modelName = new ModelName();
            modelName.SetLevel2Name();
            Assert.AreEqual(modelName.MODEL_LEVELNAME_LEVEL2_INIT.Count, modelName.model_levelname_level2.Count);
            string init = "";
            foreach (string str in modelName.MODEL_LEVELNAME_LEVEL2_INIT)
                init += str;
            string newstr = "";
            foreach (string str in modelName.model_levelname_level2)
                newstr += str;
            Assert.AreEqual(init, newstr);

            all.if_assess_modularity = false;
            modelName.SetLevel2Name();
            Assert.AreEqual(modelName.MODEL_LEVELNAME_LEVEL2_INIT.Count, modelName.model_levelname_level2.Count + 1);
            init = "";
            foreach (string str in modelName.MODEL_LEVELNAME_LEVEL2_INIT)
                init += str;
            newstr = "";
            foreach (string str in modelName.model_levelname_level2)
                newstr += str;
            Assert.AreEqual(init.Replace(modelName.MODEL_LEVELNAME_LEVEL2_OPTIONAL, ""), newstr);
        }

        [TestMethod()]
        public void SetLevel3NameTest()
        {
            ModelName modelName = new ModelName();
            modelName.SetLevel3Name();
            Assert.AreEqual(modelName.MODEL_LEVELNAME_LEVEL3_INIT.Count, modelName.model_levelname_level3.Count);

            for (int i = 0; i < modelName.MODEL_LEVELNAME_LEVEL3_INIT.Count; i++)
            {
                List<string> list_init = modelName.MODEL_LEVELNAME_LEVEL3_INIT[i];
                List<string> new_list = modelName.model_levelname_level3[i];
                Assert.AreEqual(list_init.Count, new_list.Count);
                Assert.AreEqual(list_init.ToString(), new_list.ToString());

                string str_init = "";
                string str_new = "";
                for (int j = 0; j < list_init.Count; j++)
                {
                    str_init += list_init[j];
                    str_new += new_list[j];
                }
                Assert.AreEqual(str_init, str_new);
            }
        }

        [TestMethod()]
        public void SetLevel4NameTest()
        {
            ModelName modelName = new ModelName();
            modelName.SetLevel4Name();
            Assert.AreEqual(modelName.MODEL_LEVELNAME_LEVEL4_INIT.Count, modelName.model_levelname_level4.Count);

            for (int i = 0; i < modelName.MODEL_LEVELNAME_LEVEL4_INIT.Count; i++)
            {
                List<List<string>> list_list_init = modelName.MODEL_LEVELNAME_LEVEL4_INIT[i];
                List<List<string>> new_list_list = modelName.model_levelname_level4[i];
                Assert.AreEqual(list_list_init.Count, new_list_list.Count);
                Assert.AreEqual(list_list_init.ToString(), new_list_list.ToString());

                for (int j = 0; j < list_list_init.Count; j++)
                {
                    List<string> list_init = list_list_init[j];
                    List<string> new_list = new_list_list[j];
                    Assert.AreEqual(list_init.Count, new_list.Count);
                    Assert.AreEqual(list_init.ToString(), new_list.ToString());

                    string str_init = "";
                    string str_new = "";
                    for (int k = 0; k < list_init.Count; k++)
                    {
                        str_init += list_init[k];
                        str_new += new_list[k];
                    }
                    Assert.AreEqual(str_init, str_new);
                }
            }
        }

        [TestMethod()]
        public void SetAllLevelNameTest()
        {
            ModelName modelName = new ModelName();
            modelName.SetAllLevelName();

            SetLevel1NameTest();
            SetLevel2NameTest();
            SetLevel3NameTest();
            SetLevel4NameTest();
        }
    }
}