using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stilauncher.Services;

namespace UnitTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void TestIntegraServers()
        {
            var softwareInfo = new SoftwareInfo();
            var integraServerDirs = softwareInfo.GetIntegraServerFolder();
            foreach (var dir in integraServerDirs)
                Console.WriteLine(dir);
        }
    }
}
