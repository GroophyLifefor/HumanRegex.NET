# Regex for Humans

The goal of this package is simple: give everybody the power of regular expressions without having 
to learn the complicated syntax. It is inspired by [human_regex](https://github.com/cmccomb/human_regex).

# Example usage
If you want to match a date of the format `2021-10-30`, you could use the following code to generate a regex:
```cs
RegexBuilder builder = new RegexBuilder()
  .Begin()
  .Exacly(4, IsAny.Digit)
  .Exacly('-')
  .Exacly(2, IsAny.Digit)
  .Exacly('-')
  .Exacly(2, IsAny.Digit)
  .End();
  
Console.WriteLine(Regex.IsMatch("2014-01-01", builder.ToRegex()));
```

The `ToRegex()` method returns a dependent writing. We can do this another way with slightly less repetition though!
```cs
RegexBuilder first_regex_string = new RegexBuilder()
  .Exacly('-')
  .Exacly(2, IsAny.Digit);

RegexBuilder second_regex_string = new RegexBuilder()
  .Begin()
  .Exacly(4, IsAny.Digit)
  .AppendRegexBuilder(first_regex_string)
  .AppendRegexBuilder(first_regex_string)
  .End();
  
Console.WriteLine(Regex.IsMatch("2014-01-01", second_regex_string.ToRegex()));
```

