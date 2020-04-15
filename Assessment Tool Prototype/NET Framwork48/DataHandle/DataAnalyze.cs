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
    }
}
