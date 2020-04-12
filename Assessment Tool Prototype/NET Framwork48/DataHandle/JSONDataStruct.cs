using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle.JSONDataStruct
{
    public class Version
    {
        public string sha1hash { get; set; }
        public string tag { get; set; }
    }

    public class RepositoryInfoItem
    {
        public string repositoryURL { get; set; }
        public string gitURL { get; set; }
        public Version version { get; set; }
    }

    public class InterfacesItem
    {
        public string interfaceName { get; set; }
        public List<string> messageName { get; set; }
    }

    public class CallItem
    {
        public string serviceName { get; set; }
        public List<string> callInterface { get; set; }
    }

    public class MicroservicesItem
    {
        public string serviceName { get; set; }
        public List<InterfacesItem> interfaces { get; set; }
        public List<CallItem> call { get; set; }
    }

    public class MessagesItem
    {
        public string messageName { get; set; }
        public int parameterNumber { get; set; }
        public List<string> elements { get; set; }
    }

    public class Root
    {
        public string projectName { get; set; }
        public List<RepositoryInfoItem> repositoryInfo { get; set; }
        public List<MicroservicesItem> microservices { get; set; }
        public List<MessagesItem> messages { get; set; }
    }
}
