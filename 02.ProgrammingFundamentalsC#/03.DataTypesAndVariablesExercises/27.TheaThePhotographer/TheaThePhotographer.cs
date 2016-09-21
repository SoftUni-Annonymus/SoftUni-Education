using System;
class TheaThePhotographer
{
    static void Main()
    {
        var amount = int.Parse(Console.ReadLine());
        var time = int.Parse(Console.ReadLine());
        var procent = int.Parse(Console.ReadLine());
        var timeToFiltered = int.Parse(Console.ReadLine());

        decimal filteredPictures =(int)Math.Ceiling(amount * procent / 100.0);
        decimal timeToSec =time * 60;
        decimal filteredTimeToSeconds =timeToFiltered * 60;
        decimal timeToPadecimalInSeconds =(amount * timeToSec)/60;
        decimal timeToUploadInSeconds =(filteredPictures * filteredTimeToSeconds) / 60;
        decimal totalTime =timeToPadecimalInSeconds + timeToUploadInSeconds;
        TimeSpan t = TimeSpan.FromSeconds((Convert.ToDouble(totalTime)));
        var timeInFormat= t.ToString(@"d\:hh\:mm\:ss");
        Console.WriteLine(timeInFormat);
    }
}