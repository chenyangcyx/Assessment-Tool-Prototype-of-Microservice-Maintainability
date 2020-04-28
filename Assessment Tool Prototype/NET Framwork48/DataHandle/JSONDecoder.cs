using Newtonsoft.Json;

namespace NET_Framwork48.DataHandle
{
    public class JSONDecoder
    {
        // get a new json file's object entity
        public JSONDataStruct.Rootobject GetNewJSONDataObject(string content)
        {
            return JsonConvert.DeserializeObject<JSONDataStruct.Rootobject>(content);
        }

        // get the old json file's object entity
        public JSONHistoryDataStruct.Root GetHistoryJSONDataObject(string content)
        {
            return JsonConvert.DeserializeObject<JSONHistoryDataStruct.Root>(content);
        }
    }
}
