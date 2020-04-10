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
    public class ModelValueTests
    {
        [TestMethod()]
        public void CalculateLevel4ValuesTest()
        {
            //构建Model的Dictionary
            ModelValue mv = new ModelValue();
            //添加服务名字
            mv.ServiceNames.Add(1, "Service 1");
            mv.ServiceNames.Add(2, "Service 2");
            mv.ServiceNames.Add(3, "Service 3");
            mv.ServiceNames.Add(4, "Service 4");
            mv.ServiceNames.Add(5, "Service 5");
            //添加数值
            mv.NS = 12.23456m;
            mv.NDCS_NO_VALUE.Add(1, 1.23456m);
            mv.NDCS_NO_VALUE.Add(2, 2.34567m);
            mv.NDCS_NO_VALUE.Add(3, 3.45678m);
            mv.NDCS_NO_VALUE.Add(4, 4.56789m);
            mv.NDCS_NO_VALUE.Add(5, 5.67890m);
            mv.NM = 23.45678m;
            mv.NIS_NO_VALUE.Add(1, 6.78901m);
            mv.NIS_NO_VALUE.Add(2, 7.89012m);
            mv.NIS_NO_VALUE.Add(3, 8.90123m);
            mv.NIS_NO_VALUE.Add(4, 9.01234m);
            mv.NIS_NO_VALUE.Add(5, 10.12345m);
            mv.NPI_NO_VALUE.Add(1, 11.23456m);
            mv.NPI_NO_VALUE.Add(2, 12.34567m);
            mv.NPI_NO_VALUE.Add(3, 13.45678m);
            mv.NPI_NO_VALUE.Add(4, 14.56789m);
            mv.NPI_NO_VALUE.Add(5, 15.67890m);
            mv.NII_NO_VALUE.Add(1, 16.78901m);
            mv.NII_NO_VALUE.Add(2, 17.89012m);
            mv.NII_NO_VALUE.Add(3, 18.90123m);
            mv.NII_NO_VALUE.Add(4, 19.01234m);
            mv.NII_NO_VALUE.Add(5, 20.12345m);
            mv.NMP_NO_VALUE.Add(1, 21.23456m);
            mv.NMP_NO_VALUE.Add(2, 22.34567m);
            mv.NMP_NO_VALUE.Add(3, 23.45678m);
            mv.NMP_NO_VALUE.Add(4, 24.56789m);
            mv.NMP_NO_VALUE.Add(5, 25.67890m);
            mv.WISL_NO_VALUE.Add(1, 1);
            mv.WISL_NO_VALUE.Add(2, 0);
            mv.WISL_NO_VALUE.Add(3, 1);
            mv.WISL_NO_VALUE.Add(4, 1);
            mv.WISL_NO_VALUE.Add(5, 0);
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
            //添加服务名字
            mv.ServiceNames.Add(1, "Service 1");
            mv.ServiceNames.Add(2, "Service 2");
            mv.ServiceNames.Add(3, "Service 3");
            mv.ServiceNames.Add(4, "Service 4");
            mv.ServiceNames.Add(5, "Service 5");
            //添加数值
            mv.NS = 12.23456m;
            mv.NDCS_NO_VALUE.Add(1, 1.23456m);
            mv.NDCS_NO_VALUE.Add(2, 2.34567m);
            mv.NDCS_NO_VALUE.Add(3, 3.45678m);
            mv.NDCS_NO_VALUE.Add(4, 4.56789m);
            mv.NDCS_NO_VALUE.Add(5, 5.67890m);
            mv.NM = 23.45678m;
            mv.NIS_NO_VALUE.Add(1, 6.78901m);
            mv.NIS_NO_VALUE.Add(2, 7.89012m);
            mv.NIS_NO_VALUE.Add(3, 8.90123m);
            mv.NIS_NO_VALUE.Add(4, 9.01234m);
            mv.NIS_NO_VALUE.Add(5, 10.12345m);
            mv.NPI_NO_VALUE.Add(1, 11.23456m);
            mv.NPI_NO_VALUE.Add(2, 12.34567m);
            mv.NPI_NO_VALUE.Add(3, 13.45678m);
            mv.NPI_NO_VALUE.Add(4, 14.56789m);
            mv.NPI_NO_VALUE.Add(5, 15.67890m);
            mv.NII_NO_VALUE.Add(1, 16.78901m);
            mv.NII_NO_VALUE.Add(2, 17.89012m);
            mv.NII_NO_VALUE.Add(3, 18.90123m);
            mv.NII_NO_VALUE.Add(4, 19.01234m);
            mv.NII_NO_VALUE.Add(5, 20.12345m);
            mv.NMP_NO_VALUE.Add(1, 21.23456m);
            mv.NMP_NO_VALUE.Add(2, 22.34567m);
            mv.NMP_NO_VALUE.Add(3, 23.45678m);
            mv.NMP_NO_VALUE.Add(4, 24.56789m);
            mv.NMP_NO_VALUE.Add(5, 25.67890m);
            mv.WISL_NO_VALUE.Add(1, 1);
            mv.WISL_NO_VALUE.Add(2, 0);
            mv.WISL_NO_VALUE.Add(3, 1);
            mv.WISL_NO_VALUE.Add(4, 1);
            mv.WISL_NO_VALUE.Add(5, 0);
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
    }
}