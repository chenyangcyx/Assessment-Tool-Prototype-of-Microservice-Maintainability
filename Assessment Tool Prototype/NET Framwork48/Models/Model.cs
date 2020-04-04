﻿using NET_Framwork48.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class Model
    {
        //Level4的Metric备注字典
        public Dictionary<string, string> level4_metric_detail;
        //模型的根节点
        public ModelNode root_node;
        //模型的各层节点列表
        public List<ModelNode> level1_nodes, level2_nodes, level3_nodes, level4_nodes;


        public Model()
        {
            CreateLevel4MetricDictionary();
        }

        //创建Metric备注字典
        public void CreateLevel4MetricDictionary()
        {
            level4_metric_detail = new Dictionary<string, string>();
            new ModelName().CreateModelDictionary(level4_metric_detail);
        }

        //创建模型
        public void CreateModel()
        {
            ModelLink ml = new ModelLink();
            ModelName mn = new ModelName();
            ModelWeight mw = new ModelWeight();
            level1_nodes = new List<ModelNode>();
            level2_nodes = new List<ModelNode>();
            level3_nodes = new List<ModelNode>();
            level4_nodes = new List<ModelNode>();
            //创建第一层
            root_node = new ModelNode();     //第1层节点
            level1_nodes.Add(root_node);
            mn.SetNodeName(root_node, ml.LEVEL1_UNITS);     //设置节点名称
            //创建第二层
            for(int i=0;i<ml.LEVEL1_LINK_2_NUM;i++)
            {
                ModelNode node_temp2 = new ModelNode();     //第2层节点
                level2_nodes.Add(node_temp2);
                mn.SetNodeName(node_temp2, ml.LEVEL1_LINK_2_UNITS[i]);
                for(int j = 0; j < ml.LEVEL2_LINK_3_NUM[i]; j++)
                {
                    ModelNode node_temp3 = new ModelNode();     //第3层节点
                    level3_nodes.Add(node_temp3);
                    mn.SetNodeName(node_temp3, ml.LEVEL2_LINK_3_UNITS[i][j]);
                    for(int k=0;k<ml.LEVEL3_LINK_4_NUM[i][j];k++)
                    {
                        ModelNode node_temp4 = new ModelNode();     //第4层节点
                        level4_nodes.Add(node_temp4);
                        mn.SetNodeName(node_temp4, ml.LEVEL3_LINK_4_UNITS[i][j][k]);
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

        //模型的修剪
        public void TrimModel()
        {
            //判断是否评估Modularity
            OverAllData all = OverAllData.allData;
            //如果不评估
            if (!all.if_assess_modularity)
            {
                List<ModelNode> delete_level2_nodes = new List<ModelNode>();
                List<ModelNode> delete_level3_nodes = new List<ModelNode>();
                List<ModelNode> delete_level4_nodes = new List<ModelNode>();
                Queue<ModelNode> all_delete_nodes_queue = new Queue<ModelNode>();
                //寻找level2的可选attribute
                ModelNode delete2 = null;
                foreach (ModelNode node in level2_nodes)
                    if (node.NodeName.Equals(ModelName.LEVELNAME_ATTRIBUTE_OPTIONAL))
                        delete2 = node;
                //记录所有的与删除节点相关的节点
                all_delete_nodes_queue.Enqueue(delete2);
                while (all_delete_nodes_queue.Count > 0)
                {
                    ModelNode tmp = all_delete_nodes_queue.Dequeue();
                    //将相关的节点的引用放入相应的列表
                    if (tmp.NodeLevel == 2)
                        delete_level2_nodes.Add(tmp);
                    if (tmp.NodeLevel == 3)
                        delete_level3_nodes.Add(tmp);
                    if (tmp.NodeLevel == 4)
                        delete_level4_nodes.Add(tmp);
                    foreach (ModelNode node in tmp.nextlevel)
                        all_delete_nodes_queue.Enqueue(node);
                }
                //从模型中删除相应的节点
                root_node.nextlevel.Remove(delete2);
                foreach (ModelNode node in delete_level2_nodes)
                    level2_nodes.Remove(node);
                foreach (ModelNode node in delete_level3_nodes)
                    level3_nodes.Remove(node);
                foreach (ModelNode node in delete_level4_nodes)
                    level4_nodes.Remove(node);
            }
        }
    }
}
