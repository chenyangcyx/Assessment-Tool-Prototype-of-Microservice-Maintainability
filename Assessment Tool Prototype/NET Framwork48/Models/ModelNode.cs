using System.Collections.Generic;

namespace NET_Framwork48.Models
{
    public class ModelNode
    {
        public string NodeName { get; set; }                            // Node Name
        public string NodeName_Detail { get; set; }                     // Node Name Detail
        public int NodeLevel { get; set; }                              // Node Level
        public string NodeLevelName { get; set; }                       // Node Level Name
        public List<ModelNode> nextlevel;                               // Node reference of next level
        public ModelNode prelevel;                                      // the connected node of the previous level
        public decimal weight { get; set; }                             // weight
        public const int WEIGHT_NONE = 1;                               // initial weight value
        public decimal value { get; set; }                              // calculated value
        public int gain_or_damage { get; set; }                         // gain or damage attribute

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
            weight = WEIGHT_NONE;
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
