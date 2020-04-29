using System.Collections.Generic;

namespace NET_Framwork48.Models
{
    public class Model
    {
        // the root node of the model
        public ModelNode root_node;
        // list of nodes in each level of the model
        public List<ModelNode> level1_nodes, level2_nodes, level3_nodes, level4_nodes;
        // required operation items of the model
        public ModelLink modelLink;
        public ModelName modelName;
        public ModelValue modelValue;
        public ModelWeight modelWeight;
        // create model
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
            // create Level 1
            root_node = new ModelNode();                                    // level 1 nodes
            level1_nodes.Add(root_node);
            modelName.SetNodeName(root_node, modelLink.LEVEL1_UNITS);       // set node names
            modelWeight.SetNodeGainORDamage(root_node);
            // create Level 2
            for (int i = 0; i < modelLink.LEVEL1_LINK_2_NUM; i++)
            {
                ModelNode node_temp2 = new ModelNode();                     // level 2 nodes
                level2_nodes.Add(node_temp2);
                modelName.SetNodeName(node_temp2, modelLink.LEVEL1_LINK_2_UNITS[i]);
                modelWeight.SetNodeGainORDamage(node_temp2);
                for (int j = 0; j < modelLink.LEVEL2_LINK_3_NUM[i]; j++)
                {
                    ModelNode node_temp3 = new ModelNode();                 // level 3 nodes
                    level3_nodes.Add(node_temp3);
                    modelName.SetNodeName(node_temp3, modelLink.LEVEL2_LINK_3_UNITS[i][j]);
                    modelWeight.SetNodeGainORDamage(node_temp3);
                    for (int k = 0; k < modelLink.LEVEL3_LINK_4_NUM[i][j]; k++)
                    {
                        ModelNode node_temp4 = new ModelNode();             // level 4 nodes
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

        // model weight calculation
        public void CalculateModelWeight()
        {
            modelWeight = new ModelWeight();
            // calculate the weight of Level 1
            foreach (var node in level1_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            // calculate the weight of Level 2
            foreach (var node in level2_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            // calculate the weight of Level 3
            foreach (var node in level3_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
            // calculate the weight of Level 4
            foreach (var node in level4_nodes)
                modelWeight.CalculateNodeNextLevelWeight(node);
        }

        // model node value calculation
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
