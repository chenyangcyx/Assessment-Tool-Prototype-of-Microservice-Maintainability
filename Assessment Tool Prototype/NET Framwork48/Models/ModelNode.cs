using System;
using System.Collections.Generic;

namespace NET_Framwork48.Models
{
    public class ModelNode
    {
        public string NodeName { get; set; }                            //节点名称
        public string NodeName_Detail { get; set; }                     //节点名称注释
        public int NodeLevel { get; set; }                              //节点层级
        public string NodeLevelName { get; set; }                       //节点层级名称
        public List<ModelNode> nextlevel;                               //下一层的节点引用
        public ModelNode prelevel;                                      //上一层的相连节点
        public decimal weight { get; set; }                             //权值
        public decimal value { get; set; }                              //计算数值
        public int gain_or_damage { get; set; }                         //增益/损害属性

        public ModelNode()
        {
            ResetNode();
        }

        public void ResetNode()
        {
            NodeName = "";
            NodeName_Detail = "";
            NodeLevel = -1;
            NodeLevelName = "";
            nextlevel = new List<ModelNode>();
            prelevel = null;
            weight = 0;
            value = 0;
            gain_or_damage = ModelWeight.NODE_AFFECT_GAIN + ModelWeight.NODE_AFFECT_DAMAGE;
        }

        public ModelNode(string nodename, string nodename_detail, int nodelevel, string nodelevelname)
        {
            NodeName = nodename;
            NodeName_Detail = nodename_detail;
            NodeLevel = nodelevel;
            NodeLevelName = nodelevelname;
        }
    }
}
