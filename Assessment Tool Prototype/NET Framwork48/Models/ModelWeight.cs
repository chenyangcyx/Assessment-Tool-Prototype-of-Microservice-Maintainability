using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    class ModelWeight
    {
        public const int NODE_AFFECT_GAIN = 1;
        public const int NODE_AFFECT_DAMAGE = 2;

        public void CreateModelNodeAffectDictionary(Dictionary<string,int> dic)
        {
            dic.Add(ModelName.LEVELNAME_QUALITYATTribute_1, NODE_AFFECT_GAIN);      //层1 Maintainability
            dic.Add(ModelName.LEVELNAME_ATTRIBUTE_1, NODE_AFFECT_GAIN);             //层2 Analyzability
            dic.Add(ModelName.LEVELNAME_ATTRIBUTE_2, NODE_AFFECT_GAIN);             //层2 Changeability
            dic.Add(ModelName.LEVELNAME_ATTRIBUTE_3, NODE_AFFECT_GAIN);             //层2 Stability
            dic.Add(ModelName.LEVELNAME_ATTRIBUTE_4, NODE_AFFECT_GAIN);             //层2 Modularity
            dic.Add(ModelName.LEVELNAME_PROPERTY_1, NODE_AFFECT_DAMAGE);            //层3 Coupling
            dic.Add(ModelName.LEVELNAME_PROPERTY_2, NODE_AFFECT_GAIN);              //层3 Cohesion
            dic.Add(ModelName.LEVELNAME_PROPERTY_3, NODE_AFFECT_DAMAGE);            //层3 Design Complexity
            dic.Add(ModelName.LEVELNAME_PROPERTY_4, NODE_AFFECT_DAMAGE);            //层3 System Size
            dic.Add(ModelName.LEVELNAME_PROPERTY_5, NODE_AFFECT_GAIN);              //层3 Service Granularity
            dic.Add(ModelName.LEVELNAME_PROPERTY_6, NODE_AFFECT_GAIN);              //层3 Parameter Granularity
            dic.Add(ModelName.LEVELNAME_PROPERTY_7, NODE_AFFECT_DAMAGE);            //层3 Service Loopback
            dic.Add(ModelName.LEVELNAME_METRIC_1, NODE_AFFECT_GAIN);                //层4 NS
            dic.Add(ModelName.LEVELNAME_METRIC_2, NODE_AFFECT_GAIN);                //层4 NDCS()
            dic.Add(ModelName.LEVELNAME_METRIC_3, NODE_AFFECT_GAIN);                //层4 NM
            dic.Add(ModelName.LEVELNAME_METRIC_4, NODE_AFFECT_GAIN);                //层4 NIS()
            dic.Add(ModelName.LEVELNAME_METRIC_5, NODE_AFFECT_GAIN);                //层4 NPI()
            dic.Add(ModelName.LEVELNAME_METRIC_6, NODE_AFFECT_GAIN);                //层4 NII()
            dic.Add(ModelName.LEVELNAME_METRIC_7, NODE_AFFECT_GAIN);                //层4 NMP()
            dic.Add(ModelName.LEVELNAME_METRIC_8, NODE_AFFECT_GAIN);                //层4 WISL()
        }

        //写入节点的增益/损害属性
        public void SetNodeGainORDamage(ModelNode node, Dictionary<string, int> dic)
        {
            int result;
            dic.TryGetValue(node.NodeName, out result);
            node.gain_or_damage = result;
        }

        //获取某一个节点下属的所有节点的增益/损害数
        public void CollectNodeGainORDamageNum(ModelNode node, out decimal gain_num, out decimal damage_num)
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

        //根据增益/损害数计算某一节点的权值
        public void CalculateWeight(ModelNode node, int gain_num, int damage_num, out decimal weight)
        {
            decimal ten = gain_num + damage_num;
            decimal gen = gain_num;
            decimal den = damage_num;
            weight = 0;
            //该节点为增益节点，计算GEW（Gain Elements' Weight）
            if (node.gain_or_damage == NODE_AFFECT_GAIN)
            {
                if (gain_num != 0 && damage_num == 0)
                    weight = 1 / gen;
                if (gain_num == 0 && damage_num != 0)
                    weight = 0;
                if (gain_num != 0 && damage_num != 0)
                    weight = (ten + 1) / (ten * gen);
            }
            //该结点为损害节点，计算DEW（Damage Elements' Weight）
            else
            {
                if (gain_num != 0 && damage_num == 0)
                    weight = -0;
                if (gain_num == 0 && damage_num != 0)
                    weight = -1 / (2 * den);
                if (gain_num != 0 && damage_num != 0)
                    weight = -1 / (ten * den);
            }
        }
    }
}
