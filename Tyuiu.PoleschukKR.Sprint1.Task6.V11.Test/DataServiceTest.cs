using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint1.Task6.V11.Lib;

namespace Tyuiu.PoleschukKR.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "Антон, привет!";
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
