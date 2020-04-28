using System.Collections.Generic;

namespace NET_Framwork48.DataHandle.JSONDataStruct
{
    public class Rootobject
    {
        public string projectName { get; set; }
        public Repositoryinfo[] repositoryInfo { get; set; }
        public Microservice[] microservices { get; set; }
        public Message[] messages { get; set; }
    }

    public class Repositoryinfo
    {
        public string repositoryURL { get; set; }
        public string gitURL { get; set; }
        public Version version { get; set; }
    }

    public class Version
    {
        public string sha1hash { get; set; }
        public string tag { get; set; }
    }

    public class Microservice
    {
        public string serviceName { get; set; }
        public Interface[] interfaces { get; set; }
        public Call[] call { get; set; }
    }

    public class Interface
    {
        public string interfaceName { get; set; }
        public string[] messageName { get; set; }
    }

    public class Call
    {
        public string serviceName { get; set; }
        public string[] callInterface { get; set; }
    }

    public class Message
    {
        public string messageName { get; set; }
        public string parameterNumber { get; set; }
        public string messageContent { get; set; }
    }

}
