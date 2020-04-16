using NET_Framwork48.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle
{
    public class DataAnalyze
    {
        JSONDataStruct.Root data;
        ModelValue modelValue;

        public DataAnalyze(JSONDataStruct.Root datasource,ModelValue mv)
        {
            data = datasource;
            modelValue = mv;
        }

        //设置所有的服务的名称列表
        public void SetServiceNames()
        {
            int number = 0;
            foreach(var service in data.microservices)
            {
                modelValue.Dic_NO_ServiceName.Add(number, service.serviceName);
                modelValue.Dic_ServiceName_NO.Add(service.serviceName, number);
                number++;
            }
        }

        //设置NS
        public void SetNS()
        {
            modelValue.NS = data.microservices.Count;
        }

        //设置NM
        public void SetNM()
        {
            modelValue.NM = data.messages.Count;
        }

        //设置NDCS()
        public void SetNDCS()
        {
            //int microservice_number = data.microservices.Count;
            //List<List<int>> microservice_graph = new List<List<int>>();
            //for (int i = 0; i < microservice_number; i++)
            //    microservice_graph.Add(new List<int>());
            ////构造邻接表
            //for (int i = 0; i < microservice_number; i++)
            //{
            //    foreach (var node in data.microservices[i].call)
            //    {
            //        int out_service_no = 0;
            //        modelValue.Dic_ServiceName_NO.TryGetValue(node.serviceName, out out_service_no);
            //        microservice_graph[out_service_no].Add(i);
            //    }
            //}
            ////构造关联关系表
            //int[,] if_connect = new int[microservice_number, microservice_number];
            //for (int i = 0; i < microservice_number; i++)
            //    for (int j = 0; j < microservice_number; j++)
            //        if_connect[i, j] = 0;
            //for (int i = 0; i < microservice_graph.Count; i++)
            //{
            //    var node = microservice_graph[i];
            //    foreach (var link_node in node)
            //        if_connect[i, link_node] = 1;
            //}
            ////写入NDCS()字典
            //for (int i = 0; i < microservice_number; i++)
            //{
            //    int num = 0;
            //    for (int j = 0; j < microservice_number; j++)
            //        if (if_connect[i, j] == 1)
            //            num++;
            //    modelValue.NDCS_NO_VALUE.Add(i, num);
            //}

            int microservice_number = data.microservices.Count;
            int[,] if_connect = new int[microservice_number, microservice_number];
            for (int i = 0; i < microservice_number; i++)
                for (int j = 0; j < microservice_number; j++)
                    if_connect[i, j] = 0;
            for(int i = 0; i < microservice_number; i++)
            {
                foreach(var call_service in data.microservices[i].call)
                {
                    int num = 0;
                    modelValue.Dic_ServiceName_NO.TryGetValue(call_service.serviceName, out num);
                    if_connect[i, num] = 1;
                    if_connect[num, i] = 1;
                }
            }
            for(int i = 0; i < microservice_number; i++)
            {
                int num = 0;
                for (int j = 0; j < microservice_number; j++)
                    if (if_connect[i, j] == 1)
                        num++;
                modelValue.NDCS_NO_VALUE.Add(i, num);
            }
        }

        //设置NIS()
        public void SetNIS()
        {
            for(int i = 0; i < data.microservices.Count; i++)
                modelValue.NIS_NO_VALUE.Add(i, data.microservices[i].call.Count);
        }

        //设置NPI()
        public void SetNPI()
        {
            for (int i = 0; i < data.microservices.Count; i++)
                modelValue.NPI_NO_VALUE.Add(i, data.microservices[i].interfaces.Count);
        }

        //设置NII()
        public void SetNII()
        {
            for(int i = 0; i < data.microservices.Count; i++)
            {
                int sum = 0;
                foreach (var call_node in data.microservices[i].call)
                    sum += call_node.callInterface.Count;
                modelValue.NII_NO_VALUE.Add(i, sum);
            }
        }

        //设置NMP()
        public void SetNMP()
        {
            int number = 0;
            foreach(var message_node in data.messages)
            {
                modelValue.Dic_NO_MessageName.Add(number, message_node.messageName);
                modelValue.Dic_MessageName_NO.Add(message_node.messageName, number);
                number++;
            }
            for(int i = 0; i < data.messages.Count; i++)
                modelValue.NMP_NO_VALUE.Add(i, data.messages[i].parameterNumber);
        }

        //设置WISL()
        public void SetWISL()
        {

        }
    }
}
