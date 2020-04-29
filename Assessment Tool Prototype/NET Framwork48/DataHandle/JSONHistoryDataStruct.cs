using System.Collections.Generic;

namespace NET_Framwork48.DataHandle.JSONHistoryDataStruct
{
    public class Rootobject
    {
        public string lastAssessTime { get; set; }
        public List<string> commitTimeHistory { get; set; }
        public List<Historydata> historyData { get; set; }
    }

    public class Historydata
    {
        public string assessTime { get; set; }
        public Resultvalue resultValue { get; set; }
        public Metricdetail metricDetail { get; set; }
        public Jsoncontent JSONContent { get; set; }
    }

    public class Resultvalue
    {
        public Level1 Level1 { get; set; }
        public Level2 Level2 { get; set; }
        public List<Level3> Level3 { get; set; }
    }

    public class Level1
    {
        public string Maintainability { get; set; }
    }

    public class Level2
    {
        public string Analyzability { get; set; }
        public string Changeability { get; set; }
        public string Stability { get; set; }
        public string Modularity { get; set; }
    }

    public class Level3
    {
        public string Coupling { get; set; }
        public string Cohesion { get; set; }
        public string DesignComplexity { get; set; }
        public string SystemSize { get; set; }
        public string ServiceGranularity { get; set; }
        public string ParameterGranularity { get; set; }
        public string ServiceLoopback { get; set; }
    }

    public class Metricdetail
    {
        public List<string> ServiceName { get; set; }
        public List<string> MessageName { get; set; }
        public string NS { get; set; }
        public List<string> NDCS { get; set; }
        public string NDCS_TOTAL { get; set; }
        public string NM { get; set; }
        public List<string> NIS { get; set; }
        public string NIS_TOTAL { get; set; }
        public List<string> NPI { get; set; }
        public string NPI_TOTAL { get; set; }
        public List<string> NII { get; set; }
        public string NII_TOTAL { get; set; }
        public List<string> NMP { get; set; }
        public string NMP_TOTAL { get; set; }
        public List<string> WISL { get; set; }
        public string WISL_TOTAL { get; set; }
        public List<string> connectionRelationship { get; set; }
        public List<string> callRelationship { get; set; }
    }

    public class Jsoncontent
    {
        public string projectName { get; set; }
        public List<Repositoryinfo> repositoryInfo { get; set; }
        public List<Microservice> microservices { get; set; }
        public List<Message> messages { get; set; }
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
        public List<Interface> interfaces { get; set; }
        public List<Call> call { get; set; }
    }

    public class Interface
    {
        public string interfaceName { get; set; }
        public List<string> messageName { get; set; }
    }

    public class Call
    {
        public string serviceName { get; set; }
        public List<string> callInterface { get; set; }
    }

    public class Message
    {
        public string messageName { get; set; }
        public string parameterNumber { get; set; }
        public string messageContent { get; set; }
    }
}
