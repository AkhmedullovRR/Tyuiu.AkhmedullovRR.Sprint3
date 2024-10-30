using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmedullovRR.Sprint3.Task4.V28.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5, 5);
            Assert.AreEqual(res, 623.499);
        }
    }
}