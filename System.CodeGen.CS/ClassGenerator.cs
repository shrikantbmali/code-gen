using System.IO;
using System.Text;

namespace System.CodeGen.CS
{
    public class ClassGenerator
    {
        private readonly StringBuilder _stringBuilder;

        public ClassGenerator(ClassData classData)
        {
            _stringBuilder = new StringBuilder();

            if (classData.AccessSpecifier != AccessSpecifier.Default)
                AddLiteralBlock(GetAccessSpecifier(classData.AccessSpecifier));

            if (classData.ClassType != ClassType.Default)
                AddLiteralBlock(GetClassType(classData.ClassType));

            AddLiteralBlock(KeyWords.Class);

            _stringBuilder.Append(classData.Name);
            _stringBuilder.Append(KeyWords.CodeBlock);
        }

        public string GetClass()
        {
            return _stringBuilder.ToString();
        }

        private void AddLiteralBlock(string literal)
        {
            _stringBuilder.Append(literal);
            _stringBuilder.Append(KeyWords.LiteralSeperator);
        }

        private string GetAccessSpecifier(AccessSpecifier accessSpecifier)
        {
            switch (accessSpecifier)
            {
                case AccessSpecifier.Internal:
                    return KeyWords.Internal;
                case AccessSpecifier.Public:
                    return KeyWords.Public;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessSpecifier), accessSpecifier, null);
            }
        }

        private string GetClassType(ClassType accessSpecifier)
        {
            switch (accessSpecifier)
            {
                case ClassType.Static:
                    return KeyWords.Static;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessSpecifier), accessSpecifier, null);
            }
        }
    }
}
