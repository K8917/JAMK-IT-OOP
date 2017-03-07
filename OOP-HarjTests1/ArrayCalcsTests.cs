using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Harj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] empty = { };
            double[] nums = {1,2,3};
            double expect = 6;
            double actual = ArrayCalcs.Sum(ref nums);
            Assert.AreEqual(actual, expect);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] empty = { };
            double[] nums = { 1, 2, 3 };
            double expect = 2;
            double actual = ArrayCalcs.Average(ref nums);
            Assert.AreEqual(actual, expect);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] empty = { };
            double[] nums = { 1, 2, 3 };
            double expect = 1;
            double actual = ArrayCalcs.Min(ref nums);
            Assert.AreEqual(actual, expect);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] empty = { };
            double[] nums = { 1, 2, 3 };
            double expect = 3;
            double actual = ArrayCalcs.Max(ref nums);
            Assert.AreEqual(actual, expect);
        }
    }
}