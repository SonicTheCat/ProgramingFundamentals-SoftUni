namespace _05.KeyReplacer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var keyWords = Console.ReadLine().Split(@"<|\".ToCharArray());
            var input = Console.ReadLine();

            List<string> result = new List<string>();
            var startKey = keyWords[0].Trim();
            var endKey = keyWords.Last().Trim();

            while (input.Length != 0)
            {
                int startIndex = input.IndexOf(startKey);
                if (startIndex == -1)
                {
                    break;
                }
                input = input.Remove(0, startIndex + startKey.Length);

                int endIndex = input.IndexOf(endKey);
                if (endIndex == -1)
                {
                    break;
                }
                var take = input.Substring(0, endIndex);
                input = input.Remove(0, take.Length + endKey.Length);

                if (take != "")
                {
                    result.Add(take);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join("", result));
            }
            else
            {
                Console.WriteLine("Empty result");
            }


        }
    }
}
