namespace HumanRegex.NET
{
    public enum IsAny
    {
        Digit,
        LowerCase,
        UpperCase,
        LowerOrUpperCase,
        Any
    }

    public static class IsAnyConverter
    {
        public static string Convert(this IsAny any, bool not = false)
        {
            return any switch
            {
                IsAny.Digit => not ? "[^\\d]" : "\\d",
                IsAny.LowerCase => not ? "[^a-z]" : "[a-z]",
                IsAny.UpperCase => not ? "[^A-Z]" : "[A-Z]",
                IsAny.LowerOrUpperCase => not ? "[^a-zA-Z]" : "[a-zA-Z]",
                IsAny.Any => not ? "[^*]+" : "[*]+"
            };
        }
    }
}
