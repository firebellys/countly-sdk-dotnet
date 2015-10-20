using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountlySDK;

namespace CountlyUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Countly.StartSession("http://cloud.count.ly", "87e43ddcc40b5cd0d4ac857a71d250e1750847f0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
