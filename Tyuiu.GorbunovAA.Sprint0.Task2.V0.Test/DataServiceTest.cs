﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GorbunovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Александр";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Александр", res);
        }
    }
}
