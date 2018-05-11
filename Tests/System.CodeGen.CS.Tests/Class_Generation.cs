using System;
using System.CodeGen.CS;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Class_Generation
    {
        private static string GetTestData(string dataFileName)
        {
            var location = Assembly.GetExecutingAssembly().Location;

            var combine = Path.Combine(Path.GetDirectoryName(location), "TestData", dataFileName);
            var testStream = new StreamReader(File.OpenRead(combine));
            var data = testStream.ReadToEnd();

            return data;
        }

        [TestMethod]
        public void Should_Be_Able_To_Create_A_Class_With_A_Given_Name()
        {
            var classGenerator = new ClassGenerator("Class1");

            var classData = classGenerator.GetClass();

            var testData = GetTestData("EmptyClass.txt");

            Assert.AreEqual(testData, classData);
        }

        [TestMethod]
        public void Should_Be_Able_To_Set_Access_Specifier_To_The_Class()
        {
            var classGenerator = new ClassGenerator("Class1", System.CodeGen.CS.AccessSpecifier.Public);
            var classData = classGenerator.GetClass();

            var testData = GetTestData("PublicClass.txt");

            Assert.AreEqual(testData, classData);
        }

        //[TestMethod]
        //public void Should_Be_Able_To_Create_Method_In_A_Class_With_Given_Name()
        //{

        //}
    }
}