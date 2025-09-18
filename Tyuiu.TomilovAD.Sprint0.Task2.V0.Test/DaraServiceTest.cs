using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TomilovAD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TomilovAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артём";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артём", res);
        }
    }
}
