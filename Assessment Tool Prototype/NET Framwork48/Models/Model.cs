using NET_Framwork48.GlobalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class Model
    {
        //模型的根节点
        public ModelNode root_node;
        //模型的各层节点列表
        public List<ModelNode> level1_nodes, level2_nodes, level3_nodes, level4_nodes;
        //模型的必用操作项
        public ModelLink modelLink;
        public ModelName modelName;
        public ModelValue modelValue;
        public ModelWeight modelWeight;
        //创建模型
        public void CreateModel()
        {
            modelLink = new ModelLink();
            modelName = new ModelName();
            modelValue = new ModelValue();
            modelWeight = new ModelWeight();
            level1_nodes = new List<ModelNode>();
            level2_nodes = new List<ModelNode>();
            level3_nodes = new List<ModelNode>();
            level4_nodes = new List<ModelNode>();
            //创建第一层
            root_node = new ModelNode();     //第1层节点
            level1_nodes.Add(root_node);
            modelName.SetNodeName(root_node, modelLink.LEVEL1_UNITS);     //设置节点名称
            modelWeight.SetNodeGainORDamage(root_node);
            //创建第二层
            for(int i=0;i<modelLink.LEVEL1_LINK_2_NUM;i++)
            {
                ModelNode node_temp2 = new ModelNode();     //第2层节点
                level2_nodes.Add(node_temp2);
                modelName.SetNodeName(node_temp2, modelLink.LEVEL1_LINK_2_UNITS[i]);
                modelWeight.SetNodeGainORDamage(node_temp2);
                for(int j = 0; j < modelLink.LEVEL2_LINK_3_NUM[i]; j++)
                {
                    ModelNode node_temp3 = new ModelNode();     //第3层节点
                    level3_nodes.Add(node_temp3);
                    modelName.SetNodeName(node_temp3, modelLink.LEVEL2_LINK_3_UNITS[i][j]);
                    modelWeight.SetNodeGainORDamage(node_temp3);
                    for(int k=0;k<modelLink.LEVEL3_LINK_4_NUM[i][j];k++)
                    {
                        ModelNode node_temp4 = new ModelNode();     //第4层节点
                        level4_nodes.Add(node_temp4);
                        modelName.SetNodeName(node_temp4, modelLink.LEVEL3_LINK_4_UNITS[i][j][k]);
                        modelWeight.SetNodeGainORDamage(node_temp4);
                        node_temp4.prelevel = node_temp3;
                        node_temp3.nextlevel.Add(node_temp4);
                    }
                    node_temp3.prelevel = node_temp2;
                    node_temp2.nextlevel.Add(node_temp3);
                }
                node_temp2.prelevel = root_node;
                root_node.nextlevel.Add(node_temp2);
            }
        }

        ////模型的修剪
        //public void TrimModel()
        //{
        //    //判断是否评估Modularity
        //    //如果不评估
        //    if (!global.if_assess_modularity)
        //    {
        //        List<ModelNode> delete_level2_nodes = new List<ModelNode>();
        //        List<ModelNode> delete_level3_nodes = new List<ModelNode>();
        //        List<ModelNode> delete_level4_nodes = new List<ModelNode>();
        //        Queue<ModelNode> all_delete_nodes_queue = new Queue<ModelNode>();
        //        //寻找level2的可选attribute
        //        ModelNode delete2 = null;
        //        foreach (ModelNode node in level2_nodes)
        //            if (node.NodeName.Equals(ModelName.LEVELNAME_ATTRIBUTE_OPTIONAL))
        //                delete2 = node;
        //        //记录所有的与删除节点相关的节点
        //        all_delete_nodes_queue.Enqueue(delete2);
        //        while (all_delete_nodes_queue.Count > 0)
        //        {
        //            ModelNode tmp = all_delete_nodes_queue.Dequeue();
        //            //将相关的节点的引用放入相应的列表
        //            if (tmp.NodeLevel == 2)
        //                delete_level2_nodes.Add(tmp);
        //            if (tmp.NodeLevel == 3)
        //                delete_level3_nodes.Add(tmp);
        //            if (tmp.NodeLevel == 4)
        //                delete_level4_nodes.Add(tmp);
        //            foreach (ModelNode node in tmp.nextlevel)
        //                all_delete_nodes_queue.Enqueue(node);
        //        }
        //        //从模型中删除相应的节点
        //        root_node.nextlevel.Remove(delete2);
        //        foreach (ModelNode node in delete_level2_nodes)
        //            level2_nodes.Remove(node);
        //        foreach (ModelNode node in delete_level3_nodes)
        //            level3_nodes.Remove(node);
        //        foreach (ModelNode node in delete_level4_nodes)
        //            level4_nodes.Remove(node);
        //    }
        //}

        //模型的权值计算
        public void CalculateModelWeight()
        {
            modelWeight = new ModelWeight();
            //计算第一层的权值
            foreach (var node in level1_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            //计算第二层的权值
            foreach (var node in level2_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            //计算第三层的权值
            foreach (var node in level3_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            //计算第四层的权值
            foreach (var node in level4_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
        }

        //模型的节点值计算
        public void CalculateModelValue()
        {
            modelValue.CalculateLevel4Values();
            modelValue.CalculateLevel3Values();
            modelValue.SetLevel4UnitValue(level4_nodes);
            modelValue.SetLevel3UnitValue(level3_nodes);
            modelValue.SetLevel2UnitValue(level2_nodes);
            modelValue.SetLevel1UnitValue(level1_nodes);
        }
    }
}
