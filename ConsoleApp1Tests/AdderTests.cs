﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class AdderTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(12, Adder.Add(5, 7));
            Assert.Fail();
        }
    }
}