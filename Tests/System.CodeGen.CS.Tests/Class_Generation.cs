using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.CodeGen.CS.Tests
{
    [TestClass]
    public class Class_Generation
    {
        [TestMethod]
        public void Should_Be_Able_To_Create_A_Class_With_A_Given_Name()
        {
            var classGenerator = new ClassGenerator("SimpleClass");

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData("SimpleClass");

            Assert.AreEqual(testData, classData);
        }

        [TestMethod]
        public void Should_Be_Able_To_Set_Public_Access_Specifier_To_The_Class()
        {
            var classGenerator = new ClassGenerator("PublicClass", AccessSpecifier.Public);

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData("PublicClass");

            Assert.AreEqual(testData, classData);
        }

        [TestMethod]
        public void Should_Be_Able_To_Set_Internal_Access_Specifier_To_The_Class()
        {
            var classGenerator = new ClassGenerator("InternalClass", AccessSpecifier.Internal);

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData("InternalClass");

            Assert.AreEqual(testData, classData);
        }

        [TestMethod]
        public void Should_Be_Able_To_Create_A_Static_Class_With_A_Given_Name()
        {
            var classGenerator = new ClassGenerator("StaticClass", AccessSpecifier.Public, ClassType.Static);

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData("StaticClass");

            Assert.AreEqual(testData, classData);
        }

        [TestMethod]
        public void Should_Be_Able_To_Create_An_Internal_Static_Class_With_A_Given_Name()
        {
            var classGenerator = new ClassGenerator("InternalStaticClass", AccessSpecifier.Internal, ClassType.Static);

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData("InternalStaticClass");

            Assert.AreEqual(testData, classData);
        }
    }
}