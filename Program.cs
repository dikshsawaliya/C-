using System;

namespace C_
{
   public class Program
    {
        //static void Main(string[] args)
        public void prg()
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            Console.Write(" Total Minutes PLayed = " + minutesPlayed);
            Console.Write(" Total Seconds Played = " + secondsPlayed);
        }
    }
}
