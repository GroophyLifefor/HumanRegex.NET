using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace HumanRegex.NET
{
    public static class RegexItems
    {
        /// <summary>
        /// Add begin as '^'.
        /// </summary>
        public static RegexBuilder Begin(this RegexBuilder regexBuilder)
        {
            regexBuilder.AppendRule($"^");
            return regexBuilder;
        }

        /// <summary>
        /// Add end as '$'.
        /// </summary>
        public static RegexBuilder End(this RegexBuilder regexBuilder)
        {
            regexBuilder.AppendRule($"$");
            return regexBuilder;
        }

        public static RegexBuilder AppendRegexBuilder(this RegexBuilder regexBuilder, RegexBuilder appendRegexBuilder)
        {
            regexBuilder.AppendRule(appendRegexBuilder.ToRegex());
            return regexBuilder;
        }
		

        /// <summary>
        /// Exacly find a text.
        /// </summary>
        public static RegexBuilder Exacly(this RegexBuilder regexBuilder, char text)
        {
            regexBuilder.AppendRule($"\\b{text.ToString().Filter()}\\b");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find a text same as upper one.
        /// </summary>
        public static RegexBuilder Exacly(this RegexBuilder regexBuilder, string text)
        {
            regexBuilder.AppendRule($"\\b{text.Filter()}\\b");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find is valid in specific lenght
        /// </summary>
        public static RegexBuilder Exacly(this RegexBuilder regexBuilder, int lenght, IsAny Is)
        {
            regexBuilder.AppendRule($"{Is.Convert()}{{{lenght}}}");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find is valid
        /// </summary>
        public static RegexBuilder Exacly(this RegexBuilder regexBuilder, IsAny Is)
        {
            regexBuilder.AppendRule($"{Is.Convert()}");
            return regexBuilder;
        }

        //------NOT VALID---------------------------------------------------------------------------------------------------

        /// <summary>
        /// Exacly find not valid text.
        /// </summary>
        public static RegexBuilder ExaclyNot(this RegexBuilder regexBuilder, char text)
        {
            regexBuilder.AppendRule($"(?!{text.ToString().Filter()}).*");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find not valid text same as upper one.
        /// </summary>
        public static RegexBuilder ExaclyNot(this RegexBuilder regexBuilder, string text)
        {
            regexBuilder.AppendRule($"(?!{text.Filter()}).*");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find is not valid in specific lenght
        /// </summary>
        public static RegexBuilder ExaclyNot(this RegexBuilder regexBuilder, int lenght, IsAny Is)
        {
            regexBuilder.AppendRule($"{Is.Convert(not: true)}{{{lenght}}}");
            return regexBuilder;
        }

        /// <summary>
        /// Exacly find is valid
        /// </summary>
        public static RegexBuilder ExaclyNot(this RegexBuilder regexBuilder, IsAny Is)
        {
            regexBuilder.AppendRule($"{Is.Convert(not: true)}");
            return regexBuilder;
        }
    }
}
