using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle
{
    public class JSONDecoder
    {
        //get a new json file's object entity
        public JSONDataStruct.Root GetNewJSONDataObject(string content)
        {
            return JsonConvert.DeserializeObject<JSONDataStruct.Root>(content);
        }

        //get the old json file's object entity
        public JSONHistoryDataStruct.Root GetHistoryJSONDataObject(string content)
        {
            return JsonConvert.DeserializeObject<JSONHistoryDataStruct.Root>(content);
        }
    }
}
