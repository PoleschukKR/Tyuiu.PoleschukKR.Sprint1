using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.Task7.V5.Lib;

namespace Tyuiu.PoleschukKR.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -0.888;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}
