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
        Dictionary<string, string> level4_metric_detail;
        //模型的根节点
        public static ModelNode root_node;
        //模型的各层节点列表
        public List<ModelNode> level1_nodes = new List<ModelNode>();


        public Model()
        {
            root_node = new ModelNode();
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
        }
    }
}
