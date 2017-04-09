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
            ISoftwareInfo service = new SoftwareInfo();
            var integraServerDirs = service.GetServerFolders(@"C:\Users\sutm\Projects");
            foreach (var dir in integraServerDirs)
                Console.WriteLine(dir);
        }
    }
}
