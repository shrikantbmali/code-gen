using System.CodeGen.CS.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.CodeGen.CS
{
    [TestClass]
    public class Struct_Generator
    {
        [TestMethod]
        public void Should_Be_Able_To_2Create_A_Struct_With_A_Given_Name()
        {
            var classGenerator = new StructGenerator(new ClassData("SimpleStruct"));

            var classData = classGenerator.GetClass();
            var testData = TestHelper.GetTestData(@"Structs\SimpleStruct");

            Assert.AreEqual(testData, classData);
        }
    }
}
