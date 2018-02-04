namespace _04.VariableInHexFormat
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string inHexaFormat = Console.ReadLine();
            int HexaToDecFormat = Convert.ToInt32(inHexaFormat, 16);

            Console.WriteLine(HexaToDecFormat);   
        }
    }
}
