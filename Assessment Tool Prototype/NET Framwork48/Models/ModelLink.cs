using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelLink
    {
        public const int LEVEL1_UNITNUM = 1;           //层1的元素数量（不重复）
        public const int LEVEL2_UNITNUM = 4;           //层2的元素数量（不重复）
        public const int LEVEL3_UNITNUM = 7;           //层3的元素数量（不重复）
        public const int LEVEL4_UNITNUM = 8;           //层4的元素数量（不重复）

        //层1的元素个数
        public int LEVEL1_LINK_1_NUM = 1;
        //层1连接到层2的元素个数
        public int LEVEL1_LINK_2_NUM = 4;
        //层2连接到层3的元素个数
        public int[] LEVEL2_LINK_3_NUM = new int[4]{ 4, 5, 2, 2 };
        //层3连接到层4的元素个数
        public int[][] LEVEL3_LINK_4_NUM = { 
            new int[4]{ 2, 2, 2, 3 }, 
            new int[5]{ 2, 2, 3, 3, 2 },
            new int[2]{ 3, 2 },
            new int[2]{ 2, 3 } };

        public const int LEVEL1_TOTAL_NUM = 1;          //层1的节点个数（重复）
        public const int LEVEL2_TOTAL_NUM = 4;          //层2的节点个数（重复）
        public const int LEVEL3_TOTAL_NUM = 13;         //层3的节点个数（重复）
        public const int LEVEL4_TOTAL_NUM = 31;         //层4的节点个数（重复）

        //层1的元素名称
        public string LEVEL1_UNITS = ModelName.LEVELNAME_QUALITYATTRIBUTE_1;

        //层1下面涉及的第2层元素名称列表
        public List<string> LEVEL1_LINK_2_UNITS = new List<string>()
        {
            ModelName.LEVELNAME_ATTRIBUTE_1,
            ModelName.LEVELNAME_ATTRIBUTE_2,
            ModelName.LEVELNAME_ATTRIBUTE_3,
            ModelName.LEVELNAME_ATTRIBUTE_4
        };
        //层2下面涉及的第3层元素名称列表
        public List<List<string>> LEVEL2_LINK_3_UNITS = new List<List<string>>()
        {
            new List<string>()
            {
                ModelName.LEVELNAME_PROPERTY_1,
                ModelName.LEVELNAME_PROPERTY_2,
                ModelName.LEVELNAME_PROPERTY_3,
                ModelName.LEVELNAME_PROPERTY_4
            },
            new List<string>()
            {
                ModelName.LEVELNAME_PROPERTY_1,
                ModelName.LEVELNAME_PROPERTY_2,
                ModelName.LEVELNAME_PROPERTY_5,
                ModelName.LEVELNAME_PROPERTY_6,
                ModelName.LEVELNAME_PROPERTY_7
            },
            new List<string>()
            {
                ModelName.LEVELNAME_PROPERTY_6,
                ModelName.LEVELNAME_PROPERTY_7
            },
            new List<string>()
            {
                ModelName.LEVELNAME_PROPERTY_2,
                ModelName.LEVELNAME_PROPERTY_5
            }
        };
        //层3下面涉及的第4层元素名称列表
        public List<List<List<string>>> LEVEL3_LINK_4_UNITS = new List<List<List<string>>>()
        {
            new List<List<string>>()
            {
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_2
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_3
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_4
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_5,
                    ModelName.LEVELNAME_METRIC_6
                }
            },
            new List<List<string>>()
            {
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_2
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_3
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_3,
                    ModelName.LEVELNAME_METRIC_5
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_3,
                    ModelName.LEVELNAME_METRIC_7,
                    ModelName.LEVELNAME_METRIC_5
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_8
                }
            },
            new List<List<string>>()
            {
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_3,
                    ModelName.LEVELNAME_METRIC_7,
                    ModelName.LEVELNAME_METRIC_5
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_8
                }
            },
            new List<List<string>>()
            {
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_3
                },
                new List<string>()
                {
                    ModelName.LEVELNAME_METRIC_1,
                    ModelName.LEVELNAME_METRIC_3,
                    ModelName.LEVELNAME_METRIC_5
                }
            }
        };
    }
}
