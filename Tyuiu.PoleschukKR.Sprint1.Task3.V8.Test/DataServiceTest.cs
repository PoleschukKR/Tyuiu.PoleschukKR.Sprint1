using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.Task3.V8.Lib;



namespace Tyuiu.PoleschukKR.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double percent = 20;
            double timeDays = 73;
            double startAmount = 2500;
            double wait = 100;
            var res = ds.IncomeAmount(percent, timeDays, startAmount);
            Assert.AreEqual(wait, res);
        }
    }
}
