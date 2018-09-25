using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SortStringTest()
        {
            string str = "vsdfea";
            string result = Program.SortString(str);
            Assert.AreEqual("adefsv", result);
        }
    }
}