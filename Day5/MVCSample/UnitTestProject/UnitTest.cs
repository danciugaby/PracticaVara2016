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
            log4net.GlobalContext.Properties["LogFileName"] = @"C:\Users\gabi\Downloads\log.txt"; //log file path
            log4net.Config.XmlConfigurator.Configure();
            iomanager = new IOManager(@"C:\Users\gabi\Downloads\mydb.txt");


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

        [TestMethod]
        public void TestMethodDataBaseQuery()
        {
            iomanager.QueryAll();

        }
    }
}
