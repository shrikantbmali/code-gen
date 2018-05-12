using System.IO;
using System.Text;

namespace System.CodeGen.CS
{
    public class ClassGenerator
    {
        private readonly ClassData _classData;
        private readonly StringBuilder _stringBuilder;

        public ClassGenerator(ClassData classData)
        {
            _classData = classData;
            _stringBuilder = new StringBuilder();
        }

        public string GetClass()
        {           
            AddLiteralBlock(_classData.AccessSpecifier.GetLiteral());
            AddLiteralBlock(_classData.ClassType.GetLiteral());
            AddLiteralBlock(KeyWords.Class);

            _stringBuilder.Append(_classData.Name);
            _stringBuilder.Append(KeyWords.CodeBlock);

            return _stringBuilder.ToString();
        }

        private void AddLiteralBlock(string literal)
        {
            _stringBuilder.Append(literal);

            if(!string.IsNullOrEmpty(literal))
                _stringBuilder.Append(KeyWords.LiteralSeperator);
        }
    }
}
