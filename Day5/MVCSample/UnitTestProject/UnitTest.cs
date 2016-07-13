using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Controller;
using Entities;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        IOManager iomanager;
        [TestInitialize]
        public void Init()
        {
            iomanager = new IOManager();
        }
        [TestMethod]
        public void TestMethodAppSettings()
        {
             iomanager = new IOManager();
           
        }
        [TestMethod]
        public void TestMethodInsert()
        {
            iomanager.Insert(new Employee());

        }
        [TestMethod]
        public void TestMethodDataBaseAdd()
        {
            Database db = new Database();
            db.Add("A", "B");

        }
    }
}
