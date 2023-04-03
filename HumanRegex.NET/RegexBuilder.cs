using System.Text;

namespace HumanRegex.NET
{
    public class RegexBuilder
    {
        StringBuilder _RegexBuilder = new StringBuilder();
        internal void AppendRule(string reg) => _RegexBuilder.Append(reg);
        public string ToRegex() => _RegexBuilder.ToString();
    }
}