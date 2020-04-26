using System.Collections.Generic;

namespace NET_Framwork48.DataHandle.JSONHistoryDataStruct
{
    public class Version
    {
        public string sha1hash { get; set; }
        public string tag { get; set; }
    }

    public class RepositoryInfo
    {
        public string repositoryURL { get; set; }
        public string gitURL { get; set; }
        public Version version { get; set; }
    }

    public class Interfaces
    {
        public string interfaceName { get; set; }
        public List<string> messageName { get; set; }
    }

    public class Call
    {
        public string serviceName { get; set; }
        public List<string> callInterface { get; set; }
    }

    public class Microservices
    {
        public string serviceName { get; set; }
        public List<Interfaces> interfaces { get; set; }
        public List<Call> call { get; set; }
    }

    public class Messages
    {
        public string messageName { get; set; }
        public string parameterNumber { get; set; }
        public string messageContent { get; set; }
    }

    public class JSONContent
    {
        public string projectName { get; set; }
        public List<RepositoryInfo> repositoryInfo { get; set; }
        public List<Microservices> microservices { get; set; }
        public List<Messages> messages { get; set; }
    }

    public class HistoryData
    {
        public string AssessTime { get; set; }
        public string ResultValue { get; set; }
        public JSONContent JSONContent { get; set; }
    }

    public class Root
    {
        public string LastAssessTime { get; set; }
        public List<string> CommitTimeHistory { get; set; }
        public List<HistoryData> HistoryData { get; set; }
    }

}
