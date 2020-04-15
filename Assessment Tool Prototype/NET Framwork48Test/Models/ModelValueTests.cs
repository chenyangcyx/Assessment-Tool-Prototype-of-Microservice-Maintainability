using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_Framwork48.Models;
using NET_Framwork48.GlobalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models.Tests
{
    [TestClass()]
    public class ModelValueTests
    {
        public void SetModelValueSample(ModelValue mv)
        {
            //添加服务名字
            mv.Dic_NO_ServiceName.Add(0, "Service 1");
            mv.Dic_NO_ServiceName.Add(1, "Service 2");
            mv.Dic_NO_ServiceName.Add(2, "Service 3");
            mv.Dic_NO_ServiceName.Add(3, "Service 4");
            mv.Dic_NO_ServiceName.Add(4, "Service 5");
            //添加数值
            mv.NS = 12.23456m;
            mv.NDCS_NO_VALUE.Add(0, 1.23456m);
            mv.NDCS_NO_VALUE.Add(1, 2.34567m);
            mv.NDCS_NO_VALUE.Add(2, 3.45678m);
            mv.NDCS_NO_VALUE.Add(3, 4.56789m);
            mv.NDCS_NO_VALUE.Add(4, 5.67890m);
            mv.NM = 23.45678m;
            mv.NIS_NO_VALUE.Add(0, 6.78901m);
            mv.NIS_NO_VALUE.Add(1, 7.89012m);
            mv.NIS_NO_VALUE.Add(2, 8.90123m);
            mv.NIS_NO_VALUE.Add(3, 9.01234m);
            mv.NIS_NO_VALUE.Add(4, 10.12345m);
            mv.NPI_NO_VALUE.Add(0, 11.23456m);
            mv.NPI_NO_VALUE.Add(1, 12.34567m);
            mv.NPI_NO_VALUE.Add(2, 13.45678m);
            mv.NPI_NO_VALUE.Add(3, 14.56789m);
            mv.NPI_NO_VALUE.Add(4, 15.67890m);
            mv.NII_NO_VALUE.Add(0, 16.78901m);
            mv.NII_NO_VALUE.Add(1, 17.89012m);
            mv.NII_NO_VALUE.Add(2, 18.90123m);
            mv.NII_NO_VALUE.Add(3, 19.01234m);
            mv.NII_NO_VALUE.Add(4, 20.12345m);
            mv.NMP_NO_VALUE.Add(0, 21.23456m);
            mv.NMP_NO_VALUE.Add(1, 22.34567m);
            mv.NMP_NO_VALUE.Add(2, 23.45678m);
            mv.NMP_NO_VALUE.Add(3, 24.56789m);
            mv.NMP_NO_VALUE.Add(4, 25.67890m);
            mv.WISL_NO_VALUE.Add(0, 1);
            mv.WISL_NO_VALUE.Add(1, 0);
            mv.WISL_NO_VALUE.Add(2, 1);
            mv.WISL_NO_VALUE.Add(3, 1);
            mv.WISL_NO_VALUE.Add(4, 0);
        }

        [TestMethod()]
        public void CalculateLevel4ValuesTest()
        {
            //构建Model的Dictionary
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第4层数值
            mv.CalculateLevel4Values();
            //验证计算结果
            Assert.AreEqual(12.23456m, mv.NS);
            Assert.AreEqual(17.28380m, mv.NDCS_TOTAL);
            Assert.AreEqual(23.45678m, mv.NM);
            Assert.AreEqual(42.71615m, mv.NIS_TOTAL);
            Assert.AreEqual(67.28380m, mv.NPI_TOTAL);
            Assert.AreEqual(92.71615m, mv.NII_TOTAL);
            Assert.AreEqual(117.28380m, mv.NMP_TOTAL);
            Assert.AreEqual(3, mv.WISL_TOTAL);
        }

        [TestMethod()]
        public void CalculateLevel3ValuesTest()
        {
            //构建Model的Dictionary
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第3层数值
            mv.CalculateLevel4Values();
            mv.CalculateLevel3Values();
            //验证计算结果
            Assert.AreEqual(mv.NDCS_TOTAL / mv.NS, mv.Coupling);
            Assert.AreEqual(mv.NS / mv.NM, mv.Cohesion);
            Assert.AreEqual(mv.NIS_TOTAL / (mv.NS * mv.NS - mv.NS), mv.Design_Complexity);
            Assert.AreEqual((mv.NPI_TOTAL + mv.NII_TOTAL) / mv.NS, mv.System_Size);
            Assert.AreEqual((mv.NPI_TOTAL * mv.NPI_TOTAL) / (mv.NM * mv.NM), mv.Service_Granularity);
            Assert.AreEqual((mv.NMP_TOTAL * mv.NMP_TOTAL) / (mv.NPI_TOTAL * mv.NPI_TOTAL), mv.Parameter_Granularity);
            Assert.AreEqual(mv.WISL_TOTAL / mv.NS, mv.Service_Loopback);

            Assert.AreEqual(17.28380m / 12.23456m, mv.Coupling);
            Assert.AreEqual(12.23456m / 23.45678m, mv.Cohesion);
            Assert.AreEqual(42.71615m / (12.23456m * 12.23456m - 12.23456m), mv.Design_Complexity);
            Assert.AreEqual((67.28380m + 92.71615m) / 12.23456m, mv.System_Size);
            Assert.AreEqual((67.28380m * 67.28380m) / (23.45678m * 23.45678m), mv.Service_Granularity);
            Assert.AreEqual((117.28380m * 117.28380m) / (67.28380m * 67.28380m), mv.Parameter_Granularity);
            Assert.AreEqual(3 / 12.23456m, mv.Service_Loopback);
        }

        [TestMethod()]
        public void SetLevel4UnitValueTest()
        {
            Model model = new Model();
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第4层数值
            mv.CalculateLevel4Values();

            //未裁剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = true;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel4UnitValue(model.level3_nodes);
            mv.SetLevel4UnitValue(model.level2_nodes);
            mv.SetLevel4UnitValue(model.level1_nodes);
            //验证第4层的值
            Assert.AreEqual(12.23456m, model.level4_nodes[0].value);
            Assert.AreEqual(17.28380m, model.level4_nodes[1].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[2].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[3].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[4].value);
            Assert.AreEqual(42.71615m, model.level4_nodes[5].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[6].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[7].value);
            Assert.AreEqual(92.71615m, model.level4_nodes[8].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[9].value);
            Assert.AreEqual(17.28380m, model.level4_nodes[10].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[11].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[12].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[13].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[14].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[15].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[16].value);
            Assert.AreEqual(117.28380m, model.level4_nodes[17].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[18].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[19].value);
            Assert.AreEqual(3, model.level4_nodes[20].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[21].value);
            Assert.AreEqual(117.28380m, model.level4_nodes[22].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[23].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[24].value);
            Assert.AreEqual(3, model.level4_nodes[25].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[26].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[27].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[28].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[29].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[30].value);
            //验证第3层的值
            foreach (var node in model.level3_nodes)
                Assert.AreEqual(0, node.value);
            //验证第2层的值
            foreach (var node in model.level2_nodes)
                Assert.AreEqual(0, node.value);
            //验证第1层的值
            foreach (var node in model.level1_nodes)
                Assert.AreEqual(0, node.value);

            //裁剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = false;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel4UnitValue(model.level3_nodes);
            mv.SetLevel4UnitValue(model.level2_nodes);
            mv.SetLevel4UnitValue(model.level1_nodes);
            //验证第4层的值
            Assert.AreEqual(12.23456m, model.level4_nodes[0].value);
            Assert.AreEqual(17.28380m, model.level4_nodes[1].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[2].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[3].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[4].value);
            Assert.AreEqual(42.71615m, model.level4_nodes[5].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[6].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[7].value);
            Assert.AreEqual(92.71615m, model.level4_nodes[8].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[9].value);
            Assert.AreEqual(17.28380m, model.level4_nodes[10].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[11].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[12].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[13].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[14].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[15].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[16].value);
            Assert.AreEqual(117.28380m, model.level4_nodes[17].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[18].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[19].value);
            Assert.AreEqual(3, model.level4_nodes[20].value);
            Assert.AreEqual(23.45678m, model.level4_nodes[21].value);
            Assert.AreEqual(117.28380m, model.level4_nodes[22].value);
            Assert.AreEqual(67.28380m, model.level4_nodes[23].value);
            Assert.AreEqual(12.23456m, model.level4_nodes[24].value);
            Assert.AreEqual(3, model.level4_nodes[25].value);
            //验证第3层的值
            foreach (var node in model.level3_nodes)
                Assert.AreEqual(0, node.value);
            //验证第2层的值
            foreach (var node in model.level2_nodes)
                Assert.AreEqual(0, node.value);
            //验证第1层的值
            foreach (var node in model.level1_nodes)
                Assert.AreEqual(0, node.value);
        }

        [TestMethod()]
        public void SetLevel3UnitValueTest()
        {
            Model model = new Model();
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第3层数值
            mv.CalculateLevel4Values();
            mv.CalculateLevel3Values();
            
            //未裁剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = true;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel3UnitValue(model.level2_nodes);
            mv.SetLevel3UnitValue(model.level1_nodes);
            //验证第3层的值
            Assert.AreEqual(17.28380m / 12.23456m, model.level3_nodes[0].value);
            Assert.AreEqual(12.23456m / 23.45678m, model.level3_nodes[1].value);
            Assert.AreEqual(42.71615m / (12.23456m * 12.23456m - 12.23456m), model.level3_nodes[2].value);
            Assert.AreEqual((67.28380m + 92.71615m) / 12.23456m, model.level3_nodes[3].value);
            Assert.AreEqual(17.28380m / 12.23456m, model.level3_nodes[4].value);
            Assert.AreEqual(12.23456m / 23.45678m, model.level3_nodes[5].value);
            Assert.AreEqual((67.28380m * 67.28380m) / (23.45678m * 23.45678m), model.level3_nodes[6].value);
            Assert.AreEqual((117.28380m * 117.28380m) / (67.28380m * 67.28380m), model.level3_nodes[7].value);
            Assert.AreEqual(3 / 12.23456m, model.level3_nodes[8].value);
            Assert.AreEqual((117.28380m * 117.28380m) / (67.28380m * 67.28380m), model.level3_nodes[9].value);
            Assert.AreEqual(3 / 12.23456m, model.level3_nodes[10].value);
            Assert.AreEqual(12.23456m / 23.45678m, model.level3_nodes[11].value);
            Assert.AreEqual((67.28380m * 67.28380m) / (23.45678m * 23.45678m), model.level3_nodes[12].value);
            //验证第2层的值
            foreach (var node in model.level2_nodes)
                Assert.AreEqual(0, node.value);
            //验证第1层的值
            foreach (var node in model.level1_nodes)
                Assert.AreEqual(0, node.value);

            //裁剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = false;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel3UnitValue(model.level2_nodes);
            mv.SetLevel3UnitValue(model.level1_nodes);
            //验证第3层的值
            Assert.AreEqual(17.28380m / 12.23456m, model.level3_nodes[0].value);
            Assert.AreEqual(12.23456m / 23.45678m, model.level3_nodes[1].value);
            Assert.AreEqual(42.71615m / (12.23456m * 12.23456m - 12.23456m), model.level3_nodes[2].value);
            Assert.AreEqual((67.28380m + 92.71615m) / 12.23456m, model.level3_nodes[3].value);
            Assert.AreEqual(17.28380m / 12.23456m, model.level3_nodes[4].value);
            Assert.AreEqual(12.23456m / 23.45678m, model.level3_nodes[5].value);
            Assert.AreEqual((67.28380m * 67.28380m) / (23.45678m * 23.45678m), model.level3_nodes[6].value);
            Assert.AreEqual((117.28380m * 117.28380m) / (67.28380m * 67.28380m), model.level3_nodes[7].value);
            Assert.AreEqual(3 / 12.23456m, model.level3_nodes[8].value);
            Assert.AreEqual((117.28380m * 117.28380m) / (67.28380m * 67.28380m), model.level3_nodes[9].value);
            Assert.AreEqual(3 / 12.23456m, model.level3_nodes[10].value);
            //验证第2层的值
            foreach (var node in model.level2_nodes)
                Assert.AreEqual(0, node.value);
            //验证第1层的值
            foreach (var node in model.level1_nodes)
                Assert.AreEqual(0, node.value);
        }

        [TestMethod()]
        public void SetLevel2UnitValueTest()
        {

            //测试第2层
            //未修剪模型的情况
            Model model = new Model();
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第3层数值
            mv.CalculateLevel4Values();
            mv.CalculateLevel3Values();
            //创建模型
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = true;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel2UnitValue(model.level2_nodes);
            //验证数值
            Assert.AreEqual(-0.5814090208767396425967497017122, (double)model.level2_nodes[0].value, 0.0001);
            Assert.AreEqual(4.5493525993415009929712588253279, (double)model.level2_nodes[1].value, 0.0001);
            Assert.AreEqual(4.435102352522840320814015528183, (double)model.level2_nodes[2].value, 0.0001);
            Assert.AreEqual(4.37469421809111477997698989807, (double)model.level2_nodes[3].value, 0.0001);

            //修剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = false;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel2UnitValue(model.level2_nodes);
            //验证数值
            Assert.AreEqual(-0.5814090208767396425967497017122, (double)model.level2_nodes[0].value, 0.0001);
            Assert.AreEqual(4.5493525993415009929712588253279, (double)model.level2_nodes[1].value, 0.0001);
            Assert.AreEqual(4.435102352522840320814015528183, (double)model.level2_nodes[2].value, 0.0001);
        }

        [TestMethod()]
        public void SetLevel1UnitValueTest()
        {

            //测试第2层
            //未修剪模型的情况
            Model model = new Model();
            ModelValue mv = new ModelValue();
            SetModelValueSample(mv);
            //计算第3层数值
            mv.CalculateLevel4Values();
            mv.CalculateLevel3Values();
            //创建模型
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = true;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel2UnitValue(model.level2_nodes);
            mv.SetLevel1UnitValue(model.level1_nodes);
            //验证数值
            Assert.AreEqual(3.1944350372696791127913786374672, (double)model.level1_nodes[0].value, 0.0001);

            //修剪模型的情况
            model.CreateModel();
            GlobalData.GlobalData.globalData.if_assess_modularity = false;
            model.TrimModel();
            model.CalculateModelWeight();
            mv.SetLevel4UnitValue(model.level4_nodes);
            mv.SetLevel3UnitValue(model.level3_nodes);
            mv.SetLevel2UnitValue(model.level2_nodes);
            mv.SetLevel1UnitValue(model.level1_nodes);
            //验证数值
            Assert.AreEqual(2.8009873001760972650572709221841, (double)model.level1_nodes[0].value, 0.0001);
        }
    }
}