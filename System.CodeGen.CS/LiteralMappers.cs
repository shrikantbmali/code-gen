namespace System.CodeGen.CS
{
    internal static class LiteralMappers
    {
        public static string GetLiteral(this AccessSpecifier accessSpecifier)
        {
            switch (accessSpecifier)
            {
                case AccessSpecifier.Default:
                    return KeyWords.EmptyLiternal;
                case AccessSpecifier.Internal:
                    return KeyWords.Internal;
                case AccessSpecifier.Public:
                    return KeyWords.Public;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessSpecifier), accessSpecifier, null);
            }
        }

        public static string GetLiteral(this ClassType accessSpecifier)
        {
            switch (accessSpecifier)
            {
                case ClassType.Default:
                    return KeyWords.EmptyLiternal;
                case ClassType.Static:
                    return KeyWords.Static;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessSpecifier), accessSpecifier, null);
            }
        }
    }
}
