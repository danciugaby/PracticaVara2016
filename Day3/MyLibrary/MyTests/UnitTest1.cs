using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Functionality1;
using MyLibrary.Functionality2;

namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDisplay()
        {
            Display d = new Display();
            string s = d.DisplayMessage("ceva");
            Assert.AreEqual(s, "cevanou");
        }

        [TestMethod]
        public void TestMethodTransform()
        {
            Transform t = new Transform();
            t.ChangeBehaviour(true);
            Assert.IsTrue(t.Behaviour);
            t.ChangeBehaviour(false);
            Assert.IsFalse(t.Behaviour);
        }


    }
}
