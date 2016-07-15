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
        [TestMethod]
        public void LinqWhereOp()
        {
            Linq.LinqOperators.WhereOp();

        }
        [TestMethod]
        public void ChainingOperators()
        {
            Linq.LinqOperators.ChainingOp();

        }
        [TestMethod]
        public void OtherOperators()
        {
            Linq.LinqOperators.OtherOperators();

        }
        [TestMethod]
        public void SubQueries()
        {
            Linq.LinqOperators.SubQueries();

        }
    }
}
