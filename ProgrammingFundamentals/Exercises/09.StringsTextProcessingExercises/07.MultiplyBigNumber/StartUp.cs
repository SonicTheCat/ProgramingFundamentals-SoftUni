namespace _07.MultiplyBigNumber
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string bigNum = Console.ReadLine().TrimStart('0');
            int singleDigit = int.Parse(Console.ReadLine());
            if (singleDigit==0)
            {
                Console.WriteLine('0');
                return;
            }

            StringBuilder result = new StringBuilder();
            long reminder = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                long num = bigNum[i] - 48;
                long sum = (num * singleDigit + reminder);
                reminder = sum / 10;
                result.Append(sum % 10);
                if (i == 0 && reminder > 0)
                {
                    result.Append(reminder);
                }
            }

           char[] reverse = result.ToString().ToCharArray().Reverse().ToArray();
           Console.WriteLine(string.Join("",reverse));
        }
    }
}
