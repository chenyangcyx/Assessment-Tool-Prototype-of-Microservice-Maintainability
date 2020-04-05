using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelWeight
    {
        public const int NODE_AFFECT_GAIN = 1;              //增益效果标记常量
        public const int NODE_AFFECT_DAMAGE = 2;            //损害效果标记常量

        public const int WEIGHT_VALUE_ROUND = 5;            //权值计算的保留小数

        //节点增益/损害效果字典
        public Dictionary<string, int> node_affect_dictionary = new Dictionary<string, int>();

        public ModelWeight()
        {
            CreateModelNodeAffectDictionary();
        }

        public void CreateModelNodeAffectDictionary()
        {
            node_affect_dictionary.Add(ModelName.LEVELNAME_QUALITYATTRIBUTE_1, NODE_AFFECT_GAIN);      //层1 Maintainability
            node_affect_dictionary.Add(ModelName.LEVELNAME_ATTRIBUTE_1, NODE_AFFECT_GAIN);             //层2 Analyzability
            node_affect_dictionary.Add(ModelName.LEVELNAME_ATTRIBUTE_2, NODE_AFFECT_GAIN);             //层2 Changeability
            node_affect_dictionary.Add(ModelName.LEVELNAME_ATTRIBUTE_3, NODE_AFFECT_GAIN);             //层2 Stability
            node_affect_dictionary.Add(ModelName.LEVELNAME_ATTRIBUTE_4, NODE_AFFECT_GAIN);             //层2 Modularity
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_1, NODE_AFFECT_DAMAGE);            //层3 Coupling
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_2, NODE_AFFECT_GAIN);              //层3 Cohesion
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_3, NODE_AFFECT_DAMAGE);            //层3 Design Complexity
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_4, NODE_AFFECT_DAMAGE);            //层3 System Size
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_5, NODE_AFFECT_GAIN);              //层3 Service Granularity
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_6, NODE_AFFECT_GAIN);              //层3 Parameter Granularity
            node_affect_dictionary.Add(ModelName.LEVELNAME_PROPERTY_7, NODE_AFFECT_DAMAGE);            //层3 Service Loopback
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_1, NODE_AFFECT_GAIN);                //层4 NS
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_2, NODE_AFFECT_GAIN);                //层4 NDCS()
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_3, NODE_AFFECT_GAIN);                //层4 NM
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_4, NODE_AFFECT_GAIN);                //层4 NIS()
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_5, NODE_AFFECT_GAIN);                //层4 NPI()
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_6, NODE_AFFECT_GAIN);                //层4 NII()
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_7, NODE_AFFECT_GAIN);                //层4 NMP()
            node_affect_dictionary.Add(ModelName.LEVELNAME_METRIC_8, NODE_AFFECT_GAIN);                //层4 WISL()
        }

        //写入节点的增益/损害属性
        public void SetNodeGainORDamage(ModelNode node)
        {
            int result;
            node_affect_dictionary.TryGetValue(node.NodeName, out result);
            node.gain_or_damage = result;
        }

        //获取某一个节点下属的所有节点的增益/损害数
        public void CollectNodeNextLevelGainORDamageNum(ModelNode node, out int gain_num, out int damage_num)
        {
            gain_num = 0;
            damage_num = 0;
            foreach (ModelNode no in node.nextlevel)
            {
                if (no.gain_or_damage == NODE_AFFECT_GAIN)
                    gain_num++;
                else
                    damage_num++;
            }
        }

        //设置某一节点下属节点的权值
        public void CalculateNodeNextLevelWeight(ModelNode node)
        {
            if (node.NodeLevel >= 3)
                return;
            int gain_num, damage_num;
            CollectNodeNextLevelGainORDamageNum(node, out gain_num, out damage_num);
            decimal ten = gain_num + damage_num;
            decimal gen = gain_num;
            decimal den = damage_num;
            decimal gew = 0, dew = 0;
            if (gain_num == 0 && damage_num == 0)
            {
                gew = 0;
                dew = 0;
            }
            if (gain_num != 0 && damage_num == 0)
            {
                gew = 1 / gen;
                dew = -0;
            }
            if (gain_num == 0 && damage_num != 0)
            {
                gew = 0;
                dew = -1 / (2 * den);
            }
            if (gain_num != 0 && damage_num != 0)
            {
                gew = (ten + 1) / (ten * gen);
                dew = -1 / (ten * den);
            }
            foreach(ModelNode tmp in node.nextlevel)
            {
                if (tmp.gain_or_damage == NODE_AFFECT_GAIN)
                    tmp.weight = Math.Round(gew, WEIGHT_VALUE_ROUND);
                else
                    tmp.weight = Math.Round(dew, WEIGHT_VALUE_ROUND);
            }
        }
    }
}
