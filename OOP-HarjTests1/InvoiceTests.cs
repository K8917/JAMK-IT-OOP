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
    public class InvoiceTests
    {
        [TestMethod()]
        public void TotalTest()
        {
            InvoiceItem i1 = new InvoiceItem("asd", 10, 1);
            InvoiceItem i2 = new InvoiceItem("asd2", 1, 5);
            InvoiceItem i3 = new InvoiceItem("asd3", 5, 2);
            List<InvoiceItem> tmp = new List<InvoiceItem> {i1,i2,i3};
            Invoice inv = new Invoice();
            double expect = 25.00;
            inv.Items.Add(i1);
            inv.Items.Add(i2);
            inv.Items.Add(i3);
            double actual = inv.Total();
            Assert.AreEqual(expect, actual);
        }
    }
}