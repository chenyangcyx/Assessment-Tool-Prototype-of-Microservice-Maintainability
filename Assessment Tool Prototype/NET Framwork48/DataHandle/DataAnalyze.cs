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
    }
}
