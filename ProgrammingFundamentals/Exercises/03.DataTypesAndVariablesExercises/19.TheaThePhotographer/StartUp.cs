namespace _19.TheaThePhotographer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long countOfPics = long.Parse(Console.ReadLine());
            long filterTimeOnePic = long.Parse(Console.ReadLine());
            long percentGoodPics = long.Parse(Console.ReadLine());
            long timeToUploadPic = long.Parse(Console.ReadLine());

            long filterTimeAll = countOfPics * filterTimeOnePic;
            double choosenPics = Math.Ceiling((percentGoodPics / 100d) * countOfPics);
            timeToUploadPic *= (long)choosenPics;
            long totalTime = filterTimeAll + timeToUploadPic;

            TimeSpan clock = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", clock);
        }
    }
}
