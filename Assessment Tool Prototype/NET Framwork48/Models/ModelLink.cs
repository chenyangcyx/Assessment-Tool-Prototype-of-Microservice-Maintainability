using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.Models
{
    public class ModelLink
    {
        public const int LEVEL1_UNITNUM = 1;           //number of elements in Level 1 (not repeated)
        public const int LEVEL2_UNITNUM = 4;           //number of elements in Level 2 (not repeated)
        public const int LEVEL3_UNITNUM = 7;           //number of elements in Level 3 (not repeated)
        public const int LEVEL4_UNITNUM = 8;           //number of elements in Level 4 (not repeated)

        //number of elements in Level 1
        public int LEVEL1_LINK_1_NUM = 1;
        //number of elements connected from Level 1 to Level 2
        public int LEVEL1_LINK_2_NUM = 4;
        //number of elements connected from Level 2 to Level 3
        public int[] LEVEL2_LINK_3_NUM = new int[4]{ 4, 5, 2, 2 };
        //number of elements connected from Level 3 to Level 4
        public int[][] LEVEL3_LINK_4_NUM = { 
            new int[4]{ 2, 2, 2, 3 }, 
            new int[5]{ 2, 2, 3, 3, 2 },
            new int[2]{ 3, 2 },
            new int[2]{ 2, 3 } };

        public const int LEVEL1_TOTAL_NUM = 1;          //number of nodes in Level 1 (duplicate)
        public const int LEVEL2_TOTAL_NUM = 4;          //number of nodes in Level 2 (duplicate)
        public const int LEVEL3_TOTAL_NUM = 13;         //number of nodes in Level 3 (duplicate)
        public const int LEVEL4_TOTAL_NUM = 31;         //number of nodes in Level 4 (duplicate)

        //element name of Level 1
        public string LEVEL1_UNITS = ModelName.LEVELNAME_QUALITYATTRIBUTE_1;

        //list of names of Level 2 elements involved below Level 1
        public List<string> LEVEL1_LINK_2_UNITS = new List<string>()
        {
            ModelName.LEVELNAME_ATTRIBUTE_1,
            ModelName.LEVELNAME_ATTRIBUTE_2,
            ModelName.LEVELNAME_ATTRIBUTE_3,
            ModelName.LEVELNAME_ATTRIBUTE_4
        };
        //list of element names of Level 3 involved below Level 2
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
        //list of element names of Level 4 involved below Level 3
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
