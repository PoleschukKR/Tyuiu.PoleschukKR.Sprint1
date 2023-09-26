using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.Task5.V1.Lib;
namespace Tyuiu.PoleschukKR.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double x2 = 11;
            double y1 = 8;
            double y2 = 16;
            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
