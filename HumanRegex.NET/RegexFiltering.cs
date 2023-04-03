namespace HumanRegex.NET
{
    public static class RegexFiltering
    {
        public static string Filter(this string text)
        {
            text.Replace(".", "\\.");
            return text;
        }
    }
}
