namespace bogosort
{
    public static class StringUtilities
    {
        static readonly Random r = new();
        public static string Reverse(this string stringToReverse)
        {
            var currentString = stringToReverse;
            while (!IsReversed(stringToReverse, currentString))
                currentString = Remap(currentString);
            return currentString;

            bool IsReversed(string stringToReverse, string currentString) => !stringToReverse.Where((t, i) => t != currentString[^(i + 1)]).Any();
            string Remap(string currentString)
            {
                var list = currentString.ToList();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = r.Next(n + 1);
                    (list[n], list[k]) = (list[k], list[n]);
                }
                return new string(list.ToArray());
            }
        }
    }
}
