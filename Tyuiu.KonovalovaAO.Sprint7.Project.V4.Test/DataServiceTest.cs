using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KonovalovaAO.Sprint7.Project.V4.Lib;
namespace Tyuiu.KonovalovaAO.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string path = @"C:\DataSprint7\OutPutFileProject.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
