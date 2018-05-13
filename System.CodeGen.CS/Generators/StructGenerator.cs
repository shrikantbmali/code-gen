namespace System.CodeGen.CS
{
    public class StructGenerator : TypeGenerator
    {
        public StructGenerator(ClassData classData): base(classData, KeyWords.Struct)
        {
        }
    }
}