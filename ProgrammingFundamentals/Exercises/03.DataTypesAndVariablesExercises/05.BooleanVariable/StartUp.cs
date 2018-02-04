namespace _05.BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string trueOrFalse = Console.ReadLine();
            bool convertedStr = Convert.ToBoolean(trueOrFalse);

            switch (convertedStr)
            {
                case true: Console.WriteLine("Yes");break;
                case false: Console.WriteLine("No");break;
            }
        }
    }
}
