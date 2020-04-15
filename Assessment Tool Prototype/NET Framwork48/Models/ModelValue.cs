using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelValue
    {
        //**第4层**//
        public Dictionary<int, string> Dic_NO_ServiceName;          //字典：序号-微服务名字
        public Dictionary<string, int> Dic_ServiceName_NO;          //字典：微服务名字-序号

        public decimal NS { get; set; }
        public decimal NDCS_TOTAL { get; set; }
        public Dictionary<int, decimal> NDCS_NO_VALUE;
        public decimal NM { get; set; }
        public decimal NIS_TOTAL { get; set; }
        public Dictionary<int, decimal> NIS_NO_VALUE;
        public decimal NPI_TOTAL { get; set; }
        public Dictionary<int, decimal> NPI_NO_VALUE;
        public decimal NII_TOTAL { get; set; }
        public Dictionary<int, decimal> NII_NO_VALUE;
        public decimal NMP_TOTAL { get; set; }
        public Dictionary<int, decimal> NMP_NO_VALUE;
        public decimal WISL_TOTAL { get; set; }
        public Dictionary<int, decimal> WISL_NO_VALUE;

        public ModelValue()
        {
            Dic_NO_ServiceName = new Dictionary<int, string>();
            Dic_ServiceName_NO = new Dictionary<string, int>();
            NDCS_NO_VALUE = new Dictionary<int, decimal>();
            NIS_NO_VALUE = new Dictionary<int, decimal>();
            NPI_NO_VALUE = new Dictionary<int, decimal>();
            NII_NO_VALUE = new Dictionary<int, decimal>();
            NMP_NO_VALUE = new Dictionary<int, decimal>();
            WISL_NO_VALUE = new Dictionary<int, decimal>();
            NS = 0;
            NDCS_TOTAL = 0;
            NM = 0;
            NIS_TOTAL = 0;
            NPI_TOTAL = 0;
            NII_TOTAL = 0;
            NMP_TOTAL = 0;
            WISL_TOTAL = 0;
            Coupling = 0;
            Cohesion = 0;
            Design_Complexity = 0;
            System_Size = 0;
            Service_Granularity = 0;
            Parameter_Granularity = 0;
            Service_Loopback = 0;
        }

        //获取总的Service的数量
        public int GetTotalServiceNumber()
        {
            return Dic_NO_ServiceName.Count;
        }

        //计算NDCS_TOTAL
        public void Calculate_NDCS_TOTAL()
        {
            NDCS_TOTAL = NDCS_NO_VALUE.Values.Sum();
        }

        //计算NIS_TOTAL
        public void Calculate_NIS_TOTAL()
        {
            NIS_TOTAL = NIS_NO_VALUE.Values.Sum();
        }

        //计算NPI_TOTAL
        public void Calculate_NPI_TOTAL()
        {
            NPI_TOTAL = NPI_NO_VALUE.Values.Sum();
        }

        //计算NII_TOTAL
        public void Calculate_NII_TOTAL()
        {
            NII_TOTAL = NII_NO_VALUE.Values.Sum();
        }

        //计算NMP_TOTAL
        public void Calculate_NMP_TOTAL()
        {
            NMP_TOTAL = NMP_NO_VALUE.Values.Sum();
        }

        //计算WISL_TOTAL
        public void Calculate_WISL_TOTAL()
        {
            WISL_TOTAL = WISL_NO_VALUE.Values.Sum();
        }

        //计算第4层所有值（求和值）
        public void CalculateLevel4Values()
        {
            Calculate_NDCS_TOTAL();
            Calculate_NIS_TOTAL();
            Calculate_NPI_TOTAL();
            Calculate_NII_TOTAL();
            Calculate_NMP_TOTAL();
            Calculate_WISL_TOTAL();
        }
        //**第4层**//


        //**第3层**//
        public decimal Coupling;
        public decimal Cohesion;
        public decimal Design_Complexity;
        public decimal System_Size;
        public decimal Service_Granularity;
        public decimal Parameter_Granularity;
        public decimal Service_Loopback;

        //计算Coupling的值
        public void CalculateCoupling()
        {
            Coupling = NDCS_TOTAL / NS;
        }

        //计算Cohesion的值
        public void CalculateCohesion()
        {
            Cohesion = NS / NM;
        }

        //计算Design Complexity的值
        public void CalculateDesign_Complexity()
        {
            Design_Complexity = NIS_TOTAL / (NS * NS - NS);
        }

        //计算System Size的值
        public void CalculateSystem_Size()
        {
            System_Size = (NPI_TOTAL + NII_TOTAL) / NS;
        }

        //计算Service Granularity的值
        public void CalculateService_Granularity()
        {
            Service_Granularity = (NPI_TOTAL * NPI_TOTAL) / (NM * NM);
        }

        //计算Parameter Granularity的值
        public void CalculateParameter_Granularity()
        {
            Parameter_Granularity = (NMP_TOTAL * NMP_TOTAL) / (NPI_TOTAL * NPI_TOTAL);
        }

        //计算Service Loopback的值
        public void CalculateService_Loopback()
        {
            Service_Loopback = WISL_TOTAL / NS;
        }

        //计算第3层所有值
        public void CalculateLevel3Values()
        {
            CalculateCoupling();
            CalculateCohesion();
            CalculateDesign_Complexity();
            CalculateSystem_Size();
            CalculateService_Granularity();
            CalculateParameter_Granularity();
            CalculateService_Loopback();
        }
        //**第3层**//

        //**其他功能**//
        //设置第4层的所有元素的值
        public void SetLevel4UnitValue(List<ModelNode> level_nodes)
        {
            if (level_nodes[0].NodeLevel != 4)
                return;
            foreach (ModelNode node in level_nodes)
            {
                switch (node.NodeName)
                {
                    case ModelName.LEVELNAME_METRIC_1:
                        node.value = NS;
                        break;
                    case ModelName.LEVELNAME_METRIC_2:
                        node.value = NDCS_TOTAL;
                        break;
                    case ModelName.LEVELNAME_METRIC_3:
                        node.value = NM;
                        break;
                    case ModelName.LEVELNAME_METRIC_4:
                        node.value = NIS_TOTAL;
                        break;
                    case ModelName.LEVELNAME_METRIC_5:
                        node.value = NPI_TOTAL;
                        break;
                    case ModelName.LEVELNAME_METRIC_6:
                        node.value = NII_TOTAL;
                        break;
                    case ModelName.LEVELNAME_METRIC_7:
                        node.value = NMP_TOTAL;
                        break;
                    case ModelName.LEVELNAME_METRIC_8:
                        node.value = WISL_TOTAL;
                        break;
                }
            }
        }

        //设置第3层的所有元素值
        public void SetLevel3UnitValue(List<ModelNode> level_nodes)
        {
            if (level_nodes[0].NodeLevel != 3)
                return;
            foreach (ModelNode node in level_nodes)
            {
                switch (node.NodeName)
                {
                    case ModelName.LEVELNAME_PROPERTY_1:
                        node.value = Coupling;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_2:
                        node.value = Cohesion;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_3:
                        node.value = Design_Complexity;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_4:
                        node.value = System_Size;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_5:
                        node.value = Service_Granularity;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_6:
                        node.value = Parameter_Granularity;
                        break;
                    case ModelName.LEVELNAME_PROPERTY_7:
                        node.value = Service_Loopback;
                        break;
                }
            }
        }

        //设置第2层的所有元素值
        //使用第3层节点的权值与值进行加权计算
        public void SetLevel2UnitValue(List<ModelNode> level_node)
        {
            if (level_node[0].NodeLevel != 2)
                return;
            foreach (ModelNode node in level_node)
            {
                decimal sum = 0;
                foreach (ModelNode node_next in node.nextlevel)
                    sum += node_next.weight * node_next.value;
                node.value = sum;
            }
        }

        //设置第1层的所有元素值
        //使用第2层节点的权值与值进行加权计算
        public void SetLevel1UnitValue(List<ModelNode> level_node)
        {
            if (level_node[0].NodeLevel != 1)
                return;
            decimal sum = 0;
            foreach (ModelNode node_next in level_node[0].nextlevel)
                sum += node_next.weight * node_next.value;
            level_node[0].value = sum;
        }
        //**其他功能**//
    }
}
