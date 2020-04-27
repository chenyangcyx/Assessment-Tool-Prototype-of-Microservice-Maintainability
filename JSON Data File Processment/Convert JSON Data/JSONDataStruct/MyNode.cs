using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_JSON_Data.JSONDataStruct.MyNode
{
    public class Rootobject
    {
        public string projectName;
        public Repositoryinfo[] repositoryInfo;
        public Microservice[] microservices;
        public Message[] messages;
    }

    public class Repositoryinfo
    {
        public string repositoryURL;
        public string gitURL;
        public Version version;
    }

    public class Version
    {
        public string sha1hash;
        public string tag;
    }

    public class Microservice
    {
        public string serviceName;
        public Interface[] interfaces;
        public Call[] call;
    }

    public class Interface
    {
        public string interfaceName;
        public string[] messageName;
    }

    public class Call
    {
        public string serviceName;
        public string[] callInterface;
    }

    public class Message
    {
        public string messageName;
        public string parameterNumber;
        public string messageContent;
    }

}
