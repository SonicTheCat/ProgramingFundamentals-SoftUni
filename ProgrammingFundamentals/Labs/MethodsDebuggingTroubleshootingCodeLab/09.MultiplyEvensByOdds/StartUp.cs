namespace _09.MultiplyEvensByOdds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int Num = Math.Abs(int.Parse(Console.ReadLine()));
            int result= MultipleOfEvensAndOdds(Num);
            Console.WriteLine(result);
        }
        static int SumOfEvens(int Num)
        {
            var sumEvens = 0;
            while (Num>0)
            {
                var digit = Num % 10;
                if (digit % 2 == 0)
                {
                    sumEvens += digit;
                }
                Num = Num / 10;
            }           
            return sumEvens;
        }
        static int SumOfOdds(int Num)
        {
            var sumOdds = 0;
            while (Num > 0)
            {
                var digit = Num % 10;
                if (digit % 2 != 0)
                {
                    sumOdds += digit;
                }
                Num = Num / 10;
            }
            return sumOdds;
        }
        static int MultipleOfEvensAndOdds(int Num)
        {
            int mult = SumOfEvens(Num) * SumOfOdds(Num);
            return mult;
        }
    }
}
