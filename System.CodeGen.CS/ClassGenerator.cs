using System.IO;
using System.Text;

namespace System.CodeGen.CS
{
    public class ClassGenerator
    {
        private readonly StringBuilder _stringBuilder;

        public ClassGenerator(string className): this(className, AccessSpecifier.Default)
        {
        }

        public ClassGenerator(string className, AccessSpecifier accessSpecifier)
        {
            _stringBuilder = new StringBuilder();

            if (accessSpecifier != AccessSpecifier.Default)
                AddLiteralBlock(GetAccessSpecifier(accessSpecifier));

            AddLiteralBlock(KeyWords.Class);

            _stringBuilder.Append(className);
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
                case AccessSpecifier.Public:
                    return KeyWords.PublicAccessSpecifier;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessSpecifier), accessSpecifier, null);
            }
        }
    }
}
