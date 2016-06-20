namespace StringBuilderSubstring.Extensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            var str = strBuilder.ToString().Substring(index, length);
            strBuilder.Clear();

            return strBuilder.Append(str);
        }
    }
}

//return new StringBuilder(strBuilder.ToString().Substring(start, count));