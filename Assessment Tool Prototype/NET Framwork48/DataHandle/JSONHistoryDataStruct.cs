using System.Collections.Generic;

namespace NET_Framwork48.DataHandle.JSONHistoryDataStruct
{
    public class Rootobject
    {
        public string lastAssessTime;
        public List<string> commitTimeHistory;
        public List<Historydata> historyData;
    }

    public class Historydata
    {
        public string assessTime;
        public Resultvalue resultValue;
        public Metricdetail metricDetail;
        public Jsoncontent JSONContent;
    }

    public class Resultvalue
    {
        public Level1 Level1;
        public Level2 Level2;
        public List<Level3> Level3;
    }

    public class Level1
    {
        public string Maintainability;
    }

    public class Level2
    {
        public string Analyzability;
        public string Changeability;
        public string Stability;
        public string Modularity;
    }

    public class Level3
    {
        public string Coupling;
        public string Cohesion;
        public string DesignComplexity;
        public string SystemSize;
        public string ServiceGranularity;
        public string ParameterGranularity;
        public string ServiceLoopback;
    }

    public class Metricdetail
    {
        public List<string> ServiceName;
        public List<string> MessageName;
        public string NS;
        public List<string> NDCS;
        public string NDCS_TOTAL;
        public string NM;
        public List<string> NIS;
        public string NIS_TOTAL;
        public List<string> NPI;
        public string NPI_TOTAL;
        public List<string> NII;
        public string NII_TOTAL;
        public List<string> NMP;
        public string NMP_TOTAL;
        public List<string> WISL;
        public string WISL_TOTAL;
        public List<string> connectionRelationship;
        public List<string> callRelationship;
    }

    public class Jsoncontent
    {
        public string projectName;
        public List<Repositoryinfo> repositoryInfo;
        public List<Microservice> microservices;
        public List<Message> messages;
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
        public List<Interface> interfaces;
        public List<Call> call;
    }

    public class Interface
    {
        public string interfaceName;
        public List<string> messageName;
    }

    public class Call
    {
        public string serviceName;
        public List<string> callInterface;
    }

    public class Message
    {
        public string messageName;
        public string parameterNumber;
        public string messageContent;
    }
}
