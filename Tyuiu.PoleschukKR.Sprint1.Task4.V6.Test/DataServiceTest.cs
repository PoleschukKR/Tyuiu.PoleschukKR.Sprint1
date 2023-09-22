using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.Task4.V6.Lib;

namespace Tyuiu.PoleschukKR.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 1.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
