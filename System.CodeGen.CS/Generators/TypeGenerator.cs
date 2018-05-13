using System.Text;

namespace System.CodeGen.CS
{
    public abstract class TypeGenerator
    {
        private readonly ClassData _classData;
        private readonly string _keyType;
        private readonly StringBuilder _stringBuilder;

        protected TypeGenerator(ClassData classData, string keyType)
        {
            _classData = classData;
            _keyType = keyType;
            _stringBuilder = new StringBuilder();
        }

        public string GetClass()
        {           
            AddLiteralBlock(_classData.AccessSpecifier.GetLiteral());
            AddLiteralBlock(_classData.ClassType.GetLiteral());
            AddLiteralBlock(_keyType);

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