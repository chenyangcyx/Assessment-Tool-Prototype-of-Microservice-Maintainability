using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle
{
    class JSONDecoder
    {
        public JSONDataStruct.Root GetJSONObject(string content)
        {
            return JsonConvert.DeserializeObject<JSONDataStruct.Root>(content);
        }
    }
}
