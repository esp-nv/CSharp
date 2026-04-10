

namespace P00.CreateDataStructures
{
    public static class StringExtensions
    {
        public static string ApplyWhiteSpace(this string input, int count=1)
        { 
            var whiteSpace = new string(' ',count);

            return $"{whiteSpace}{input}{whiteSpace}";
        }
    }
}
