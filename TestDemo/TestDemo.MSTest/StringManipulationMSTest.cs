using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SortStringTest()
        {
            //arrange
            string str = "bscbsd";
            //act
            string result = Program.SortString(str);
            //assert
            Assert.AreEqual("bbcdss", result);
        }

        [TestMethod]
        public void ReverseTest()
        {
            //arrange
            string str = "abcdefg";
            //act
            string result = Program.Reverse(str);
            //assert
            Assert.AreEqual("gfedcba", result);
        }

        [TestMethod]
        public void ReplaceSpaceTest()
        {
            //arrange
            string str = "abc defg";
            //act
            string result = Program.ReplaceSpace(str);
            //assert
            Assert.AreEqual("abc-defg", result);
        }

        [TestMethod]
        public void SubStringTest()
        {
            //arrange
            string str = "abcdef";
            int index = 5;
            //act
            string result = Program.SubString(str, index);
            //assert
            Assert.AreEqual("f", result);
        }
    }
}