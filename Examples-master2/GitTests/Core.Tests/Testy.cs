using System;  
using Soneta.Examples.Example8.Extender;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitTests.Core.Tests
{
    [TestClass]
    public class Testy
    {
        [TestMethod]
        public void TestMethod3()
        {
            Notowania notowania = new Notowania();

            decimal count = notowania.GetCommitsAverageForUser("test1");

            Assert.AreEqual(1, count);

        }
    }
}
