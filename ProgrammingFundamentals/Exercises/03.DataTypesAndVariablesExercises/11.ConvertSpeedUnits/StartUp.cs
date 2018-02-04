namespace _11.ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float second = float.Parse(Console.ReadLine());
            // Инпута го направих със "float",
            //ако използвам "Int" за входните данни и след това се опитам да "кастна" става няк'во мазало? 
            float convertToSeconds = ((hours * 60) * 60) + (minutes * 60) + second;
            float convertToHours = ((second / 60) / 60) + (minutes / 60) + hours;
            float metersToKm = (meters / 1000);
            float metersToMiles = (meters / 1609);

            Console.WriteLine(meters / convertToSeconds);
            Console.WriteLine(metersToKm / convertToHours);
            Console.WriteLine(metersToMiles / convertToHours);
        }
    }
}
