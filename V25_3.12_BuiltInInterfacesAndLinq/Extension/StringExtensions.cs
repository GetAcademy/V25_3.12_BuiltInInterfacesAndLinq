using System.Text;

namespace V25_3._12_BuiltInInterfacesAndLinq.Extension;

public static class StringExtensions
{
    public static string Repeat(this string text, int count)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < count; i++)
        {
            sb.Append(text);
        }

        return sb.ToString();
    }

    public static string Capitalize(this string text)
    {
        return text[0].ToString().ToUpper() + text[1..];
    }
}