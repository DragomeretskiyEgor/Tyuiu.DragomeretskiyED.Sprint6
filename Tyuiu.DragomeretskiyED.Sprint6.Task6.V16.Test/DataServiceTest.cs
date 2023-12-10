using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.DragomeretskiyED.Sprint6.Task6.V16.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V16.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "brIBPtX bWk";
            Assert.AreEqual(wait, res);
        }
    }
}
