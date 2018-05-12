namespace System.CodeGen.CS
{
    public struct ClassData
    {
        public readonly string Name;
        public readonly AccessSpecifier AccessSpecifier;
        public readonly ClassType ClassType;

        public ClassData(string name, AccessSpecifier accessSpecifier = AccessSpecifier.Default, ClassType classType = ClassType.Default)
        {
            Name = name;
            AccessSpecifier = accessSpecifier;
            ClassType = classType;
        }
    }
}
