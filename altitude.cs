using System;

namespace C_
{
   public class altitude
    {
    
        public void altitudesub()
        {
            Console.Write("Enter altitude 1: ");
            int altitude1 = int.Parse(Console.ReadLine());

            Console.Write("Enter altitude 2: ");
            int altitude2 = int.Parse(Console.ReadLine());

            int altitudeChange = altitude2 - altitude1;

            Console.Write("Change in altitude = " + altitudeChange);

        }
    }
}
