using System;
using Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnumeration()
        {
                Linq.Linqer.TestEnum();
            
        }
        [TestMethod]
        public void TestEnumerator()
        {
            Linq.Linqer.TestEnumeartor();

        }
    }
}
