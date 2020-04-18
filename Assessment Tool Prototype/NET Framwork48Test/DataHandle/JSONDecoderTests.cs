using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET_Framwork48.DataHandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.DataHandle.Tests
{
    [TestClass()]
    public class JSONDecoderTests
    {
        [TestMethod()]
        public void GetJSONObjectTest()
        {
            string path = @"jsonDataStructExample.json";
            DataInput dataInput = new DataInput();
            string content = dataInput.InputDataFromFile(path);
            JSONDecoder jsondec = new JSONDecoder();
            JSONDataStruct.Root root = jsondec.GetJSONObject(content);
            Assert.AreEqual("projectName", root.projectName);
            Assert.AreEqual(1, root.repositoryInfo.Count);
            Assert.AreEqual("repositoryURL", root.repositoryInfo[0].repositoryURL);
            Assert.AreEqual("gitURL", root.repositoryInfo[0].gitURL);
            Assert.AreEqual("sha1 hash", root.repositoryInfo[0].version.sha1hash);
            Assert.AreEqual("tag", root.repositoryInfo[0].version.tag);
            Assert.AreEqual(1, root.microservices.Count);
            Assert.AreEqual("microservice name", root.microservices[0].serviceName);
            Assert.AreEqual(1, root.microservices[0].interfaces.Count);
            Assert.AreEqual("interface", root.microservices[0].interfaces[0].interfaceName);
            Assert.AreEqual(2, root.microservices[0].interfaces[0].messageName.Count);
            Assert.AreEqual("messagename1", root.microservices[0].interfaces[0].messageName[0]);
            Assert.AreEqual("messagename2", root.microservices[0].interfaces[0].messageName[1]);
            Assert.AreEqual(1, root.microservices[0].call.Count);
            Assert.AreEqual("servicename", root.microservices[0].call[0].serviceName);
            Assert.AreEqual(2, root.microservices[0].call[0].callInterface.Count);
            Assert.AreEqual("callinterface1", root.microservices[0].call[0].callInterface[0]);
            Assert.AreEqual("callinterface2", root.microservices[0].call[0].callInterface[1]);
            Assert.AreEqual(1, root.messages.Count);
            Assert.AreEqual("messageName", root.messages[0].messageName);
            Assert.AreEqual(2, root.messages[0].parameterNumber);
            Assert.AreEqual("this is a message content", root.messages[0].messageContent);
        }
    }
}