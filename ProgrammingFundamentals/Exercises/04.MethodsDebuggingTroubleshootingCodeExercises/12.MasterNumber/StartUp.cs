namespace _12.MasterNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                if (isPolindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }    
        }

        static bool isPolindrome(int num)
        {
            string number = num.ToString();
            bool trueOrFalse = true;
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    trueOrFalse = false;
                }
            }
            return trueOrFalse;
        }

        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sumOfDigits = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sumOfDigits += int.Parse(number[i].ToString());
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();       
            for (int i = 0; i < number.Length; i++)
            {
               int digit = int.Parse(number[i].ToString());
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
