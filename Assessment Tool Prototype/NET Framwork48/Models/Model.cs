using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    class Model
    {
        //Level4的Metric备注字典
        Dictionary<string, string> level4_metric_detail;

        //创建Metric备注字典
        public void CreateLevel4MetricDictionary()
        {
            level4_metric_detail = new Dictionary<string, string>();
            new ModelName().CreateModelDictionary(level4_metric_detail);
        }
    }
}
