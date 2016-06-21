/// <summary>
/// Problem 1. StringBuilder.Substring
/// Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and 
/// has the same functionality as Substring in the class String.
/// </summary>

namespace StringBuilderSubstring
{
    using StringBuilderSubstring.Extensions;
    using System;
    using System.Text;

    class Startup
    {
        public static void Main()
        {
            //var input = Console.ReadLine();
            var sb = new StringBuilder();
            sb.Append("Test for Substring method!"); //sb.Append(input);
            
            var index = 3; //int.Parse(Console.ReadLine());
            var length = 5; // int.Parse(Console.ReadLine());
            
            //Console.WriteLine(sb.Substring(index, length));
            Console.WriteLine(StringBuilderExtensions.Substring(sb, index, length));
        }
    }
}
