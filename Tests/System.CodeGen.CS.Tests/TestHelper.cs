using System.IO;
using System.Reflection;

namespace System.CodeGen.CS.Tests
{
    internal static class TestHelper
    {
        public static string GetTestData(string dataClassName)
        {
            var location = Assembly.GetExecutingAssembly().Location;

            var testDataFilePath = Path.Combine(Path.GetDirectoryName(location), "TestData", $"{dataClassName}.cs");
            var testStream = new StreamReader(File.OpenRead(testDataFilePath));
            var data = testStream.ReadToEnd();

            return data;
        }
    }
}
