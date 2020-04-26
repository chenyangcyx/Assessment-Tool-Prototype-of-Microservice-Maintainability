using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelValue
    {
        //Level 4//
        public Dictionary<int, string> Dic_NO_ServiceName;          //Dictionary: serial number-microservice name
        public Dictionary<string, int> Dic_ServiceName_NO;          //Dictionary: microservice name-serial number
        public Dictionary<int, string> Dic_NO_MessageName;          //Dictionary: serial number-message name
        public Dictionary<string, int> Dic_MessageName_NO;          //Dictionary: message name-serial number

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
            Dic_NO_MessageName = new Dictionary<int, string>();
            Dic_MessageName_NO = new Dictionary<string, int>();
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

        //get the total number of services
        public int GetTotalServiceNumber()
        {
            return Dic_NO_ServiceName.Count;
        }

        //calculate NDCS_TOTAL
        public void Calculate_NDCS_TOTAL()
        {
            NDCS_TOTAL = NDCS_NO_VALUE.Values.Sum();
        }

        //calculate NIS_TOTAL
        public void Calculate_NIS_TOTAL()
        {
            NIS_TOTAL = NIS_NO_VALUE.Values.Sum();
        }

        //calculate NPI_TOTAL
        public void Calculate_NPI_TOTAL()
        {
            NPI_TOTAL = NPI_NO_VALUE.Values.Sum();
        }

        //calculate NII_TOTAL
        public void Calculate_NII_TOTAL()
        {
            NII_TOTAL = NII_NO_VALUE.Values.Sum();
        }

        //calculate NMP_TOTAL
        public void Calculate_NMP_TOTAL()
        {
            NMP_TOTAL = NMP_NO_VALUE.Values.Sum();
        }

        //calculate WISL_TOTAL
        public void Calculate_WISL_TOTAL()
        {
            WISL_TOTAL = WISL_NO_VALUE.Values.Sum();
        }

        //calculate all values of Level 4 (summation)
        public void CalculateLevel4Values()
        {
            Calculate_NDCS_TOTAL();
            Calculate_NIS_TOTAL();
            Calculate_NPI_TOTAL();
            Calculate_NII_TOTAL();
            Calculate_NMP_TOTAL();
            Calculate_WISL_TOTAL();
        }
        //Level 4//


        //Level 3//
        public decimal Coupling;
        public decimal Cohesion;
        public decimal Design_Complexity;
        public decimal System_Size;
        public decimal Service_Granularity;
        public decimal Parameter_Granularity;
        public decimal Service_Loopback;

        //calculate the value of Coupling
        public void CalculateCoupling()
        {
            Coupling = NDCS_TOTAL / NS;
        }

        //calculate the value of Cohesion
        public void CalculateCohesion()
        {
            Cohesion = NS / NM;
        }

        //calculate the value of Design Complexity
        public void CalculateDesign_Complexity()
        {
            Design_Complexity = NIS_TOTAL / (NS * NS - NS);
        }

        //calculate the value of System Size
        public void CalculateSystem_Size()
        {
            System_Size = (NPI_TOTAL + NII_TOTAL) / NS;
        }

        //calculate the value of Service Granularity
        public void CalculateService_Granularity()
        {
            Service_Granularity = (NPI_TOTAL * NPI_TOTAL) / (NM * NM);
        }

        //calculate the value of Parameter Granularity
        public void CalculateParameter_Granularity()
        {
            Parameter_Granularity = (NMP_TOTAL * NMP_TOTAL) / (NPI_TOTAL * NPI_TOTAL);
        }

        //calculate the value of Service Loopback
        public void CalculateService_Loopback()
        {
            Service_Loopback = WISL_TOTAL / NS;
        }

        //calculate all values of Level 3
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
        //Level 3//

        //other functions//
        //set the values of all elements of Level 4
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

        //set all element values of Level 3
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

        //set all element values of Level 2
        //use the weights and values of Level 3 nodes for weighted calculations
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

        //set all element values of Level 1
        //use the weights and values of Level 2 nodes for weighted calculations
        public void SetLevel1UnitValue(List<ModelNode> level_node)
        {
            if (level_node[0].NodeLevel != 1)
                return;
            decimal sum = 0;
            foreach (ModelNode node_next in level_node[0].nextlevel)
                sum += node_next.weight * node_next.value;
            level_node[0].value = sum;
        }
        //other functions//
    }
}
