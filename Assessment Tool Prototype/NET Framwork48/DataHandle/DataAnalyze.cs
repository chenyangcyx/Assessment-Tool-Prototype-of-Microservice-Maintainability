using NET_Framwork48.Models;

namespace NET_Framwork48.DataHandle
{
    public class DataAnalyze
    {
        private JSONDataStruct.Rootobject data;
        private ModelValue modelValue;

        public DataAnalyze(JSONDataStruct.Rootobject datasource, ModelValue mv)
        {
            data = datasource;
            modelValue = mv;
        }

        // set all Metrics of Model
        public void SetMetrics()
        {
            SetServiceNames();
            SetNS();
            SetNM();
            SetNDCS();
            SetNIS();
            SetNPI();
            SetNII();
            SetNMP();
            SetWISL();
        }

        // set the name list of all services
        public void SetServiceNames()
        {
            int number = 0;
            foreach (var service in data.microservices)
            {
                modelValue.Dic_NO_ServiceName.Add(number, service.serviceName);
                modelValue.Dic_ServiceName_NO.Add(service.serviceName, number);
                number++;
            }
        }

        // set NS
        public void SetNS()
        {
            modelValue.NS = data.microservices.Count;
        }

        // set NM
        public void SetNM()
        {
            modelValue.NM = data.messages.Count;
        }

        // set NDCS()
        public void SetNDCS()
        {
            int microservice_number = data.microservices.Count;
            int[,] if_connect = new int[microservice_number, microservice_number];
            for (int i = 0; i < microservice_number; i++)
                for (int j = 0; j < microservice_number; j++)
                    if_connect[i, j] = 0;
            for (int i = 0; i < microservice_number; i++)
                foreach (var call_service in data.microservices[i].call)
                {
                    int num = 0;
                    modelValue.Dic_ServiceName_NO.TryGetValue(call_service.serviceName, out num);
                    if_connect[i, num] = 1;
                    if_connect[num, i] = 1;
                }
            for (int i = 0; i < microservice_number; i++)
            {
                int num = 0;
                for (int j = 0; j < microservice_number; j++)
                    if (if_connect[i, j] == 1)
                        num++;
                modelValue.NDCS_NO_VALUE.Add(i, num);
            }
            // write into the list of connection relationship
            for (int i = 0; i < microservice_number; i++)
                for (int j = 0; j < microservice_number; j++)
                    if (if_connect[i, j] == 1)
                        modelValue.connectionRelationship.Add(i + " -- " + j);
        }

        // set NIS()
        public void SetNIS()
        {
            for (int i = 0; i < data.microservices.Count; i++)
                modelValue.NIS_NO_VALUE.Add(i, data.microservices[i].call.Count);
        }

        // set NPI()
        public void SetNPI()
        {
            for (int i = 0; i < data.microservices.Count; i++)
                modelValue.NPI_NO_VALUE.Add(i, data.microservices[i].interfaces.Count);
        }

        // set NII()
        public void SetNII()
        {
            for (int i = 0; i < data.microservices.Count; i++)
            {
                int sum = 0;
                foreach (var call_node in data.microservices[i].call)
                    sum += call_node.callInterface.Count;
                modelValue.NII_NO_VALUE.Add(i, sum);
            }
        }

        // set NMP()
        public void SetNMP()
        {
            int number = 0;
            foreach (var message_node in data.messages)
            {
                modelValue.Dic_NO_MessageName.Add(number, message_node.messageName);
                modelValue.Dic_MessageName_NO.Add(message_node.messageName, number);
                number++;
            }
            for (int i = 0; i < data.messages.Count; i++)
                modelValue.NMP_NO_VALUE.Add(i, decimal.Parse(data.messages[i].parameterNumber));
        }

        // set WISL()
        public void SetWISL()
        {
            int microservice_number = data.microservices.Count;
            int[,] graph = new int[microservice_number, microservice_number];
            for (int i = 0; i < microservice_number; i++)
                for (int j = 0; j < microservice_number; j++)
                    graph[i, j] = int.MaxValue;
            for (int i = 0; i < microservice_number; i++)
                foreach (var call_service in data.microservices[i].call)
                {
                    int num = int.MaxValue;
                    modelValue.Dic_ServiceName_NO.TryGetValue(call_service.serviceName, out num);
                    graph[num, i] = 1;
                }
            // write into the list of call relationship
            for (int j = 0; j < microservice_number; j++)
                for (int i = 0; i < microservice_number; i++)
                    if (graph[i, j] == 1)
                        modelValue.callRelationship.Add(j + " <-- " + i);

            int[] visit = new int[microservice_number];
            int[] father = new int[microservice_number];
            bool[] if_in_loopback = new bool[microservice_number];
            for (int i = 0; i < microservice_number; i++)
            {
                visit[i] = 0;
                father[i] = -1;
                if_in_loopback[i] = false;
            }
            for (int i = 0; i < microservice_number; i++)
                if (visit[i] == 0)
                    SetWISL_dfsVisit(graph, i, visit, father, microservice_number, if_in_loopback);
            for (int i = 0; i < microservice_number; i++)
                if (if_in_loopback[i] == true)
                    modelValue.WISL_NO_VALUE.Add(i, 1);
                else
                    modelValue.WISL_NO_VALUE.Add(i, 0);
        }

        // dfsVisit operation in WISL()
        public void SetWISL_dfsVisit(int[,] graph, int node, int[] visit, int[] father, int microservice_number, bool[] if_in_loopback)
        {
            visit[node] = 1;
            for (int i = 0; i < microservice_number; i++)
                // not traverse itself
                if (i != node && graph[node, i] != int.MaxValue)
                {
                    // do not traverse the previous node traversed
                    if (visit[i] == 1 && i != father[node])
                    {
                        if_in_loopback[i] = true;
                        int tmp = node;
                        while (tmp != i)
                        {
                            if_in_loopback[tmp] = true;
                            tmp = father[tmp];
                        }
                    }
                    else if (visit[i] == 0)
                    {
                        father[i] = node;
                        SetWISL_dfsVisit(graph, i, visit, father, microservice_number, if_in_loopback);
                    }
                }
            visit[node] = 2;
        }
    }
}
