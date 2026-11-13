using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PopovaYE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PopovaYE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Юлиана";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Юлиана", res);
        }
    }
}
